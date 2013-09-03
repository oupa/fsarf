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
    public partial class MainForm : Form
    {
        public string fsDirectory;
        public AnalyzeForm analyzeForm;
        public RegistryForm registryForm;
        public AssignForm assignForm;
        public ResultForm resultForm;
        public EditRegistryForm editRegistryForm;
        
        public MainForm()
        {
            InitializeComponent();
            Logger.Init();
            Logger.Log("");
            Logger.Log("Starting application...");
            registryButton.Enabled = false;
            assignButton.Enabled = false;
            exportButton.Enabled = false;
            ICAO.Build();
            VersionChecker.CheckVersion();
        }

        private void analyzeButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.ShowNewFolderButton = false;
            fbd.Description = "Select folder with FS aircrafts (e.g. .../FSX/SimObjects/Airplanes)";
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                fsDirectory = fbd.SelectedPath;
                showAnalyzer();
            }
            fbd.Dispose();
        }

        private void showAnalyzer()
        {
            analyzeForm = new AnalyzeForm(this);
            analyzeForm.ShowDialog();
        }

        public void Step1Complete() {
            if (analyzeForm.aircrafts.Count > 0) {
                panel1.BackColor = System.Drawing.Color.LightGreen;
                analyzeButton.Enabled = false;
                registryButton.Enabled = true;
            }
        }

        public void Step2Complete()
        {
            if (registryForm.registry_aircrafts.Count > 0) {
                panel2.BackColor = System.Drawing.Color.LightGreen;
                registryButton.Enabled = false;
                assignButton.Enabled = true;
            }
        }

        public void Step3Complete()
        {
            panel3.BackColor = System.Drawing.Color.LightGreen;
            exportButton.Enabled = true;
        }

        public void Step4Complete()
        {
            panel4.BackColor = System.Drawing.Color.LightGreen;
        }

        private void registryButton_Click(object sender, EventArgs e)
        {
            registryForm = new RegistryForm(this);
            registryForm.ShowDialog();
        }

        private void assignButton_Click(object sender, EventArgs e)
        {
            assignForm = new AssignForm(this);
            assignForm.ShowDialog();
        }

        private void exportButton_Click(object sender, EventArgs e)
        {
            if (resultForm == null) resultForm = new ResultForm(this);
            resultForm.ShowDialog();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void editRegistryButton_Click(object sender, EventArgs e)
        {
            //editRegistryForm = new EditRegistryForm(this);
            //editRegistryForm.ShowDialog();
            MessageBox.Show("Not implemented yet");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Logger.loggingEnabled = checkBox1.Checked;
        }
    }
}
