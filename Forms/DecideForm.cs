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
    public partial class DecideForm : Form
    {
        private string message;
        private List<Aircraft> options;
        private AssignForm parent;

        public DecideForm(AssignForm par, string msg, List<Aircraft> opt)
        {
            InitializeComponent();
            message = msg;
            options = opt;
            parent = par;
        }

        private void DecideForm_Load(object sender, EventArgs e)
        {
            label1.Text = message;
            int count = 0;
            foreach (Aircraft ac in options) {
                Button b = new Button();
                b.Name = "b" + count.ToString();
                int min = Math.Min(ac.title.Length, 25);
                b.Text = ac.title.Substring(0, min) + " ( " + ac.match_count.ToString() + " pts match)";
                b.Size = new Size(300, 20);
                b.Location = new Point(10, 50 + 22 * count);
                this.Controls.Add(b);
                b.Click += new EventHandler(b_Click);
                count++;
            }
            this.Size = new Size(300, 140 + (count - 2) * 22);
        }

        private void b_Click(object sender, EventArgs e)
        {
            string s = ((Control)sender).Name;
            string val = s.Substring(1, s.Length - 1);
            parent.stopSearch = checkBox1.Checked;
            parent.decideResult = System.Convert.ToInt32(val);
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked) {
                MessageBox.Show("The process will stop after this aircraft. The results so far will be available for export.");
            }
        }

    }
}
