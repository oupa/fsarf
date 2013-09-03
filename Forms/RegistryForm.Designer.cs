namespace FSAircraftRepositoryFactory.Forms
{
    partial class RegistryForm
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
            this.pathTxt = new System.Windows.Forms.TextBox();
            this.pathLabel = new System.Windows.Forms.Label();
            this.analyzeButton = new System.Windows.Forms.Button();
            this.button32bit = new System.Windows.Forms.Button();
            this.button64bit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.radioLOCAL_MACHINE = new System.Windows.Forms.RadioButton();
            this.radioCURRENT_USER = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // pathTxt
            // 
            this.pathTxt.Location = new System.Drawing.Point(12, 83);
            this.pathTxt.Name = "pathTxt";
            this.pathTxt.Size = new System.Drawing.Size(548, 20);
            this.pathTxt.TabIndex = 0;
            // 
            // pathLabel
            // 
            this.pathLabel.AutoSize = true;
            this.pathLabel.Location = new System.Drawing.Point(13, 11);
            this.pathLabel.Name = "pathLabel";
            this.pathLabel.Size = new System.Drawing.Size(35, 13);
            this.pathLabel.TabIndex = 1;
            this.pathLabel.Text = "label1";
            // 
            // analyzeButton
            // 
            this.analyzeButton.Location = new System.Drawing.Point(433, 109);
            this.analyzeButton.Name = "analyzeButton";
            this.analyzeButton.Size = new System.Drawing.Size(127, 23);
            this.analyzeButton.TabIndex = 2;
            this.analyzeButton.Text = "Start analysis";
            this.analyzeButton.UseVisualStyleBackColor = true;
            this.analyzeButton.Click += new System.EventHandler(this.analyzeButton_Click);
            // 
            // button32bit
            // 
            this.button32bit.Location = new System.Drawing.Point(12, 109);
            this.button32bit.Name = "button32bit";
            this.button32bit.Size = new System.Drawing.Size(68, 23);
            this.button32bit.TabIndex = 3;
            this.button32bit.Text = "FSX 32bit";
            this.button32bit.UseVisualStyleBackColor = true;
            this.button32bit.Click += new System.EventHandler(this.button32bit_Click);
            // 
            // button64bit
            // 
            this.button64bit.Location = new System.Drawing.Point(84, 109);
            this.button64bit.Name = "button64bit";
            this.button64bit.Size = new System.Drawing.Size(70, 23);
            this.button64bit.TabIndex = 4;
            this.button64bit.Text = "FSX 64bit";
            this.button64bit.UseVisualStyleBackColor = true;
            this.button64bit.Click += new System.EventHandler(this.button64bit_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(232, 109);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(71, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "FS9 64bit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(160, 109);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(69, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "FS9 32bit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // radioLOCAL_MACHINE
            // 
            this.radioLOCAL_MACHINE.AutoSize = true;
            this.radioLOCAL_MACHINE.Location = new System.Drawing.Point(12, 59);
            this.radioLOCAL_MACHINE.Name = "radioLOCAL_MACHINE";
            this.radioLOCAL_MACHINE.Size = new System.Drawing.Size(224, 17);
            this.radioLOCAL_MACHINE.TabIndex = 7;
            this.radioLOCAL_MACHINE.TabStop = true;
            this.radioLOCAL_MACHINE.Text = "LOCAL_MACHINE registry (most common)";
            this.radioLOCAL_MACHINE.UseVisualStyleBackColor = true;
            this.radioLOCAL_MACHINE.CheckedChanged += new System.EventHandler(this.radioLOCAL_MACHINE_CheckedChanged);
            // 
            // radioCURRENT_USER
            // 
            this.radioCURRENT_USER.AutoSize = true;
            this.radioCURRENT_USER.Location = new System.Drawing.Point(247, 59);
            this.radioCURRENT_USER.Name = "radioCURRENT_USER";
            this.radioCURRENT_USER.Size = new System.Drawing.Size(213, 17);
            this.radioCURRENT_USER.TabIndex = 8;
            this.radioCURRENT_USER.TabStop = true;
            this.radioCURRENT_USER.Text = "CURRENT_USER registry (VirtualStore)";
            this.radioCURRENT_USER.UseVisualStyleBackColor = true;
            this.radioCURRENT_USER.CheckedChanged += new System.EventHandler(this.radioCURRENT_USER_CheckedChanged);
            // 
            // RegistryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 143);
            this.Controls.Add(this.radioCURRENT_USER);
            this.Controls.Add(this.radioLOCAL_MACHINE);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button64bit);
            this.Controls.Add(this.button32bit);
            this.Controls.Add(this.analyzeButton);
            this.Controls.Add(this.pathLabel);
            this.Controls.Add(this.pathTxt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RegistryForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Step 2 - Registry Reader";
            this.Load += new System.EventHandler(this.RegistryForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox pathTxt;
        private System.Windows.Forms.Label pathLabel;
        private System.Windows.Forms.Button analyzeButton;
        private System.Windows.Forms.Button button32bit;
        private System.Windows.Forms.Button button64bit;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RadioButton radioLOCAL_MACHINE;
        private System.Windows.Forms.RadioButton radioCURRENT_USER;
    }
}