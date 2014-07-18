namespace Calculator.Operators
{
    class DivideOperator : IOperator
    {
        public double Apply(double a, double b)
        {
            return a / b;
        }

        public override string ToString()
        {
            return "/";
        }
    }
}
