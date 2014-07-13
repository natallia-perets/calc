using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calc.Configurations;

namespace Calc.Expressions
{
    class Expression
    {
        double arg1;
        double arg2;
        char operation;
        double result;
        int configparam;

        public Expression(double arg1, double arg2, char operation)
        {
            this.arg1 = arg1;
            this.arg2 = arg2;
            this.operation = operation;
            configparam = Convert.ToInt32(Config.GetConfigNumber());
            Console.WriteLine(configparam);
            Console.ReadLine();
        }
        private void Add()
        {
            
        }

    }
}
