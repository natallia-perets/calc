using System;
<<<<<<< HEAD
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
=======
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Calc.Configurations
{
    public static class Config
    {
        public static string GetConfigNumber()
        {
            return ConfigurationManager.AppSettings["accuracy"].ToString();
>>>>>>> 9fb3bcd940d27c4460e6405425b0c7a329d81b13
        }
    }
}
