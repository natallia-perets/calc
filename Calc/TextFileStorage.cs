using System;
using System.Collections.Generic;
using System.Linq;
using Calculator;

namespace Calc
{
    public class TextFileStorage : IStorage
    {
        public void Save(IEnumerable<Expression> expressions)
        {
            if (expressions.Count() != 0)
            {
                try
                {
                    string savestring = Config.GetSaveString();
                    System.IO.StreamWriter writer = new System.IO.StreamWriter(@savestring, true);
                    foreach (Expression e in expressions)
                    {
                        writer.WriteLine(e);
                    }
                    writer.Close();
                    System.Console.WriteLine("\nResult saved to a file");
                }
                catch (Exception ex)
                {
                    System.Console.WriteLine(ex.ToString());
                }
            }
            else System.Console.WriteLine("\nHistory is empty. Nothing to write.");
            
        }
    }
}