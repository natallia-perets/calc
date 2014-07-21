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
        private double arg1;
        private double arg2;
        private char operation;
        private  double result;
        private int precision;

        public Expression(double arg1, double arg2, char operation)
        {
            this.arg1 = arg1;
            this.arg2 = arg2;
            this.operation = operation;
            precision = Convert.ToInt32(Config.GetConfigNumber());
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
        }
        private void Add()
        {
            result = Math.Round(arg1 + arg2, precision);
        }
        private void Subtract()
        {
            result = Math.Round(arg1 - arg2, precision);
        }
        private void Divide()
        {
            result = Math.Round(arg1 / arg2, precision);
        }
        private void Multiply()
        {
            result = Math.Round(arg1 * arg2, precision);
        }
        public override string ToString()
        {
            return arg1.ToString() + " " + operation.ToString() + " " + arg2.ToString() + " " + "=" + " " + result.ToString();
        } 
    }
}
