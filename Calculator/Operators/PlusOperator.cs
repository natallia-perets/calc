﻿namespace Calculator.Operators
{
    public class PlusOperator : IOperator
    {
        public double Apply(double a, double b)
        {
            return a + b;
        }

        char IOperator.Key
        {
            get { return '+'; }
            set { throw new System.NotImplementedException(); }
        }
        public override string ToString()
        {
            return "+";
        }
    }
}