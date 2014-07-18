namespace Calculator
{

    public class Expression
    {
        private readonly double _arg1;
        private readonly double _arg2;
        private readonly IOperator _o;
        private  double _result;

        public Expression(double arg1, double arg2, IOperator o)
        {
            _arg1 = arg1;
            _arg2 = arg2;
            _o = o;
        }

        public void Calculate()
        {
            _result = _o.Apply(_arg1, _arg2);
        }

        public override string ToString()
        {
            return string.Format("{0} {2} {1} = {3}", _arg1, _arg2, _o, _result);
        } 
    }
}
