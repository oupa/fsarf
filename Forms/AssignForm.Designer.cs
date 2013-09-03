namespace FSAircraftRepositoryFactory.Forms
{
    partial class AssignForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.startButton = new System.Windows.Forms.Button();
            this.assignLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.filterIcao = new System.Windows.Forms.TextBox();
            this.checkFamilyFilter = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.filterAirline = new System.Windows.Forms.TextBox();
            this.checkAirlineFilter = new System.Windows.Forms.CheckBox();
            this.checkNew = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(12, 394);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(109, 26);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Begin the process";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // assignLabel
            // 
            this.assignLabel.AutoSize = true;
            this.assignLabel.Location = new System.Drawing.Point(12, 9);
            this.assignLabel.MaximumSize = new System.Drawing.Size(450, 0);
            this.assignLabel.Name = "assignLabel";
            this.assignLabel.Size = new System.Drawing.Size(35, 13);
            this.assignLabel.TabIndex = 1;
            this.assignLabel.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(9, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Assigner mode";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.radioButton3);
            this.panel1.Controls.Add(this.radioButton2);
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 72);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(458, 173);
            this.panel1.TabIndex = 4;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.radioButton3.Location = new System.Drawing.Point(12, 114);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(43, 17);
            this.radioButton3.TabIndex = 6;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "ccc";
            this.radioButton3.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.radioButton2.Location = new System.Drawing.Point(12, 73);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(43, 17);
            this.radioButton2.TabIndex = 5;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "bbb";
            this.radioButton2.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.radioButton1.Location = new System.Drawing.Point(12, 29);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(43, 17);
            this.radioButton1.TabIndex = 4;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "aaa";
            this.radioButton1.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 251);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "ddd";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.checkNew);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.filterIcao);
            this.panel2.Controls.Add(this.checkFamilyFilter);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.filterAirline);
            this.panel2.Controls.Add(this.checkAirlineFilter);
            this.panel2.Location = new System.Drawing.Point(12, 292);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(458, 92);
            this.panel2.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(202, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(210, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Input part of aircraft ICAO to filter (e.g. B73)";
            // 
            // filterIcao
            // 
            this.filterIcao.Location = new System.Drawing.Point(145, 35);
            this.filterIcao.MaxLength = 3;
            this.filterIcao.Name = "filterIcao";
            this.filterIcao.Size = new System.Drawing.Size(53, 20);
            this.filterIcao.TabIndex = 4;
            // 
            // checkFamilyFilter
            // 
            this.checkFamilyFilter.AutoSize = true;
            this.checkFamilyFilter.Location = new System.Drawing.Point(14, 37);
            this.checkFamilyFilter.Name = "checkFamilyFilter";
            this.checkFamilyFilter.Size = new System.Drawing.Size(125, 17);
            this.checkFamilyFilter.TabIndex = 3;
            this.checkFamilyFilter.Text = "Filter by aircraft ICAO";
            this.checkFamilyFilter.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(203, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(235, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Input part or entire airline code to filter (e.g. CSA)";
            // 
            // filterAirline
            // 
            this.filterAirline.Location = new System.Drawing.Point(145, 9);
            this.filterAirline.MaxLength = 3;
            this.filterAirline.Name = "filterAirline";
            this.filterAirline.Size = new System.Drawing.Size(53, 20);
            this.filterAirline.TabIndex = 1;
            // 
            // checkAirlineFilter
            // 
            this.checkAirlineFilter.AutoSize = true;
            this.checkAirlineFilter.Location = new System.Drawing.Point(14, 11);
            this.checkAirlineFilter.Name = "checkAirlineFilter";
            this.checkAirlineFilter.Size = new System.Drawing.Size(92, 17);
            this.checkAirlineFilter.TabIndex = 0;
            this.checkAirlineFilter.Text = "Filter by airline";
            this.checkAirlineFilter.UseVisualStyleBackColor = true;
            // 
            // checkNew
            // 
            this.checkNew.AutoSize = true;
            this.checkNew.Location = new System.Drawing.Point(14, 63);
            this.checkNew.Name = "checkNew";
            this.checkNew.Size = new System.Drawing.Size(203, 17);
            this.checkNew.TabIndex = 6;
            this.checkNew.Text = "Only search unassigned (new) aircraft";
            this.checkNew.UseVisualStyleBackColor = true;
            // 
            // AssignForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 433);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.assignLabel);
            this.Controls.Add(this.startButton);
            this.Name = "AssignForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Step 3 - Aircraft Assigner";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label assignLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox filterIcao;
        private System.Windows.Forms.CheckBox checkFamilyFilter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox filterAirline;
        private System.Windows.Forms.CheckBox checkAirlineFilter;
        private System.Windows.Forms.CheckBox checkNew;
    }
}