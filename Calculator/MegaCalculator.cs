﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator;

namespace Calc
{
    public class MegaCalculator
    {
        private int accuracy;
        private readonly IStorage _storage;
        private List<Expression> _historylist;

        private List<IOperator> _operators; 
        public MegaCalculator(int accuracy, IStorage storage)
        {
            this.accuracy = accuracy;
            _storage = storage;
            _historylist = new List<Expression>();
        }

        public void AddExpression(double arg1, double arg2, char operation)
        {
            var operatorFactory = new OperatorFactory();

            var @operator = _operators.FirstOrDefault(x => x.Key == char);

            if (@operator == null)
            {
                throw new InvalidOperationException("Operator not found");
            }

            IOperator @operator = operatorFactory.CreateOperator(operation);
            Expression expr = new Expression(arg1, arg2, @operator);
            expr.Calculate();
            AddToHistoryList(expr);
            System.Console.WriteLine(expr.ToString());
        }

        public void AddToHistoryList(Expression e){
            _historylist.Add(e);
        }

        public List<Expression> GetHistory()
        {
            return _historylist;
        }

        public void Save()
        {
            _storage.Save(_historylist);
        }

        public void ShowHistoryOnConsole()
        {
            foreach (var e in _historylist)
            {
                System.Console.WriteLine(e.ToString());
            }
        }
    }
}
