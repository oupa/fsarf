namespace FSAircraftRepositoryFactory.Forms
{
    partial class AnalyzeForm
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
            this.analyzeText = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // analyzeText
            // 
            this.analyzeText.AutoSize = true;
            this.analyzeText.Location = new System.Drawing.Point(14, 17);
            this.analyzeText.Name = "analyzeText";
            this.analyzeText.Size = new System.Drawing.Size(35, 13);
            this.analyzeText.TabIndex = 0;
            this.analyzeText.Text = "label1";
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(182, 12);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(90, 23);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "Start Analysis";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // AnalyzeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 47);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.analyzeText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AnalyzeForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Step 1 - Analyzer";
            this.Load += new System.EventHandler(this.AnalyzeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label analyzeText;
        private System.Windows.Forms.Button startButton;
    }
}