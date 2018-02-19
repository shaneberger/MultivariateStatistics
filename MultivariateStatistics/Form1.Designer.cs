namespace MultivariateStatistics
{
    partial class FrmMain
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
            this.tcStat = new System.Windows.Forms.TabControl();
            this.tp1 = new System.Windows.Forms.TabPage();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.tp2 = new System.Windows.Forms.TabPage();
            this.txtStat = new System.Windows.Forms.TextBox();
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.dataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadRecentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.analysisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.descriptiveStatisticsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.correlationCoefficientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.linearRegressionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.defaultLoadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostRecentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.favoriteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setAsFavoriteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setFavoriteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setDefaultDirectoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tcStat.SuspendLayout();
            this.tp1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.tp2.SuspendLayout();
            this.mnuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcStat
            // 
            this.tcStat.Controls.Add(this.tp1);
            this.tcStat.Controls.Add(this.tp2);
            this.tcStat.Location = new System.Drawing.Point(2, 27);
            this.tcStat.Name = "tcStat";
            this.tcStat.SelectedIndex = 0;
            this.tcStat.Size = new System.Drawing.Size(1345, 686);
            this.tcStat.TabIndex = 0;
            // 
            // tp1
            // 
            this.tp1.Controls.Add(this.dgvData);
            this.tp1.Location = new System.Drawing.Point(4, 22);
            this.tp1.Name = "tp1";
            this.tp1.Padding = new System.Windows.Forms.Padding(3);
            this.tp1.Size = new System.Drawing.Size(1337, 660);
            this.tp1.TabIndex = 0;
            this.tp1.Text = "Data";
            this.tp1.UseVisualStyleBackColor = true;
            // 
            // dgvData
            // 
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Location = new System.Drawing.Point(3, 6);
            this.dgvData.Name = "dgvData";
            this.dgvData.Size = new System.Drawing.Size(1331, 642);
            this.dgvData.TabIndex = 0;
            // 
            // tp2
            // 
            this.tp2.Controls.Add(this.txtStat);
            this.tp2.Location = new System.Drawing.Point(4, 22);
            this.tp2.Name = "tp2";
            this.tp2.Padding = new System.Windows.Forms.Padding(3);
            this.tp2.Size = new System.Drawing.Size(1337, 660);
            this.tp2.TabIndex = 1;
            this.tp2.Text = "Result";
            this.tp2.UseVisualStyleBackColor = true;
            // 
            // txtStat
            // 
            this.txtStat.Location = new System.Drawing.Point(4, 7);
            this.txtStat.Multiline = true;
            this.txtStat.Name = "txtStat";
            this.txtStat.Size = new System.Drawing.Size(1330, 660);
            this.txtStat.TabIndex = 0;
            // 
            // mnuMain
            // 
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dataToolStripMenuItem,
            this.analysisToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Size = new System.Drawing.Size(1346, 24);
            this.mnuMain.TabIndex = 1;
            this.mnuMain.Text = "menuStrip1";
            // 
            // dataToolStripMenuItem
            // 
            this.dataToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem,
            this.loadRecentToolStripMenuItem});
            this.dataToolStripMenuItem.Name = "dataToolStripMenuItem";
            this.dataToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.dataToolStripMenuItem.Text = "&Data";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.loadToolStripMenuItem.Text = "Load &New";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // loadRecentToolStripMenuItem
            // 
            this.loadRecentToolStripMenuItem.Name = "loadRecentToolStripMenuItem";
            this.loadRecentToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.loadRecentToolStripMenuItem.Text = "Load &Recent";
            this.loadRecentToolStripMenuItem.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.loadRecentToolStripMenuItem_DropDownItemClicked);
            // 
            // analysisToolStripMenuItem
            // 
            this.analysisToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.descriptiveStatisticsToolStripMenuItem,
            this.correlationCoefficientToolStripMenuItem,
            this.linearRegressionToolStripMenuItem});
            this.analysisToolStripMenuItem.Name = "analysisToolStripMenuItem";
            this.analysisToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.analysisToolStripMenuItem.Text = "&Analysis";
            // 
            // descriptiveStatisticsToolStripMenuItem
            // 
            this.descriptiveStatisticsToolStripMenuItem.Name = "descriptiveStatisticsToolStripMenuItem";
            this.descriptiveStatisticsToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.descriptiveStatisticsToolStripMenuItem.Text = "&Descriptive Statistics";
            this.descriptiveStatisticsToolStripMenuItem.Click += new System.EventHandler(this.descriptiveStatisticsToolStripMenuItem_Click);
            // 
            // correlationCoefficientToolStripMenuItem
            // 
            this.correlationCoefficientToolStripMenuItem.Name = "correlationCoefficientToolStripMenuItem";
            this.correlationCoefficientToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.correlationCoefficientToolStripMenuItem.Text = "&Correlation Coefficient";
            this.correlationCoefficientToolStripMenuItem.Click += new System.EventHandler(this.correlationCoefficientToolStripMenuItem_Click);
            // 
            // linearRegressionToolStripMenuItem
            // 
            this.linearRegressionToolStripMenuItem.Name = "linearRegressionToolStripMenuItem";
            this.linearRegressionToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.linearRegressionToolStripMenuItem.Text = "&Linear Regression";
            this.linearRegressionToolStripMenuItem.Click += new System.EventHandler(this.linearRegressionToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.defaultLoadToolStripMenuItem,
            this.setDefaultDirectoryToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "&Settings";
            // 
            // defaultLoadToolStripMenuItem
            // 
            this.defaultLoadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.noneToolStripMenuItem,
            this.mostRecentToolStripMenuItem,
            this.favoriteToolStripMenuItem});
            this.defaultLoadToolStripMenuItem.Name = "defaultLoadToolStripMenuItem";
            this.defaultLoadToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.defaultLoadToolStripMenuItem.Text = "Set Default &Load";
            this.defaultLoadToolStripMenuItem.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.defaultLoadToolStripMenuItem_DropDownItemClicked);
            // 
            // noneToolStripMenuItem
            // 
            this.noneToolStripMenuItem.Name = "noneToolStripMenuItem";
            this.noneToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.noneToolStripMenuItem.Text = "None";
            // 
            // mostRecentToolStripMenuItem
            // 
            this.mostRecentToolStripMenuItem.Name = "mostRecentToolStripMenuItem";
            this.mostRecentToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.mostRecentToolStripMenuItem.Text = "Most Recent";
            // 
            // favoriteToolStripMenuItem
            // 
            this.favoriteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setAsFavoriteToolStripMenuItem,
            this.setFavoriteToolStripMenuItem});
            this.favoriteToolStripMenuItem.Name = "favoriteToolStripMenuItem";
            this.favoriteToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.favoriteToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.favoriteToolStripMenuItem.Text = "Favorite";
            // 
            // setAsFavoriteToolStripMenuItem
            // 
            this.setAsFavoriteToolStripMenuItem.Name = "setAsFavoriteToolStripMenuItem";
            this.setAsFavoriteToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.setAsFavoriteToolStripMenuItem.Text = "Current as Favorite";
            this.setAsFavoriteToolStripMenuItem.Click += new System.EventHandler(this.setAsFavoriteToolStripMenuItem_Click);
            // 
            // setFavoriteToolStripMenuItem
            // 
            this.setFavoriteToolStripMenuItem.Name = "setFavoriteToolStripMenuItem";
            this.setFavoriteToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.setFavoriteToolStripMenuItem.Text = "Set Favorite";
            this.setFavoriteToolStripMenuItem.Click += new System.EventHandler(this.setFavoriteToolStripMenuItem_Click);
            // 
            // setDefaultDirectoryToolStripMenuItem
            // 
            this.setDefaultDirectoryToolStripMenuItem.Name = "setDefaultDirectoryToolStripMenuItem";
            this.setDefaultDirectoryToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.setDefaultDirectoryToolStripMenuItem.Text = "Set Default &Directory";
            this.setDefaultDirectoryToolStripMenuItem.Click += new System.EventHandler(this.setDefaultDirectoryToolStripMenuItem_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1346, 714);
            this.Controls.Add(this.tcStat);
            this.Controls.Add(this.mnuMain);
            this.MainMenuStrip = this.mnuMain;
            this.Name = "FrmMain";
            this.Text = "Multivariate Statistics Toolkit";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.tcStat.ResumeLayout(false);
            this.tp1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.tp2.ResumeLayout(false);
            this.tp2.PerformLayout();
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tcStat;
        private System.Windows.Forms.TabPage tp1;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.TabPage tp2;
        private System.Windows.Forms.TextBox txtStat;
        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem dataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem analysisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem descriptiveStatisticsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem correlationCoefficientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem linearRegressionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadRecentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem defaultLoadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem noneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostRecentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem favoriteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setAsFavoriteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setFavoriteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setDefaultDirectoryToolStripMenuItem;
    }
}

