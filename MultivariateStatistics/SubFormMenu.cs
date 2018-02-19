using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace MultivariateStatistics
{
    class SubFormSettingsMenuItem
    {
        protected ToolStripMenuItem settingsToolStripMenuItem;
        protected ToolStripMenuItem clearDataDefaultToolStripMenuItem;

        public ToolStripMenuItem SettingsToolStripMenuItem
        {
            get { return settingsToolStripMenuItem; }
            set { settingsToolStripMenuItem = value; }
        }
        public ToolStripMenuItem ClearDataDefaultToolStripMenuItem
        {
            get { return clearDataDefaultToolStripMenuItem; }
            set { clearDataDefaultToolStripMenuItem = value; }
        }

        public SubFormSettingsMenuItem()
        {
            SettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ClearDataDefaultToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();

            SettingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            ClearDataDefaultToolStripMenuItem});
            SettingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            SettingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            SettingsToolStripMenuItem.Text = "&Settings";

            ClearDataDefaultToolStripMenuItem.Name = "clearDataDefaultToolStripMenuItem";
            ClearDataDefaultToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            ClearDataDefaultToolStripMenuItem.Text = "&Clear Data By Default";
            ClearDataDefaultToolStripMenuItem.Click += new System.EventHandler(ClearDataDefaultToolStripMenuItem_DropDownItemClicked);
            //(form.ClearDataDefaultToolStripMenuItem_DropDownItemClicked)

        }
        private void ClearDataDefaultToolStripMenuItem_DropDownItemClicked(object sender, EventArgs e)
        {
            ToolStripMenuItem selectedItem = (ToolStripMenuItem)sender;
            
            selectedItem.Checked = !selectedItem.Checked;
            if(FormDS.Instance!=null)
                FrmMain.Instance.formSettings.DefaultDescriptiveStatisticsClearData = selectedItem.Checked;
            if(FormCorrelationCoefficients.Instance!=null)
                FrmMain.Instance.formSettings.DefaultCorrelationCoefficientClearData = selectedItem.Checked;
            if(FormLinearRegression.Instance!=null)
                FrmMain.Instance.formSettings.DefaultLinearRegressionClearData = selectedItem.Checked;
        }
    }
}
