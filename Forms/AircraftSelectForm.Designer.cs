namespace FSAircraftRepositoryFactory.Forms
{
    partial class AircraftSelectForm
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
            this.manufacturerCombo = new System.Windows.Forms.ComboBox();
            this.confirmButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.aircraftCombo = new System.Windows.Forms.ComboBox();
            this.acLabel = new System.Windows.Forms.Label();
            this.detailsLabel = new System.Windows.Forms.Label();
            this.aircraftDetails = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.typeCombo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // manufacturerCombo
            // 
            this.manufacturerCombo.FormattingEnabled = true;
            this.manufacturerCombo.Location = new System.Drawing.Point(12, 30);
            this.manufacturerCombo.Name = "manufacturerCombo";
            this.manufacturerCombo.Size = new System.Drawing.Size(342, 21);
            this.manufacturerCombo.TabIndex = 0;
            this.manufacturerCombo.SelectedIndexChanged += new System.EventHandler(this.simCombo_SelectedIndexChanged);
            // 
            // confirmButton
            // 
            this.confirmButton.Location = new System.Drawing.Point(258, 284);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(96, 23);
            this.confirmButton.TabIndex = 1;
            this.confirmButton.Text = "Confirm change";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(12, 284);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 2;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Select manufacturer";
            // 
            // aircraftCombo
            // 
            this.aircraftCombo.FormattingEnabled = true;
            this.aircraftCombo.Location = new System.Drawing.Point(12, 123);
            this.aircraftCombo.Name = "aircraftCombo";
            this.aircraftCombo.Size = new System.Drawing.Size(342, 21);
            this.aircraftCombo.TabIndex = 4;
            this.aircraftCombo.SelectedIndexChanged += new System.EventHandler(this.aircraftCombo_SelectedIndexChanged);
            // 
            // acLabel
            // 
            this.acLabel.AutoSize = true;
            this.acLabel.Location = new System.Drawing.Point(12, 106);
            this.acLabel.Name = "acLabel";
            this.acLabel.Size = new System.Drawing.Size(163, 13);
            this.acLabel.TabIndex = 5;
            this.acLabel.Text = "Finally select the aircraft variation";
            // 
            // detailsLabel
            // 
            this.detailsLabel.AutoSize = true;
            this.detailsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.detailsLabel.Location = new System.Drawing.Point(12, 163);
            this.detailsLabel.Name = "detailsLabel";
            this.detailsLabel.Size = new System.Drawing.Size(101, 13);
            this.detailsLabel.TabIndex = 6;
            this.detailsLabel.Text = "Selected aircraft";
            // 
            // aircraftDetails
            // 
            this.aircraftDetails.AutoSize = true;
            this.aircraftDetails.Location = new System.Drawing.Point(15, 183);
            this.aircraftDetails.Name = "aircraftDetails";
            this.aircraftDetails.Size = new System.Drawing.Size(35, 13);
            this.aircraftDetails.TabIndex = 7;
            this.aircraftDetails.Text = "label2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Then select type of aircraft";
            // 
            // typeCombo
            // 
            this.typeCombo.FormattingEnabled = true;
            this.typeCombo.Location = new System.Drawing.Point(12, 75);
            this.typeCombo.Name = "typeCombo";
            this.typeCombo.Size = new System.Drawing.Size(342, 21);
            this.typeCombo.TabIndex = 8;
            this.typeCombo.SelectedIndexChanged += new System.EventHandler(this.typeCombo_SelectedIndexChanged);
            // 
            // AircraftSelectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 319);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.typeCombo);
            this.Controls.Add(this.aircraftDetails);
            this.Controls.Add(this.detailsLabel);
            this.Controls.Add(this.acLabel);
            this.Controls.Add(this.aircraftCombo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.manufacturerCombo);
            this.Name = "AircraftSelectForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Aircraft Selection";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox manufacturerCombo;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox aircraftCombo;
        private System.Windows.Forms.Label acLabel;
        private System.Windows.Forms.Label detailsLabel;
        private System.Windows.Forms.Label aircraftDetails;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox typeCombo;
    }
}