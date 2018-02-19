using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Reflection;

namespace MultivariateStatistics
{
    public partial class FrmMain : Form
    {
        
        public FrmMain()
        {
            InitializeComponent();

            if (File.Exists(settingsTextPath))
            {

                settingsData = File.ReadAllLines(settingsTextPath);
                Dictionary<string, string> splitData = new Dictionary<string, string>();
                foreach (string setting in settingsData)
                //loops through each line in the settings text file, 
                //putting the setting name and setting value in their respective 
                //array slots
                {
                    string[] splitSetting = setting.Split('=');
                    splitData.Add(splitSetting[0], splitSetting[1]);
                }
                foreach(PropertyInfo property in formSettings.GetType().GetProperties().ToList())
                //loop through all the properties of the formSettings to set their values from the splitData dictionary
                {

                    string result;
                    if (splitData.TryGetValue(property.Name, out result))
                    {
                        if (result.ToLower() == "true" || result.ToLower() == "false")
                            property.SetValue(formSettings, Convert.ToBoolean(result), null);
                        else
                            property.SetValue(formSettings, result, null);
                    }
                }
                
            }
            else//in the event that the settings file is not found, the settings are set to their default values
                formSettings.SetFactoryDefaults();

            if (File.Exists(recentFilesTextPath)) 
            {
                //updates the Load Recent menu item with names of recent files. 
                //the full path name is stored in a list so that when a recent file is selected the appropriate 
                //data file is opened and loaded. 
                recentFiles = File.ReadAllLines(recentFilesTextPath);
                foreach (string filepath in recentFiles)
                {
                    if (File.Exists(filepath))
                    {
                        recentFilesList.Add(filepath);
                    }
                }
                foreach(string filepath in recentFilesList)
                {
                    ToolStripItem newDropDownItem = new ToolStripMenuItem();
                    newDropDownItem.Text = Path.GetFileName(filepath);
                    loadRecentToolStripMenuItem.DropDownItems.Add(newDropDownItem);
                }
                if(recentFilesList.Count == 0)
                    loadRecentToolStripMenuItem.Visible = false;
                
            }
            else {loadRecentToolStripMenuItem.Visible = false;}//if there are no recent files, remove the option from the menu 

            foreach (ToolStripMenuItem item in defaultLoadToolStripMenuItem.DropDownItems)
            //Checks the appropriate default load option
            {
                if (item.Text == formSettings.DefaultLoad)
                    item.Checked = true;
            }
            if(formSettings.DefaultLoad!="None")//if the user has requested that a default file be loaded, 
                                                //load that file
            {
                switch(formSettings.DefaultLoad)
                {
                    case "Most Recent":
                        try { prepareData(recentFilesList[0]); }
                        catch { Debug.WriteLine("No recent file found."); }     
                        break;
                    case "Favorite":
                        updateRecentFiles(formSettings.FavoriteFile);
                        prepareData(formSettings.FavoriteFile);
                        break;
                }
            }
        }


        public Settings formSettings = new Settings();
        string recentFilesTextPath = "..\\RecentFiles.txt";
        string settingsTextPath = "..\\Settings.txt";
        string[] recentFiles;
        string[] settingsData;
        List<string> recentFilesList = new List<string>();
        string[] lines, colnames;
        List<string[]> strValues;
        double[][] dblValues;
        bool dataLoaded = false;
        string unloadedDataPrompt = "You have not loaded any data. Would you like to load data?";
        
        private static FrmMain instance = null;
        public static FrmMain Instance
        {
            get { return instance; }
            set { instance = value; }
        }

        public void GetCoefficient(int i, int j, bool clearData)
        //^finds the coefficient between the data sets of two variables referenced by their indexes i and j
        //populates the textbox on the results tab with the results
        {
            if (clearData)//clears the text if the user indicated they wished to do so in the previous form
                txtStat.Text = "";

            double result = Mathtool.GetCoefficient(dblValues, i, j);
            txtStat.Text += "Correlation Coefficient between " + colnames[i] + " and " + colnames[j] + " is: " + result.ToString("#.##");
            tcStat.SelectedTab = tp2;
        }

        public void loadToolStripMenuItem_Click(object sender, EventArgs e)
        //^opens a file explorer to choose a file to load data from
        //file path is passed to prepareData() function
        {
            OpenFileDialog mydialog = new OpenFileDialog();
            mydialog.InitialDirectory = formSettings.DefaultDirectory;
            mydialog.Filter = "Text Files (*.txt)|*.txt|All Files(*.*)|*.*";

            if (mydialog.ShowDialog() == DialogResult.OK)
            {
                string filepath = mydialog.FileName;
                prepareData(filepath);
            }
            else
            {
                mydialog.Dispose(); //safely exit the dialog and event if the user exits
                return;
            }
        }

