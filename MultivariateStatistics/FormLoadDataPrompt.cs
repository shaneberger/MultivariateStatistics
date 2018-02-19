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
    public partial class FormLoadDataPrompt : Form
    {
        private static FormLoadDataPrompt instance = null;

        public static FormLoadDataPrompt Instance
        {
            get { return instance; }
            set { instance = value; }
        }
        public FormLoadDataPrompt(string prompt)
        {
            InitializeComponent();
            lblPrompt.Text = prompt;
        }

        private void btnLoadData_Click(object sender, EventArgs e)
        {
            FormLoadDataPrompt.instance.Close();
            FrmMain.Instance.loadToolStripMenuItem_Click(sender, e);
        }

        private void btnDontLoadData_Click(object sender, EventArgs e)
        {
            FormLoadDataPrompt.instance.Close();
        }
    }
}
