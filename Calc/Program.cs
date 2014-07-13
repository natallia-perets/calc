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
            Calculator calc = new Calculator(accuracy);
            string pattern = @"^(\s+)?(\-)?\d+(,\d+)?(\s+)?(\+|-|\*|/)(\s+)?(\-)?\d+(,\d+)?(\s+)?$";
            Console.WriteLine("Hello. This is CALCULATOR. It takes 2 operands and performs +-/* operations. You can adjust operation accuracy with the help of app.config file. For exit use Esc key");
            while (true)
            {
                Console.Write(">");
                string input = Console.ReadLine();
                if (Regex.IsMatch(input, pattern))
                {
                    //parsing
                    char[] delimiters = {' '};
                    input = Regex.Replace(input, @"\s+", " ");
                    string[] words = input.Split(delimiters);
               
                try
                {
                     arg1 = Convert.ToDouble(words[0]);
                     operation = Convert.ToChar(words[1]);
                     arg2 = Convert.ToDouble(words[2]);
                     System.Console.WriteLine(arg1);
                     System.Console.WriteLine(arg2);
                     System.Console.WriteLine(operation);
                     Expression expr = new Expression(accuracy, arg1, arg2, operation);
                     System.Console.WriteLine(expr.ToString());

                }
                catch (FormatException e )
                 {
                     Console.WriteLine(e.ToString());     
                 }
                 catch (OverflowException e)
                 {
                     Console.WriteLine(e.ToString());
                 }
                 //Expression expr = new Expression(arg1, arg2, operation);
                }

                else Console.WriteLine("Wrong input");
               
                
                Console.ReadLine();
               
            } 
        }
    }
}
