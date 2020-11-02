using System;
using System.Configuration;

namespace SilentApp.BL
{
    class Globals
    {
        public static string AppName = ConfigurationManager.AppSettings["AppName"].ToString();
        public static string FileName = ConfigurationManager.AppSettings["FileName"].ToString();
        public static Int32 Timer = Convert.ToInt32(ConfigurationManager.AppSettings["Timer"].ToString());
    }
}
