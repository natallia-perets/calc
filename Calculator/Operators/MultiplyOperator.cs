namespace Calculator.Operators
{
    public class MultiplyOperator : IOperator
    {
        public double Apply(double a, double b)
        {
            return a * b;
        }
        char IOperator.Key
        {
            get { return '*'; }
            set { throw new System.NotImplementedException(); }
        }
        public override string ToString()
        {
            return "*";
        }
    }
}
