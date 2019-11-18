using System;
using System.Collections.Generic;

namespace Lab5B
{
    class PostfixArithmeticParser
    {
        public List<IArithmeticExpression> CreateTokens(string postfix_expression)
        {
            string[] str_arr = postfix_expression.Split(' ');
            List<IArithmeticExpression> list_exp = new List<IArithmeticExpression>();
            int l = str_arr.Length;
            int _Number;
            bool IsNumber;
            for (int i = 0; i < l; i++)
            {
                if (str_arr[i] == "+")
                {
                    list_exp.Add(new PlusExpression());
                }
                else if (str_arr[i] == "-")
                {
                    list_exp.Add(new MinusExpression());
                }
                else if (str_arr[i] == "*")
                {
                    list_exp.Add(new MultiplicationExpression());
                }
                else if (str_arr[i] == "/")
                {
                    list_exp.Add(new DivideExpression());
                }
                else
                {
                    _Number = 0;
                    IsNumber = int.TryParse(str_arr[i], out _Number);
                    if (IsNumber)
                    {
                        list_exp.Add(new Number(_Number));
                    }
                    else
                    {
                        throw new SyntaxErrorException();
                    }
                }
            }
            return list_exp;
        }
    }
}
