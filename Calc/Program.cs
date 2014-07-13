using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calc.Expressions;
using Calc.Configurations;
using System.Text.RegularExpressions;

namespace Calc
{
    class Program
    {
        static void Main(string[] args)
        {
            double arg1, arg2;
            char operation;
            int accuracy = Convert.ToInt32(Calc.Configurations.Config.GetConfigNumber());
            ConsoleKeyInfo cki;
            Calculator calc = new Calculator(accuracy);
            string pattern = @"^(\s+)?(\-)?\d+(,\d+)?(\s+)?(\+|-|\*|/)(\s+)?(\-)?\d+(,\d+)?(\s+)?$";
            Console.WriteLine("Hello. This is CALCULATOR. It takes 2 operands and performs +-/* operations. You can adjust operation accuracy with the help of app.config file. For exit use Esc key");
            while (true)
            {
                Console.WriteLine("Press 'w' to write results to a file");
                Console.WriteLine("Press 's' to show recorded results");
                Console.WriteLine("Press 'esc' to exit");
                Console.WriteLine("Input format:'operand'_'operation'_ 'operand'. Example: -1 + 1");
                Console.Write(">");
                cki = Console.ReadKey();
                if (cki.KeyChar=='w')
                {
                   calc.WriteToFile(@"C:\Users\Natallia\Documents\Visual Studio 2013\Projects\Calc\Calc\results.txt");
                   continue;
                }
                if (cki.KeyChar == 's')
                {
                    calc.ShowHistory();
                    continue;
                }
                if (cki.Key == ConsoleKey.Escape) 
                {
                    Environment.Exit(1);
                }
                string input = Console.ReadLine();
                if (Regex.IsMatch(input, pattern))
                {
                    char[] delimiters = {' '};
                    input = Regex.Replace(input, @"\s+", " ");
                    string[] words = input.Split(delimiters);
               
                try
                {
                     arg1 = Convert.ToDouble(words[0]);
                     operation = Convert.ToChar(words[1]);
                     arg2 = Convert.ToDouble(words[2]);
                     Expression expr = new Expression(arg1, arg2, operation);
                     Console.WriteLine(expr.ToString());
                     calc.AddToHistoryList(expr);
                }
                catch (FormatException e )
                {
                     Console.WriteLine(e.ToString());     
                }
                catch (OverflowException e)
                {
                     Console.WriteLine(e.ToString());
                }
                }
                else Console.WriteLine("Wrong input");
            } 
        }
    }
}
