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
        int accuracy;
        double arg1;
        double arg2;
        char operation;
        double result;
        int configparam;

        public Expression(int accuracy, double arg1, double arg2, char operation)
        {
            this.accuracy = accuracy;
            this.arg1 = arg1;
            this.arg2 = arg2;
            this.operation = operation;
            configparam = Convert.ToInt32(Config.GetConfigNumber());
            if (operation.Equals('+'))
            {
                Add();
            }
            if (operation.Equals('-'))
            {
                Subtract();
            }
            if (operation.Equals('/'))
            {
                Divide();
            }
            if (operation.Equals('*'))
            {
                Multiply();
            }
            //Console.WriteLine(configparam);
            //Console.ReadLine();
        }
        private void Add()
        {
            double re = arg1 + arg2;
            System.Console.WriteLine(accuracy);
            result = Math.Round(re, accuracy);
            //result = Math.Round((arg1 + arg2), accuracy);
        }
        private void Subtract()
        {
            result = Math.Round(arg1 - arg2, accuracy);
        }
        private void Divide()
        {
            result = Math.Round(arg1 / arg2, accuracy);
        }
        private void Multiply()
        {
            result = Math.Round(arg1 * arg2, accuracy);
        }
        public override string ToString()
        {
            return arg1.ToString() + operation.ToString() + arg2.ToString() + "=" + result.ToString();
        } 
    }
}
