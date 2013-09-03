namespace FSAircraftRepositoryFactory.Forms
{
    partial class ResultForm
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.acGrid = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.RegistryType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RegistryAirline = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CurrentTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NewTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.acGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.acGrid);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.button1);
            this.splitContainer1.Size = new System.Drawing.Size(602, 590);
            this.splitContainer1.SplitterDistance = 545;
            this.splitContainer1.TabIndex = 0;
            // 
            // acGrid
            // 
            this.acGrid.AllowUserToAddRows = false;
            this.acGrid.AllowUserToDeleteRows = false;
            this.acGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.acGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RegistryType,
            this.RegistryAirline,
            this.CurrentTitle,
            this.NewTitle});
            this.acGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.acGrid.Location = new System.Drawing.Point(0, 0);
            this.acGrid.Name = "acGrid";
            this.acGrid.ReadOnly = true;
            this.acGrid.Size = new System.Drawing.Size(602, 545);
            this.acGrid.TabIndex = 0;
            this.acGrid.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.acGrid_CellContentDoubleClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(10, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Export";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RegistryType
            // 
            this.RegistryType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.RegistryType.FillWeight = 50F;
            this.RegistryType.HeaderText = "Type";
            this.RegistryType.Name = "RegistryType";
            this.RegistryType.ReadOnly = true;
            this.RegistryType.Width = 50;
            // 
            // RegistryAirline
            // 
            this.RegistryAirline.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.RegistryAirline.FillWeight = 50F;
            this.RegistryAirline.HeaderText = "Airline";
            this.RegistryAirline.Name = "RegistryAirline";
            this.RegistryAirline.ReadOnly = true;
            this.RegistryAirline.Width = 50;
            // 
            // CurrentTitle
            // 
            this.CurrentTitle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CurrentTitle.HeaderText = "Current Title";
            this.CurrentTitle.Name = "CurrentTitle";
            this.CurrentTitle.ReadOnly = true;
            // 
            // NewTitle
            // 
            this.NewTitle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NewTitle.HeaderText = "New Title (Double click to edit)";
            this.NewTitle.Name = "NewTitle";
            this.NewTitle.ReadOnly = true;
            // 
            // ResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 590);
            this.Controls.Add(this.splitContainer1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ResultForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Results";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.acGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView acGrid;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn RegistryType;
        private System.Windows.Forms.DataGridViewTextBoxColumn RegistryAirline;
        private System.Windows.Forms.DataGridViewTextBoxColumn CurrentTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn NewTitle;
    }
}