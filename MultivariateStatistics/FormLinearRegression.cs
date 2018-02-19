using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultivariateStatistics
{
    public partial class FormLinearRegression : Form
    {
        private static FormLinearRegression instance = null;

        public static FormLinearRegression Instance
        {
            get { return instance; }
            set { instance = value; }
        }

        double[][] dataValues;
        string[] variables;

        public FormLinearRegression(double[][] data, string[] vs)
        {
            InitializeComponent();
            variables = vs;
            dataValues = data;
            comboBoxXVariable.Items.AddRange(variables);
            comboBoxYVariable.Items.AddRange(variables); 
            SubFormSettingsMenuItem settingsItem = new SubFormSettingsMenuItem();
            menuStrip1.Items.Add(settingsItem.SettingsToolStripMenuItem);
            checkBoxClearData.Checked = FrmMain.Instance.formSettings.DefaultDescriptiveStatisticsClearData;
            settingsItem.ClearDataDefaultToolStripMenuItem.Checked = FrmMain.Instance.formSettings.DefaultDescriptiveStatisticsClearData;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double[] coefficients = Mathtool.RegressionCoefficient(dataValues, 
                                                                comboBoxXVariable.SelectedIndex,
                                                                comboBoxYVariable.SelectedIndex);
            FrmMain.Instance.GetRegressionCoefficients(coefficients, 
                                                       comboBoxXVariable.SelectedIndex, 
                                                       comboBoxYVariable.SelectedIndex, 
                                                       checkBoxClearData.Checked);
            FrmMain.Instance.Refresh();
            FormLinearRegression.instance.Close();
        }


        private void clearDataDefaultToolStripMenuItem_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            ToolStripMenuItem selectedItem = (ToolStripMenuItem)e.ClickedItem;
            foreach (ToolStripMenuItem i in selectedItem.Owner.Items)
                i.Checked = false;
            selectedItem.Checked = true;
            FrmMain.Instance.formSettings.DefaultLinearRegressionClearData = Convert.ToBoolean(selectedItem.Text.Substring(1));
        }

        private void FormLinearRegression_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormLinearRegression.instance = null;
        }
    }
}
