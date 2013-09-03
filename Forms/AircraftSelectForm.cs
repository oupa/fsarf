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
    public partial class AircraftSelectForm : Form
    {
        private RegistryAircraft edited_ac;
        private MainForm mainForm;
        private List<Aircraft> filteredAircrafts = new List<Aircraft>();
        private List<string> filteredTypes = new List<string>();
        private Aircraft selectedAircraft;

        public AircraftSelectForm(RegistryAircraft eac, MainForm main)
        {
            InitializeComponent();
            edited_ac = eac;
            mainForm = main;
            renderManufacturersCombo();
            confirmButton.Enabled = false;
        }

        private void renderManufacturersCombo()
        {
            foreach (string man in mainForm.analyzeForm.manufacturers) {
                manufacturerCombo.Items.Add(man);
            }
        }
        
        private void renderTypesCombo()
        {
            string man = manufacturerCombo.Text;
            filteredTypes.Clear();
            typeCombo.Items.Clear();
            typeCombo.Text = "";
            aircraftCombo.Items.Clear();
            aircraftCombo.Text = "";
            aircraftDetails.Text = "";
            confirmButton.Enabled = false;
            foreach (Aircraft ac in mainForm.analyzeForm.aircrafts){
                if (ac.ui_manufacturer == man && !filteredTypes.Contains(ac.ui_type))
                {
                    filteredTypes.Add(ac.ui_type);
                    typeCombo.Items.Add(ac.ui_type);
                }
            }
            if (typeCombo.Items.Count == 1) {
                typeCombo.SelectedIndex = 0;
            }
        }

        private void renderAicraftsCombo()
        {
            if (filteredAircrafts.Count > 0) filteredAircrafts.Clear();
            string type = typeCombo.Text;
            aircraftCombo.Items.Clear();
            aircraftCombo.Text = "";
            foreach (Aircraft ac in mainForm.analyzeForm.aircrafts){
                if (ac.ui_type == type && !filteredAircrafts.Contains(ac) && ac.ui_manufacturer == manufacturerCombo.Text){
                    filteredAircrafts.Add(ac);
                    aircraftCombo.Items.Add(ac.ui_variation + " / texture " + ac.texture.ToUpper());
                }
            }
        }

        private void displayAircraftDetails()
        {
            string text = "title: " + selectedAircraft.title + "\n";
            text += "texture: " + selectedAircraft.texture + "\n";
            text += "ui_variation: " + selectedAircraft.ui_variation + "\n";
            text += "ui_type: " + selectedAircraft.ui_type + "\n";
            text += "atc_airline: " + selectedAircraft.atc_airline + "\n";
            aircraftDetails.Text = text;
            confirmButton.Enabled = true;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            edited_ac.new_title = selectedAircraft.title;
            mainForm.resultForm.AircraftChanged();
            this.Close();
            this.Dispose();
        }

        private void simCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            renderTypesCombo();
        }

        private void aircraftCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedAircraft = filteredAircrafts[aircraftCombo.SelectedIndex];
            displayAircraftDetails();
        }

        private void typeCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            renderAicraftsCombo();
        }

        
    }
}