        private void correlationCoefficientToolStripMenuItem_Click(object sender, EventArgs e)
        //^loads the correlation coefficient form
        {
            if (dataLoaded)
            {
                FormCorrelationCoefficients.Instance = 
                    new FormCorrelationCoefficients(colnames);
                FormCorrelationCoefficients.Instance.Show();
            }
            else
            {
                FormLoadDataPrompt.Instance = new FormLoadDataPrompt(unloadedDataPrompt);
                FormLoadDataPrompt.Instance.Show();
            }
        }

        private void linearRegressionToolStripMenuItem_Click(object sender, EventArgs e)
        //^loads the linearRegression coefficient form
        {
            if (dataLoaded)
            {
                FormLinearRegression.Instance = 
                    new FormLinearRegression(dblValues, colnames);
                FormLinearRegression.Instance.Show();
            }
            else
            {
                FormLoadDataPrompt.Instance = new FormLoadDataPrompt(unloadedDataPrompt);
                FormLoadDataPrompt.Instance.Show();
            }
        }

        public void GetRegressionCoefficients(double[] coefficients, int x, int y, bool clearData)
        //populates the textbox in the results tab with the correlation between two data sets
        {
            if (clearData) //clears the textbox if the user indicated they wished to do so.
                txtStat.Text = "";

            txtStat.Text += "Regression Coefficients for " +
                            colnames[x] + " and " + colnames[y] +
                            " are: a = " + coefficients[0].ToString("#.##") +
                            ", b = " + coefficients[1].ToString("#.##") + Environment.NewLine; 
                             //Environment.NewLine separates outputs if the user does not wish to clear the textbox
            tcStat.SelectedTab = tp2;
        }

        private void descriptiveStatisticsToolStripMenuItem_Click(object sender, EventArgs e)
        //^loads the descriptive statistics form
        {
            FormDS.Instance = new FormDS(colnames, dblValues);
            FormDS.Instance.Show();
        }

        private void loadRecentToolStripMenuItem_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            
            ToolStripMenuItem selectedItem = e.ClickedItem as ToolStripMenuItem;
            //^object sender in event parameters refer to the object tied to the event. 
            //Casting the sender to the correct type allows you to access it's properties and methods.
            int index = selectedItem.Owner.Items.IndexOf(selectedItem);
            updateRecentFiles(recentFilesList[index]);
            prepareData(recentFilesList[index]);
        }

        public void descriptiveStatResults(DescriptiveStat newResult, string index, bool clearData)
        //^populates the textbox on results tab with results from the FormDS
        {
            if (clearData)
                tcStat.Text = "";

            txtStat.Text += "For " + index +
                ", Max: " + newResult.max.ToString("#.##") +
                ", Min: " + newResult.min.ToString("#.##") +
                ", Sum: " + newResult.sum.ToString("#.##") +
                ", Average: " + newResult.avg.ToString("#.##") +
                ", Variance: " + newResult.var.ToString("#.##") +
                ", Standard Deviation: " + newResult.stddev.ToString("#.##") +
                ", 1/4 Percentile: " + newResult.percentile1Quarter.ToString("#.##")+
                ", 3/4 Percentile: " + newResult.percentile3Quarter.ToString("#.##")+
                "." + Environment.NewLine; 
             
            tcStat.SelectedTab = tp2;
        }

