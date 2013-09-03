using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace FSAircraftRepositoryFactory.Forms
{
    public partial class ResultForm : Form
    {
        private MainForm mainForm;
        private List<RegistryAircraft> filteredAircrafts = new List<RegistryAircraft>();
        public RegistryAircraft editedAircraft;

        public ResultForm(MainForm main)
        {
            InitializeComponent();
            mainForm = main;
            ShowResult();
        }

        private void ShowResult() {
            foreach (RegistryAircraft ac in mainForm.registryForm.registry_aircrafts) {
                if (ac.new_title != "") {
                    filteredAircrafts.Add(ac);
                }
            }
            if (filteredAircrafts.Count == 0)
            {
                MessageBox.Show("There are no changes to the registry aircraft repository");
                button1.Enabled = false;
            }
            else {
                RenderGrid();
                button1.Enabled = true;
            }
        }

        public void AircraftChanged()
        {
            RenderGrid();
            MessageBox.Show("The aircraft has been changed");
        }

        private void RenderGrid() {
            acGrid.Rows.Clear();
            foreach (RegistryAircraft ac in filteredAircrafts) {
                int row = acGrid.Rows.Add();
                acGrid.Rows[row].Cells[0].Value = ac.icao;
                acGrid.Rows[row].Cells[1].Value = ac.airline;
                acGrid.Rows[row].Cells[2].Value = ac.current_title;
                acGrid.Rows[row].Cells[3].Value = ac.new_title;
            }
        }

        private void Export() {
            string output = "Windows Registry Editor Version 5.00" + Environment.NewLine;
            string backup = "Windows Registry Editor Version 5.00" + Environment.NewLine;
            foreach (RegistryAircraft ac in mainForm.registryForm.registry_aircrafts)
            {
                Logger.Log(ac.icao + " / " + ac.airline + " / " + ac.current_title + " -> " + ac.new_title);
                                
                if (ac.new_title != "" /*&& ac.new_title != ac.current_title*/)
                {
                    if (mainForm.registryForm.registry_type == "LOCAL_MACHINE")
                    {
                        backup += "[HKEY_LOCAL_MACHINE\\" + ac.path + "]" + Environment.NewLine;
                    }
                    else {
                        backup += "[HKEY_CURRENT_USER\\" + ac.path + "]" + Environment.NewLine;
                    }
                    backup += "@=\"" + ac.current_title + "\"" + Environment.NewLine;
                    backup += "\"User\"=dword:00000000" + Environment.NewLine;
                    backup += Environment.NewLine;

                    if (mainForm.registryForm.registry_type == "LOCAL_MACHINE")
                    {
                        output += "[HKEY_LOCAL_MACHINE\\" + ac.path + "]" + Environment.NewLine;
                    }
                    else {
                        output += "[HKEY_CURRENT_USER\\" + ac.path + "]" + Environment.NewLine;
                    }
                    output += "@=\"" + ac.new_title + "\"" + Environment.NewLine;
                    output += "\"User\"=dword:00000000" + Environment.NewLine;
                    output += Environment.NewLine;
                }
            }

            if (output.Length > 0)
            {
                SaveFileDialog save = new SaveFileDialog();
                save.DefaultExt = ".reg";
                save.AddExtension = true;
                save.Title = "Choose location and filename for export registry changes";

                if (save.ShowDialog() == DialogResult.OK)
                {
                    StreamWriter backup_file = new StreamWriter(save.FileName + ".backup");
                    backup_file.Write(backup);
                    backup_file.Close();
                    StreamWriter export = new StreamWriter(save.FileName);
                    export.Write(output);
                    export.Close();
                    MessageBox.Show("The changes were exported successfully.");
                    mainForm.Step4Complete();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("There are no changes to write.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Export();
        }

        private void acGrid_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3) {
                AircraftSelectForm asf = new AircraftSelectForm(filteredAircrafts[e.RowIndex], mainForm);
                asf.ShowDialog();
            } 
        }
    }
}
