using System;

namespace CalculatorLibrary
{
    public class Calculator
    {
        public static double Add(double v1, double v2)
        {
            return v1 + v2;
        }

        public static double Subtract(double v1, double v2)
        {
            return v1 - v2;
        }

        public static double Multiply(double v1, double v2)
        {
            return v1 * v2;
        }

        public static double Divide(double v1, double v2)
        {
            throw new NotImplementedException();
        }

        public static double Sum(double[] numbers)
        {
            throw new NotImplementedException();
        }

        public static double Minimum(double[] numbers)
        {
            throw new NotImplementedException();
        }

        public static double Maximum(double[] numbers)
        {
            throw new NotImplementedException();
        }

        public static double Average(double[] numbers)
        {
            throw new NotImplementedException();
        }
    }
}
