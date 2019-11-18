namespace Lab5B
{
    interface IArithmeticExpression
    {
        void Calculate(CalculatorContext memory);
    }
    class PlusExpression : IArithmeticExpression
    {
        public PlusExpression()
        {}

        public void Calculate(CalculatorContext memory)
        {
            //memory.PopNumber();
            if (memory.Count() < 2) throw new SyntaxErrorException();
            var exp1 = memory.PopNumber();
            var exp2 = memory.PopNumber();
            memory.PushNumber(new Number(exp1.Value + exp2.Value));
        }
    }
    class MinusExpression : IArithmeticExpression
    {
        public MinusExpression()
        { }

        public void Calculate(CalculatorContext memory)
        {
            //memory.PopNumber();
            if (memory.Count() < 2) throw new SyntaxErrorException();
            var exp1 = memory.PopNumber();
            var exp2 = memory.PopNumber();
            memory.PushNumber(new Number(exp2.Value - exp1.Value));
        }
    }
    class MultiplicationExpression : IArithmeticExpression
    {
        public MultiplicationExpression()
        { }

        public void Calculate(CalculatorContext memory)
        {
            //memory.PopNumber();
            if (memory.Count() < 2) throw new SyntaxErrorException();
            var exp1 = memory.PopNumber();
            var exp2 = memory.PopNumber();
            memory.PushNumber(new Number(exp2.Value * exp1.Value));
        }
    }
    class DivideExpression : IArithmeticExpression
    {
        public DivideExpression()
        { }

        public void Calculate(CalculatorContext memory)
        {
            //memory.PopNumber();
            if (memory.Count() < 2) throw new SyntaxErrorException();
            var exp1 = memory.PopNumber();
            var exp2 = memory.PopNumber();
            if(exp1.Value==0) throw new DivideByZeroException();
            memory.PushNumber(new Number(exp2.Value / exp1.Value));
        }
    }
}
