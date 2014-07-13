using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
    class Expression
    {
        double arg1;
        double arg2;
        char operation;
        double result;

        public Expression(double arg1, double arg2, char operation)
        {
            this.arg1 = arg1;
            this.arg2 = arg2;

        }
    }
}
