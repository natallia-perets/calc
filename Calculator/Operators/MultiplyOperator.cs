namespace Calculator.Operators
{
    class MultiplyOperator : IOperator
    {
        public double Apply(double a, double b)
        {
            return a * b;
        }

        public override string ToString()
        {
            return "*";
        }
    }
}
