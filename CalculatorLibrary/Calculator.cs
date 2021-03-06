﻿using System;

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
            return v1 / v2;
        }

        public static double Sum(double[] numbers)
        {
            double Sum = 0;
            for (int i = 0; i < numbers.Length; i = i + 1)
            {
                Sum = Sum + numbers[i];
            }
            return Sum;
        }

        public static double Minimum(double[] numbers)
        {
            double Min = numbers[0];
            for (int i = 0; i < numbers.Length; i = i + 1)
            {
                if (Min > numbers[i])
                { Min = numbers[i]; }
            }
            return Min;
        }

        public static double Maximum(double[] numbers)
        {
            double max = numbers[0];
            for (int i = 0; i < numbers.Length; i = i + 1)
            {
                if (max < numbers[i])
                {
                    max = numbers[i];
                }
            }
            return max;
        }

        public static double Average(double[] numbers)
           
        {           
            double avg = Sum(numbers) / numbers.Length;
            return avg;
        }

        public static double Squared(double v)
        {
            return v * v;
        }

        public static double XiY(double v1, double v2)
        {
            double xiy=1;
            for (int i = 0; i < v2; i++)
            {
                xiy = xiy * v1;
            }
            return xiy;
        }
    }
}
