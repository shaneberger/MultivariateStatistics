namespace MultivariateStatistics
{
    partial class FormLinearRegression
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
            this.comboBoxXVariable = new System.Windows.Forms.ComboBox();
            this.comboBoxYVariable = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBoxClearData = new System.Windows.Forms.CheckBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.SuspendLayout();
            // 
            // comboBoxXVariable
            // 
            this.comboBoxXVariable.FormattingEnabled = true;
            this.comboBoxXVariable.Location = new System.Drawing.Point(12, 54);
            this.comboBoxXVariable.Name = "comboBoxXVariable";
            this.comboBoxXVariable.Size = new System.Drawing.Size(140, 21);
            this.comboBoxXVariable.TabIndex = 1;
            // 
            // comboBoxYVariable
            // 
            this.comboBoxYVariable.FormattingEnabled = true;
            this.comboBoxYVariable.Location = new System.Drawing.Point(12, 112);
            this.comboBoxYVariable.Name = "comboBoxYVariable";
            this.comboBoxYVariable.Size = new System.Drawing.Size(140, 21);
            this.comboBoxYVariable.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "X Variable:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Y Variable:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 179);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 37);
            this.button1.TabIndex = 4;
            this.button1.Text = "Find Regression Coefficient";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBoxClearData
            // 
            this.checkBoxClearData.AutoSize = true;
            this.checkBoxClearData.Location = new System.Drawing.Point(12, 156);
            this.checkBoxClearData.Name = "checkBoxClearData";
            this.checkBoxClearData.Size = new System.Drawing.Size(120, 17);
            this.checkBoxClearData.TabIndex = 3;
            this.checkBoxClearData.Text = "Clear Previous Data";
            this.checkBoxClearData.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(164, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FormLinearRegression
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(164, 228);
            this.Controls.Add(this.checkBoxClearData);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxYVariable);
            this.Controls.Add(this.comboBoxXVariable);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormLinearRegression";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormLinearRegression_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxXVariable;
        private System.Windows.Forms.ComboBox comboBoxYVariable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBoxClearData;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}