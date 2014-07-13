using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calc.Configurations;
using Calc.Expressions;

namespace Calc
{
    class Calculator
    {
        int accuracy;
        Expression[] historylist;
        public Calculator(int accuracy)
        {
            this.accuracy = accuracy;
        }
       /* public Expression[] GetHistoryList()
        {

        }*/
    }
}
