using System;
using System.CodeDom.Compiler;

namespace Introduction.UnitTest.Calculator
{
    public class Calculator
    {
        public int Add(params int[] additives)
        {
            int result = 0;
            foreach (var additive in additives)
            {
                result += additive;
            }
            return result;
        }

        public int Subtract(params int[] negatives)
        {
            var result = 0;
            if (negatives.Length == 0)
            {
                throw new ArgumentNullException();
            }

            result = negatives[0];

            for (int index = 1; index < negatives.Length; index++)
            {
                result -= negatives[index];
            }

            return result;
        }

        public int Multiply(int x, int y)
        {
            return x*y;
        }

        public int Divide(int dividend, int divisor)
        {
            try
            {
                return dividend/divisor;
            }
            catch (DivideByZeroException)
            {
                throw new Exception("We can not divide by zero");
            }
            return 0;
        }
    }
}
