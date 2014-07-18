using System;
using System.Configuration;

namespace Calc
{
    public static class Config
    {
        public static int GetAccuracy()
        {
            return Convert.ToInt32(ConfigurationManager.AppSettings["accuracy"]);
        }
        public static string GetSaveString()
        {
            return ConfigurationManager.AppSettings["saveString"];
        }
    }
}
