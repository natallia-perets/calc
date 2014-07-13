using System;
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
        }
    }
}
