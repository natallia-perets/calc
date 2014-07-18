using System.Collections.Generic;

namespace Calculator
{
    public interface IStorage
    {
        void Save(IEnumerable<Expression> expressions);
    }
}