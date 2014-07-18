namespace Calculator.Operators
{
    public class PlusOperator : IOperator
    {
        public double Apply(double a, double b)
        {
            return a + b;
        }

        public override string ToString()
        {
            return "+";
        }
    }
}