        public void prepareData(string filepath)
        //^loads data from a file into the DataGridViewItem
        {
            
            try//broad try/catch statement for if anything goes wrong
            {
                if (!(File.Exists(filepath)))
                    return;
                
                //use Linq to remove blank lines
                //use list as intermediate step to remove blank lines
                lines = File.ReadAllLines(filepath);
                strValues = new List<string[]>();
                List<string> temp = new List<string>();
                dgvData.Rows.Clear();
                dgvData.Columns.Clear();
                foreach (string x in lines)
                {
                    if (!string.IsNullOrEmpty(x))
                        temp.Add(x);
                }

                lines = temp.ToArray();

                int h = lines.Length;

                colnames = lines[0].Split('\t');

                foreach (string x in colnames)
                    dgvData.Columns.Add(x, x);

                for (int i = 1; i < h; i++)
                {
                    if (!(lines[i].Split('\t').Contains("")))//prevents adding datasets with null values
                        strValues.Add(lines[i].Split('\t'));
                }

                int w = colnames.Length;
                dblValues = new double[h - 1][];
                dgvData.ColumnCount = w;
                for (int i = 0; i < strValues.Count; i++)
                {
                    DataGridViewRow r = new DataGridViewRow();
                    r.CreateCells(dgvData);
                    dblValues[i] = new double[w];
                    for (int j = 0; j < w; j++)
                    {
                        r.Cells[j].Value = strValues[i][j];
                        dblValues[i][j] = Convert.ToDouble(strValues[i][j]);
                    }
                    dgvData.Rows.Add(r);
                    double[] test;
                }
                tcStat.SelectedTab = tp1;
                tp1.Text = Path.GetFileNameWithoutExtension(filepath) + " Data";
                updateRecentFiles(filepath);
                dataLoaded = true;//set to true at the end so if there is an error, it will still be false
            }
            catch { MessageBox.Show("There was an error processing the file."); }
        }

        public void updateRecentFiles(string filepath)
        //^updates the Load Recent file menu with the most recent filepath at the top
        {
            if (recentFilesList.Contains(filepath))
            {
                loadRecentToolStripMenuItem.DropDownItems.RemoveAt(recentFilesList.IndexOf(filepath));
                recentFilesList.Remove(filepath);
            }
            recentFilesList.Insert(0, filepath);
            ToolStripItem newDropDownItem = new ToolStripMenuItem();
            newDropDownItem.Text = Path.GetFileName(filepath);
            loadRecentToolStripMenuItem.DropDownItems.Insert(0, newDropDownItem);
            loadRecentToolStripMenuItem.Visible = true;
        }

        private void defaultLoadToolStripMenuItem_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        //^updates the check mark for the default load options and the setting
        {
            ToolStripMenuItem itemSelected = (ToolStripMenuItem)e.ClickedItem;
            formSettings.DefaultLoad = itemSelected.Text;
            foreach (ToolStripMenuItem i in itemSelected.Owner.Items)
                i.Checked = false;
            itemSelected.Checked = true;
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        //^Saves any changes to the save data to their respective files
        {
            File.WriteAllLines(recentFilesTextPath, recentFilesList.ToArray());
            File.WriteAllLines(settingsTextPath, SettingsToStringArray());
        }

        public string[] SettingsToStringArray()
        //^Creates an array with each setting in it's own index. 
        //Used to update the settings file upon exiting the program
        {
            PropertyInfo[] properties = typeof(Settings).GetProperties();
            List<string> temp = new List<string>();
            foreach (PropertyInfo property in properties)
            {
                temp.Add(property.Name + "=" + property.GetValue(formSettings));
            }
            string[] arry = temp.ToArray();
            return arry;
        }

        private void setAsFavoriteToolStripMenuItem_Click(object sender, EventArgs e)
        //sets the current (aka most recent) file as the favorite file
        {
            formSettings.FavoriteFile = recentFilesList[0];
        }

        private void setFavoriteToolStripMenuItem_Click(object sender, EventArgs e)
        //^opens file dialog to select a favorite file
        {
            OpenFileDialog mydialog = new OpenFileDialog();
            mydialog.InitialDirectory = Path.GetFullPath(Path.Combine(Application.StartupPath, formSettings.DefaultDirectory));
            mydialog.Filter = "Text Files (*.txt)|*.txt|All Files(*.*)|*.*";
            
            if (mydialog.ShowDialog() == DialogResult.OK)
            {
                string filepath = mydialog.FileName;
                formSettings.FavoriteFile = filepath;
            }
            else
            {
                mydialog.Dispose(); //safely exit the dialog and event if the user exits
                return;
            }
        }

        private void setDefaultDirectoryToolStripMenuItem_Click(object sender, EventArgs e)
        //^allows user to select a default directory when they go to open a file
        {
            FolderBrowserDialog mydialog = new FolderBrowserDialog();
            //mydialog.InitialDirectory = Path.GetFullPath(Path.Combine(Application.StartupPath, "c:\\"));
            if (mydialog.ShowDialog() == DialogResult.OK)
            {
                string filepath = mydialog.SelectedPath;
                formSettings.DefaultDirectory = filepath;
            }
            else
            {
                mydialog.Dispose(); //safely exit the dialog and event
                return;
            }

        }

    }
}
