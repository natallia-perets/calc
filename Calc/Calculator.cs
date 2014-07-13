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
        private int accuracy;
        private string historylist;
        public Calculator(int accuracy)
        {
            this.accuracy = accuracy;
        }
        public void AddToHistoryList(Expression e){
            historylist += e.ToString();
            historylist += '\n';
        }
        public void ShowHistory()
        {
            if (String.IsNullOrEmpty(historylist))
            {
                System.Console.WriteLine("\nHistory is empty. Nothing to show");
                return;
            }
            System.Console.WriteLine("\n" + historylist);
        }
        public void WriteToFile(string filepath)
        {
            if (String.IsNullOrEmpty(historylist))
            {
                System.Console.WriteLine("\nHistory is empty. Nothing is saved to a file");
                return;
            }
            char[] delimiters = {'\n'};
            string[] lines = historylist.Split(delimiters);
            try
            {
                System.IO.StreamWriter writer = new System.IO.StreamWriter(filepath, true);
                foreach (string line in lines)
                {
                    writer.WriteLine(line);
                }
                writer.Close();
                System.Console.WriteLine("\nResult saved to a file");
            }
            catch (Exception e)
            {
                System.Console.WriteLine(e.ToString());
            }
        }
    }
}
