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
    public partial class EditRegistryForm : Form
    {
        MainForm mainForm;

        public EditRegistryForm(MainForm main)
        {
            InitializeComponent();
            mainForm = main;
        }
    }
}
