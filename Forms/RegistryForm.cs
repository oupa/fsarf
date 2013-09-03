using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;

namespace FSAircraftRepositoryFactory.Forms
{
    public partial class RegistryForm : Form
    {
        private MainForm mainForm;
        public List<string> registry_icao;
        public List<RegistryAircraft> registry_aircrafts;
        public string registry_path;
        public string registry_type;
        public string path_type;

        public RegistryForm(MainForm main)
        {
            InitializeComponent();
            registry_type = "LOCAL_MACHINE";
            radioLOCAL_MACHINE.Checked = true;
            path_type = "FSX64";
            mainForm = main;
            pathLabel.Text = "The program will attemt to read values from the following registry location.\nYou don`t have to worry, this is read-only operation. Don`t change the path unless you know what you are doing!";
        }

        private void RegistryForm_Load(object sender, EventArgs e)
        {
            pathTxt.Text = "SOFTWARE\\Wow6432Node\\FSFDT\\FSCopilot\\1.0\\AcftDB\\FS2006\\ICAOPref";
        }

        private void button64bit_Click(object sender, EventArgs e)
        {
            if (registry_type == "CURRENT_USER")
            {
                pathTxt.Text = "Software\\Classes\\VirtualStore\\MACHINE\\SOFTWARE\\Wow6432Node\\FSFDT\\FSCopilot\\1.0\\AcftDB\\FS2006\\ICAOPref";
            }
            else {
                pathTxt.Text = "SOFTWARE\\Wow6432Node\\FSFDT\\FSCopilot\\1.0\\AcftDB\\FS2006\\ICAOPref";
            }
            path_type = "FSX64";
        }

        private void button32bit_Click(object sender, EventArgs e)
        {
            if (registry_type == "CURRENT_USER")
            {
                pathTxt.Text = "Software\\Classes\\VirtualStore\\MACHINE\\SOFTWARE\\FSFDT\\FSCopilot\\1.0\\AcftDB\\FS2006\\ICAOPref";
            }
            else
            {
                pathTxt.Text = "SOFTWARE\\FSFDT\\FSCopilot\\1.0\\AcftDB\\FS2006\\ICAOPref";
            }
            path_type = "FSX32";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (registry_type == "CURRENT_USER")
            {
                pathTxt.Text = "Software\\Classes\\VirtualStore\\MACHINE\\SOFTWARE\\FSFDT\\FSCopilot\\1.0\\AcftDB\\FS2004\\ICAOPref";
            }
            else
            {
                pathTxt.Text = "SOFTWARE\\FSFDT\\FSCopilot\\1.0\\AcftDB\\FS2004\\ICAOPref";
            }
            path_type = "FS932";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (registry_type == "CURRENT_USER")
            {
                pathTxt.Text = "Software\\Classes\\VirtualStore\\MACHINE\\SOFTWARE\\Wow6432Node\\FSFDT\\FSCopilot\\1.0\\AcftDB\\FS2004\\ICAOPref";
            }
            else
            {
                pathTxt.Text = "SOFTWARE\\Wow6432Node\\FSFDT\\FSCopilot\\1.0\\AcftDB\\FS2004\\ICAOPref";
            }
            path_type = "FS964";
        }

        private void analyzeButton_Click(object sender, EventArgs e)
        {
            Analyze();
        }

        private void Analyze() {
            registry_path = pathTxt.Text;
            RegistryKey key;
            if (registry_type == "LOCAL_MACHINE")
            {
                key = Registry.LocalMachine.OpenSubKey(registry_path);
            }
            else {
                key = Registry.CurrentUser.OpenSubKey(registry_path);
            }
            registry_icao = new List<string>();
            registry_aircrafts = new List<RegistryAircraft>();

            try
            {
                registry_icao.AddRange(key.GetSubKeyNames());
                
                foreach (string path in registry_icao)
                {
                    RegistryKey ac_key;
                    if (registry_type == "LOCAL_MACHINE")
                    {
                        ac_key = Registry.LocalMachine.OpenSubKey(registry_path + "\\" + path);
                    }
                    else {
                        ac_key = Registry.CurrentUser.OpenSubKey(registry_path + "\\" + path);
                    }
                    foreach (string var in ac_key.GetSubKeyNames())
                    {
                        RegistryAircraft ac = new RegistryAircraft();
                        RegistryKey var_key = Registry.LocalMachine.OpenSubKey(registry_path + "\\" + path + "\\" + var);
                        ac.path = registry_path + "\\" + path + "\\" + var;
                        ac.icao = path;
                        ac.airline = var;
                        ac.current_title = (string)var_key.GetValue(null);
                        registry_aircrafts.Add(ac);
                    }
                }

            }
            catch (NullReferenceException) {
                MessageBox.Show("No reference of FSInn registry was found on specified path, sorry");
                return;
            }

            MessageBox.Show("Total " + registry_aircrafts.Count.ToString() + " aircrafts in registry.", "Analysis complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();
            mainForm.Step2Complete();
        }

        private void radioLOCAL_MACHINE_CheckedChanged(object sender, EventArgs e)
        {
            //radioCURRENT_USER.Checked = false;
            registry_type = "LOCAL_MACHINE";
            updatePath(); 
        }

        private void radioCURRENT_USER_CheckedChanged(object sender, EventArgs e)
        {
            //radioLOCAL_MACHINE.Checked = false;
            registry_type = "CURRENT_USER";
            updatePath();
        }

        private void updatePath() {
            switch (path_type) { 
                case "FSX64":
                    button64bit_Click(null, null);
                    break;
                case "FSX32":
                    button32bit_Click(null, null);
                    break;
                case "FS964":
                    button1_Click(null, null);
                    break;
                case "FS932":
                    button2_Click(null, null);
                    break;
            }
        }

        
    }
}
