namespace MultivariateStatistics
{
    partial class FormLoadDataPrompt
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
            this.lblPrompt = new System.Windows.Forms.Label();
            this.btnLoadData = new System.Windows.Forms.Button();
            this.btnDontLoadData = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.lblPrompt.AutoSize = true;
            this.lblPrompt.Location = new System.Drawing.Point(62, 34);
            this.lblPrompt.MaximumSize = new System.Drawing.Size(155, 250);
            this.lblPrompt.Name = "label1";
            this.lblPrompt.Size = new System.Drawing.Size(153, 26);
            this.lblPrompt.TabIndex = 0;
            this.lblPrompt.Text = "You have not loaded any data.  Would you like to load data?";
            // 
            // btnLoadData
            // 
            this.btnLoadData.Location = new System.Drawing.Point(46, 92);
            this.btnLoadData.Name = "btnLoadData";
            this.btnLoadData.Size = new System.Drawing.Size(75, 23);
            this.btnLoadData.TabIndex = 1;
            this.btnLoadData.Text = "Yes";
            this.btnLoadData.UseVisualStyleBackColor = true;
            this.btnLoadData.Click += new System.EventHandler(this.btnLoadData_Click);
            // 
            // btnDontLoadData
            // 
            this.btnDontLoadData.Location = new System.Drawing.Point(158, 92);
            this.btnDontLoadData.Name = "btnDontLoadData";
            this.btnDontLoadData.Size = new System.Drawing.Size(75, 23);
            this.btnDontLoadData.TabIndex = 2;
            this.btnDontLoadData.Text = "No";
            this.btnDontLoadData.UseVisualStyleBackColor = true;
            this.btnDontLoadData.Click += new System.EventHandler(this.btnDontLoadData_Click);
            // 
            // LoadDataPromptForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 155);
            this.Controls.Add(this.btnDontLoadData);
            this.Controls.Add(this.btnLoadData);
            this.Controls.Add(this.lblPrompt);
            this.Name = "LoadDataPromptForm";
            this.Text = "LoadDataPromptForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPrompt;
        private System.Windows.Forms.Button btnLoadData;
        private System.Windows.Forms.Button btnDontLoadData;
    }
}