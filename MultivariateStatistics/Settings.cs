using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace MultivariateStatistics
{
    public class Settings
    {
        protected string defaultLoad;
        protected string favoriteFile;
        protected string defaultDirectory;
        protected bool defaultCorrelationCoefficientClearData;
        protected bool defaultDescriptiveStatisticsClearData;
        protected bool defaultLinearRegressionClearData;

        public string DefaultLoad
        {
            get { return defaultLoad; }
            set { defaultLoad = value; }
        }
        public string FavoriteFile
        {
            get { return favoriteFile; }
            set { favoriteFile = value; }
        }
        public string DefaultDirectory
        {
            get { return defaultDirectory; }
            set { defaultDirectory = value; }
        }
        public bool DefaultCorrelationCoefficientClearData
        {
            get { return defaultCorrelationCoefficientClearData; }
            set { defaultCorrelationCoefficientClearData = value; }
        }
        public bool DefaultDescriptiveStatisticsClearData
        {
            get { return defaultDescriptiveStatisticsClearData; }
            set { defaultDescriptiveStatisticsClearData = value; }
        }
        public bool DefaultLinearRegressionClearData
        {
            get { return defaultLinearRegressionClearData; }
            set { defaultLinearRegressionClearData = value; }
        }

        
       
        public void SetFactoryDefaults()
        {
            DefaultLoad = "none";
            FavoriteFile = "";
            DefaultDirectory = "";
            DefaultCorrelationCoefficientClearData = false;
            DefaultDescriptiveStatisticsClearData = false;
            DefaultLinearRegressionClearData = false;
        }

    }
}
