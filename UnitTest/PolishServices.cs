using System;
using System.Collections.Generic;

namespace Project.Service
{
    public class PolishServices
    {
        private static readonly string[] sings = { "+", "-", "*", "/" };

        private static bool IsSing(string value)
        {
            return Array.IndexOf(sings, value) > -1;
        }

        private static double Operation(double x, double y, string operation)
        {
            switch (operation)
            {
                case "+": return x + y;
                case "-": return x - y;
                case "*": return x * y;
                case "/": return x / y;
                default: return 0;
            }
        }

        public static double GetResult(string expression)
        {
            string[] values = expression.Split(' ', ',');
            List<double> buffer = new List<double>();

            foreach (string value in values)
            {
                if (IsSing(value))
                {
                    double y = buffer.PopBack();
                    double x = buffer.PopBack();
                    double result = Operation(x, y, value);
                    buffer.PushBack(result);
                }
                else
                {
                    double.TryParse(value, out double number);
                    buffer.Add(number);
                }
            }

            return buffer.FirstOrDefault();
        }
    }
}