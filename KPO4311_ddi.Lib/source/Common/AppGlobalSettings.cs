using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using KPO4311.Utility;

namespace KPO4311.ddi.Lib
{
    public static class AppGlobalSettings
    {
        private static string _logPath;
        static public string Log
        {
            get
            {
                return _logPath;
            }
            set
            {
                _logPath = value;
            }
        }

        private static string _dataFileName;
        static public string Data
        {
            get
            {
                return _dataFileName;
            }
            set
            {
                _dataFileName = value;
            }
        }

        static AppGlobalSettings()
        {
            Log = AppConfigUtility.AppSettings("logPath");
            Data = AppConfigUtility.AppSettings("dataFilePath");
        }

        public static void Initialize()
        {
            AppGlobalSettings.Log = AppConfigUtility.AppSettings("logPath");
            AppGlobalSettings.Data = AppConfigUtility.AppSettings("dataFileName");
        }
    }
}
