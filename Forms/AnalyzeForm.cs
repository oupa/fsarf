using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using FSAircraftRepositoryFactory;

namespace FSAircraftRepositoryFactory.Forms
{
    public partial class AnalyzeForm : Form
    {
        private MainForm mainForm;
        private List<string> cfgPaths;
        public List<Aircraft> aircrafts = new List<Aircraft>();
        public List<string> airlines = new List<string>();
        public List<string> sims = new List<string>();
        public List<string> manufacturers = new List<string>();

        public AnalyzeForm(MainForm main)
        {
            InitializeComponent();
            mainForm = main;
        }

        public void Analyze()
        {
            Cursor.Current = Cursors.WaitCursor;
            string dir = mainForm.fsDirectory;
            Logger.Log("Starting analysis: " + dir);
            analyzeText.Text = "Analyzing " + dir;
            cfgPaths = new List<string>();
            cfgPaths.AddRange(Directory.GetFiles(dir, "aircraft.cfg", SearchOption.AllDirectories));
            analyzeText.Text = "Found " + cfgPaths.Count + " aircraft.cfg";
            //Logger.Log("Found " + cfgPaths.Count + " aircraft.cfg");
            
            // ted bude prochazet vsechny aircraft.cfg a vypisovat letadla
            foreach (string f in cfgPaths) {
                analyzeText.Text = "Analyzing " + f;
                AnalyzeCFG(f);
            }

            Logger.Log("Repository analysis complete : " + aircrafts.Count + " aircraft variations");
            analyzeText.Text = "Analysis complete";
            MessageBox.Show(aircrafts.Count + " aircraft variations found", "Repository analysis complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            // 
            Cursor.Current = Cursors.Default;
            mainForm.Step1Complete();
            this.Hide();
        }

        private void AnalyzeCFG(string path)
        {
            //Logger.Log("Reading " + path);
            List<string> lines = new List<string>();
            List<List<string>> segments = new List<List<string>>();
            lines.AddRange(File.ReadAllLines(path));

            string atc_type = "";
            string atc_model = "";
            string ui_type = "";

            // nejdrive precti to zakladni
            foreach (string line in lines) { 
                if (line.Contains("atc_type")){
                    atc_type = GetValue(line);
                }
                if (line.Contains("atc_model"))
                {
                    atc_model = GetValue(line);
                }
                if (line.Contains("ui_type"))
                {
                    ui_type = GetValue(line);
                }
            }
            if ((atc_type != "" || ui_type != "") /*&& atc_model != ""*/)
            {
                //Logger.Log("Aircraft : " + atc_type + " , " + atc_model);
            } else {
                Logger.Log("Aircraft values not found... " + path);
                return;
            }

            // vytvorime pole segmentu
            List<string> segment = new List<string>();

            foreach (string line in lines) { 
                if (line.Contains("[")){
                    if (segment.Count > 0) {
                        segments.Add(segment);
                    }
                    segment = new List<string>();
                    segment.Add(line);
                } else {
                    segment.Add(line);
                }
            }
           
            //HKEY_LOCAL_MACHINE\SOFTWARE\Wow6432Node\FSFDT\FSCopilot\1.0\AcftDB\FS2006\ICAOPref
            
            // zajimaji me pouze segmenty, ktere zacinaji fltsim

            foreach (List<string> seg in segments) {
                if (seg.First().Contains("fltsim")) {
                    Aircraft ac = new Aircraft();
                    ac.atc_type = atc_type;
                    ac.atc_model = atc_model;
                    ac.ui_type = ui_type;
                    foreach (string line in seg) {
                        if (line.Contains("ui_manufacturer")) { ac.ui_manufacturer = GetValue(line); }
                        if (line.Contains("title")) { ac.title = GetValue(line); }
                        if (line.Contains("texture")) { ac.texture = GetValue(line); }
                        if (line.Contains("atc_airline")) { ac.atc_airline = GetValue(line); }
                        if (line.Contains("atc_parking_codes")) { ac.atc_parking_codes = GetValue(line); }
                        if (line.Contains("ui_variation")) { ac.ui_variation = GetValue(line); }
                        if (line.Contains("sim")) { ac.sim = GetValue(line); }
                    }
                    /*string airline = "";

                    if (ac.atc_airline != "") 
                    {
                        airline = ac.atc_airline;
                    }
                    if (!airlines.Contains(airline)) 
                    {
                        airlines.Add(airline);
                    }*/

                    string sim = "";

                    if (ac.sim != "")
                    {
                        sim = ac.sim;
                    }
                    if (!sims.Contains(sim))
                    {
                        sims.Add(sim);
                    }

                    string manufacturer = "";

                    if (ac.ui_manufacturer != "")
                    {
                        manufacturer = ac.ui_manufacturer;
                    }
                    if (!manufacturers.Contains(manufacturer))
                    {
                        manufacturers.Add(manufacturer);
                    }

                    aircrafts.Add(ac);
                }
            }
            //airlines.Sort();
            manufacturers.Sort();
            sims.Sort();
        }

        private string GetValue(string line)
        {
            return line.Substring(line.IndexOf("=", 0) + 1);
        }

        private void AnalyzeForm_Load(object sender, EventArgs e)
        {
            analyzeText.Text = "Click button to start...";
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            Analyze();
        }
    }
}
