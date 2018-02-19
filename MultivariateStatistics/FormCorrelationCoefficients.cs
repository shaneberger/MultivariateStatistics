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
    public partial class FormCorrelationCoefficients : Form
    {
        private static FormCorrelationCoefficients instance = null;

        public static FormCorrelationCoefficients Instance
        {
            get { return instance; }
            set { instance = value; }
        }

        public FormCorrelationCoefficients(string[] variableList)
        {
            InitializeComponent();
            comboBoxXVariable.DataSource = variableList;
            comboBoxYVariable.DataSource = variableList;
            SubFormSettingsMenuItem settingsItem = new SubFormSettingsMenuItem();
            menuStrip1.Items.Add(settingsItem.SettingsToolStripMenuItem);
            checkBoxClearData.Checked = FrmMain.Instance.formSettings.DefaultDescriptiveStatisticsClearData;
            settingsItem.ClearDataDefaultToolStripMenuItem.Checked = FrmMain.Instance.formSettings.DefaultDescriptiveStatisticsClearData;
        }

        private void btnCorrelationCoefficient_Click(object sender, EventArgs e)
        {
            FrmMain.Instance.GetCoefficient(comboBoxXVariable.SelectedIndex, 
                                            comboBoxYVariable.SelectedIndex, 
                                            checkBoxClearData.Checked);
            FrmMain.Instance.Refresh();
            FormCorrelationCoefficients.instance.Close();
        }

        private void clearDataDefaultToolStripMenuItem_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            ToolStripMenuItem selectedItem = (ToolStripMenuItem)e.ClickedItem;
            foreach (ToolStripMenuItem i in selectedItem.Owner.Items)
                i.Checked = false;
            selectedItem.Checked = true;
            FrmMain.Instance.formSettings.DefaultCorrelationCoefficientClearData = Convert.ToBoolean(selectedItem.Text.Substring(1));
        }

        private void FormCorrelationCoefficients_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormCorrelationCoefficients.instance = null;
        }
    }
}
