using System;
using Calculator.Operators;

namespace Calculator
{
    public class OperatorFactory
    {
        public IOperator CreateOperator(char o)
        {
            IOperator op;
            switch (o)
            {
                case '+': 
                    op = new PlusOperator();
                    break;
                case '-': 
                    op = new MinusOperator();
                    break;
                case '*': 
                    op = new MultiplyOperator();
                    break;
                case '/':
                    op = new DivideOperator();
                    break;
                default: 
                    throw new InvalidOperationException("bvffh dfh ");
                    break;
            }
            return op;


        }
    }
}