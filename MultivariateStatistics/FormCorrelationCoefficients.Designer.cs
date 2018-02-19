namespace MultivariateStatistics
{
    partial class FormCorrelationCoefficients
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
            this.checkBoxClearData = new System.Windows.Forms.CheckBox();
            this.btnCorrelationCoefficient = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxYVariable = new System.Windows.Forms.ComboBox();
            this.comboBoxXVariable = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.SuspendLayout();
            // 
            // checkBoxClearData
            // 
            this.checkBoxClearData.AutoSize = true;
            this.checkBoxClearData.Location = new System.Drawing.Point(12, 159);
            this.checkBoxClearData.Name = "checkBoxClearData";
            this.checkBoxClearData.Size = new System.Drawing.Size(120, 17);
            this.checkBoxClearData.TabIndex = 12;
            this.checkBoxClearData.Text = "Clear Previous Data";
            this.checkBoxClearData.UseVisualStyleBackColor = true;
            // 
            // btnCorrelationCoefficient
            // 
            this.btnCorrelationCoefficient.Location = new System.Drawing.Point(12, 182);
            this.btnCorrelationCoefficient.Name = "btnCorrelationCoefficient";
            this.btnCorrelationCoefficient.Size = new System.Drawing.Size(140, 37);
            this.btnCorrelationCoefficient.TabIndex = 11;
            this.btnCorrelationCoefficient.Text = "Find Correlation Coefficient";
            this.btnCorrelationCoefficient.UseVisualStyleBackColor = true;
            this.btnCorrelationCoefficient.Click += new System.EventHandler(this.btnCorrelationCoefficient_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Y Variable:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "X Variable:";
            // 
            // comboBoxYVariable
            // 
            this.comboBoxYVariable.FormattingEnabled = true;
            this.comboBoxYVariable.Location = new System.Drawing.Point(12, 115);
            this.comboBoxYVariable.Name = "comboBoxYVariable";
            this.comboBoxYVariable.Size = new System.Drawing.Size(140, 21);
            this.comboBoxYVariable.TabIndex = 8;
            // 
            // comboBoxXVariable
            // 
            this.comboBoxXVariable.FormattingEnabled = true;
            this.comboBoxXVariable.Location = new System.Drawing.Point(12, 48);
            this.comboBoxXVariable.Name = "comboBoxXVariable";
            this.comboBoxXVariable.Size = new System.Drawing.Size(140, 21);
            this.comboBoxXVariable.TabIndex = 7;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(164, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FormCorrelationCoefficients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(164, 231);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.checkBoxClearData);
            this.Controls.Add(this.btnCorrelationCoefficient);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxYVariable);
            this.Controls.Add(this.comboBoxXVariable);
            this.Name = "FormCorrelationCoefficients";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormCorrelationCoefficients_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxClearData;
        private System.Windows.Forms.Button btnCorrelationCoefficient;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxYVariable;
        private System.Windows.Forms.ComboBox comboBoxXVariable;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}