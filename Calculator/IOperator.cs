namespace Calculator
{
    public interface IOperator
    {
        char Key { get; set; }
        double Apply(double a, double b);
    }
}