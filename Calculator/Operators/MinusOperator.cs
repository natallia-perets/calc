namespace Calculator.Operators
{
    class MinusOperator : IOperator
    {
        public double Apply(double a, double b)
        {
            return a - b;
        }

        public override string ToString()
        {
            return "-";
        }
    }
}
