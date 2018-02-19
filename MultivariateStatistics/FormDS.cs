using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace MultivariateStatistics
{
    public partial class FormDS : Form
    {
        public DescriptiveStat result;
        List<double> dataList = new List<double>();
        double[][] myVal;
        string[] colNames;
        bool clearData;
        private static FormDS instance = null;

        public static FormDS Instance
        {
            get { return instance;}
            set { instance = value;}
        }

        public FormDS(string[] vl, double[][] myValues) //Form constructor
        {
            InitializeComponent();
            colNames = vl;
            listDS.SelectionMode = SelectionMode.None;
            listDS.DataSource = vl;
            listDS.SelectionMode = SelectionMode.MultiSimple;
            myVal = myValues;
            SubFormSettingsMenuItem settingsItem = new SubFormSettingsMenuItem();
            menuStrip1.Items.Add(settingsItem.SettingsToolStripMenuItem);
            checkBoxClearData.Checked = FrmMain.Instance.formSettings.DefaultDescriptiveStatisticsClearData;
            settingsItem.ClearDataDefaultToolStripMenuItem.Checked = FrmMain.Instance.formSettings.DefaultDescriptiveStatisticsClearData;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach(int n in listDS.SelectedIndices)
            {
                dataList = new List<double>();
                foreach(double[] dataRow in myVal)
                {
                    dataList.Add(dataRow[n]);
                }
                result = Mathtool.GetDescriptiveStat(dataList);
                FrmMain.Instance.descriptiveStatResults(result, colNames[n], clearData); //colNames populated by GetVList

            }

            FrmMain.Instance.Refresh();
            FormDS.instance.Close();
            Debug.WriteLine(FormDS.instance);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void checkBoxClearData_CheckedChanged(object sender, EventArgs e)
        {
            clearData = checkBoxClearData.Checked;
        }

        private void FormDS_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormDS.instance = null;
        }

    }
}
