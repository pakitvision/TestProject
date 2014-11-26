﻿using System;
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
    }
}
