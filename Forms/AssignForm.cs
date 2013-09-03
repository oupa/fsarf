using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FSAircraftRepositoryFactory.Forms
{
    public partial class AssignForm : Form
    {
        MainForm mainForm;
        int currentIndex = 0;
        public bool stopSearch;
                
        public int decideResult;

        public AssignForm(MainForm main)
        {
            InitializeComponent();
            assignLabel.Text = "The program will now walk through the repository in registry and search for an appropriate match in your FS repository. You can choose if you want fully automatic process or if you wish to have control. If exact match is found and there is only one alternative, the program will always assign it automatically.";
            radioButton1.Text = "1. Fully automatic\n(will pick first available exact match, or first available aircraft by airline and family,\nor at worst case by airline only)";
            radioButton2.Text = "2. Ask when no exact match is found\n(will offer alternatives based on search by airline and family)";
            radioButton3.Text = "3. Ask also when multiple variants are found\n(will offer all possible variants in case more exact matches are found)\nPlus all features from mode 2.";
            label2.Text = "Note: Non-automatic modes can take long time - user interaction is required\n(depending on the size of your aircraft repository).\nRecommend use of mode 3 only with filtering.";
            mainForm = main;
            radioButton2.Checked = true;
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            Assign();
        }

        private void Assign()
        {
            currentIndex = -1;
            stopSearch = false;
            SearchNext();
        }

        private void SearchNext() {
            currentIndex++;
            //Logger.Log("Seach next " + currentIndex.ToString() + " < " + mainForm.registryForm.registry_aircrafts.Count);
            if (currentIndex >= mainForm.registryForm.registry_aircrafts.Count || stopSearch)
            {
                Cursor.Current = Cursors.Default;
                MessageBox.Show("Finished search", "Assign completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mainForm.Step3Complete();
                this.Close();
                return;
            }
            else {
                Search();
            }
        }

        private void Search()
        {
            RegistryAircraft reg_ac = mainForm.registryForm.registry_aircrafts[currentIndex];
            Logger.Log(reg_ac.icao + " " + reg_ac.airline);
            List<Aircraft> unsorted = new List<Aircraft>();
            List<Aircraft> result = new List<Aircraft>();

            // filter
            if (reg_ac.current_title != "" && checkNew.Checked) {
                //Logger.Log("Skipping (new filter)");
                SearchNext();
                return;    
            }

            if (checkAirlineFilter.Checked) {
                if (filterAirline.Text.Length > 0) {
                    if (!reg_ac.airline.Contains(filterAirline.Text)) {
                        //Logger.Log("Skipping (AL filter)");
                        SearchNext();
                        return;
                    }
                }
            }

            if (checkFamilyFilter.Checked)
            {
                if (filterIcao.Text.Length > 0)
                {
                    if (!reg_ac.icao.Contains(filterIcao.Text))
                    {
                        //Logger.Log("Skipping (icao filter)");
                        SearchNext();
                        return;
                    }
                }
            }

            //

            unsorted.AddRange(FindExact(reg_ac));

            bool exactMatch = false;
            if (unsorted.Count > 0) exactMatch = true;
            bool resolvedAirlineFamily = false;

            if (unsorted.Count == 0)
            {
                // exact match was not found - will try to search by airline and family (first 3 letters from icao)
                unsorted.AddRange(FindByAirlineAndFamily(reg_ac, false));
                if (result.Count == 0)
                { // nothing was found by airline and family - will search by airline only
                    unsorted.AddRange(FindByAirlineAndFamily(reg_ac, true));
                }
                else {
                    resolvedAirlineFamily = true;
                }
            }

            result.AddRange(SortResult(unsorted, reg_ac.icao));            

            if (result.Count > 1 || (resolvedAirlineFamily && radioButton2.Checked)) {
                if (radioButton1.Checked || (exactMatch && radioButton2.Checked))
                {
                    Aircraft res_ac = result.ElementAt(0);
                    Logger.Log("Automatic choice for " + reg_ac.icao + " / " + reg_ac.airline + " (curr " + reg_ac.current_title + " ) --> " + res_ac.title + " (" + res_ac.match_count + "pts)");
                    reg_ac.new_title = res_ac.title;
                }
                else {
                    string message = result.Count.ToString() + " matches found for " + reg_ac.icao + " / " + reg_ac.airline + "\n";
                    DecideForm decide = new DecideForm(this, message, result);
                    decide.ShowDialog();
                    Aircraft res_ac = result.ElementAt(decideResult);
                    decide.Dispose();
                    Logger.Log("User choice for " + reg_ac.icao + " / " + reg_ac.airline + " (curr " + reg_ac.current_title + " ) --> " + res_ac.title);
                    reg_ac.new_title = res_ac.title;
                }
            }
            else if (result.Count == 1)
            {
                Aircraft res_ac = result.ElementAt(0);
                Logger.Log("One match found for " + reg_ac.icao + " / " + reg_ac.airline + " (curr " + reg_ac.current_title + " ) --> " + res_ac.title);
                reg_ac.new_title = res_ac.title;
            }
            else {
                Logger.Log("No match was found");
            }

            SearchNext();
        }

        private List<Aircraft> SortResult(List<Aircraft> unsorted, string compare_icao) {
            string reg_wake = ICAO.GetWake(compare_icao);
            string reg_eng_type = ICAO.GetEngineType(compare_icao);
            int reg_eng_count = ICAO.GetEngineCount(compare_icao);

            // assign match to result aircrafts
            if (unsorted.Count > 1)
            {
                foreach (Aircraft temp_ac in unsorted)
                {
                    temp_ac.match_count = 0;
                    if (reg_wake == temp_ac.wake) temp_ac.match_count = 4;
                    if (reg_eng_type == temp_ac.engine_type) temp_ac.match_count += 2;
                    if (reg_eng_count == temp_ac.engine_count) temp_ac.match_count += 2;
                    int min1 = Math.Min(2, compare_icao.Length);
                    int min2 = Math.Min(2, temp_ac.icao.Length);
                    int min3 = Math.Min(3, compare_icao.Length);
                    int min4 = Math.Min(3, temp_ac.icao.Length);
                    if (compare_icao.Substring(0, min1) == temp_ac.icao.Substring(0, min2)) temp_ac.match_count += 1;
                    if (compare_icao.Substring(0, min3) == temp_ac.icao.Substring(0, min4)) temp_ac.match_count += 2;
                    if (temp_ac.title.Contains(compare_icao.Substring(0, min3))) temp_ac.match_count += 1;
                }

                unsorted.Sort(delegate(Aircraft a1, Aircraft a2) { return a1.match_count.CompareTo(a2.match_count); });
                unsorted.Reverse();
            }
            return unsorted;
        }

        private List<Aircraft> FindExact(RegistryAircraft reg_ac)
        {
            List<Aircraft> result = new List<Aircraft>();
            string reg_type = ICAO.GetType(reg_ac.icao);
            foreach (Aircraft ac in mainForm.analyzeForm.aircrafts)
            {
                string edited_type = ac.ui_type.Replace(" ", "");
                edited_type = edited_type.Replace("-", "");
                edited_type = edited_type.ToUpper();
                string edited_model = ac.atc_model.Replace(" ", "");
                edited_model = edited_model.Replace("-", "");
                edited_model = edited_model.ToUpper();

                if (
                       (ac.atc_model.Contains(reg_ac.icao) || 
                        ac.ui_type.Contains(reg_ac.icao) || 
                        edited_type.Contains(reg_type) || 
                        edited_model.Contains(reg_type)
                       ) 
                       && reg_ac.icao != "")
                {
                    ac.icao = reg_ac.icao;
                    if (ac.atc_airline.ToUpper() == reg_ac.airline || ac.atc_parking_codes.ToUpper() == reg_ac.airline || ac.texture.ToUpper() == reg_ac.airline)
                    {
                        ac.Fill();
                        Logger.Log("FindExact : " + reg_ac.airline + " / " + reg_ac.icao + " ==> " + ac.title);
                        result.Add(ac);
                    }
                }
            }
            return result;
        }

        private List<Aircraft> FindByAirlineAndFamily(RegistryAircraft reg_ac, bool airline_only)
        {
            List<Aircraft> result = new List<Aircraft>();
            foreach (Aircraft ac in mainForm.analyzeForm.aircrafts){
                string reg_family = "";
                string ac_family = "";

                if (!airline_only)
                {
                    try
                    {
                        int min = Math.Min(2, reg_ac.icao.Length);
                        reg_family = reg_ac.icao.Substring(0, min);
                    }
                    catch (NullReferenceException)
                    {
                        return result;
                    }

                    if (ac.atc_model.Length >= 2)
                    {
                        ac_family = ac.atc_model.Substring(0, 2);
                        ac.icao = ac.atc_model;
                    } 
                    if (ac.ui_type.Length >= 2 && ac_family == "")
                    {
                        ac_family = ac.ui_type.Substring(0, 2);
                        ac.icao = ac.ui_type;
                    }
                }
                if ((ac_family == reg_family && ac_family != "" && reg_family != "") || airline_only)
                {
                    if (ac.atc_airline.ToUpper() == reg_ac.airline || ac.atc_parking_codes.ToUpper() == reg_ac.airline || ac.texture.ToUpper() == reg_ac.airline)
                    {
                        ac.Fill();
                        Logger.Log("FindByAirlineAndFamily : " + reg_ac.airline + " / " + reg_ac.icao + " ==> " + ac.title + " / " + airline_only.ToString());
                        result.Add(ac);
                    }
                }
            }

            return result;
        }
    }
}
