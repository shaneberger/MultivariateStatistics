namespace MultivariateStatistics
{
    partial class FormDS
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
            this.button1 = new System.Windows.Forms.Button();
            this.listDS = new System.Windows.Forms.ListBox();
            this.checkBoxClearData = new System.Windows.Forms.CheckBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(179, 217);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Enter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listDS
            // 
            this.listDS.FormattingEnabled = true;
            this.listDS.Location = new System.Drawing.Point(12, 25);
            this.listDS.Name = "listDS";
            this.listDS.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listDS.Size = new System.Drawing.Size(260, 173);
            this.listDS.TabIndex = 0;
            // 
            // checkBoxClearData
            // 
            this.checkBoxClearData.AutoSize = true;
            this.checkBoxClearData.Location = new System.Drawing.Point(24, 221);
            this.checkBoxClearData.Name = "checkBoxClearData";
            this.checkBoxClearData.Size = new System.Drawing.Size(120, 17);
            this.checkBoxClearData.TabIndex = 13;
            this.checkBoxClearData.Text = "Clear Previous Data";
            this.checkBoxClearData.UseVisualStyleBackColor = true;
            this.checkBoxClearData.CheckedChanged += new System.EventHandler(this.checkBoxClearData_CheckedChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FormDS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.checkBoxClearData);
            this.Controls.Add(this.listDS);
            this.Controls.Add(this.button1);
            this.Name = "FormDS";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormDS_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listDS;
        private System.Windows.Forms.CheckBox checkBoxClearData;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}