using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestProject
{
    public static class MathHelper
    {
        public static int GetSum(int firstVal, int secondVal)
        {
            return firstVal + secondVal;
        }
        public static int GetDifference(int firstVal, int secondVal)
        {
            return firstVal - secondVal;
        }

        public static double GetProduct(double value1, double value2)
        {
            return Math.Round(Convert.ToDouble(value1 * value2), 2);
        }

        public static double GetPI()
        {
            return Math.PI;
        }


        public static double GetSqrt(double number) {
            return Math.Sqrt(number);
        }
        public static int ReturnSameInput(int input)
        {
            return input;
        }
        public static double CalcualteTotalDurationMinutes(short durationHours, short durationMinutes, short durationSeconds)
        {
            return (double)((durationHours * 60) + durationMinutes + (double)Math.Round(((double)durationSeconds / 60.0d), 2));
        }
    }
}
