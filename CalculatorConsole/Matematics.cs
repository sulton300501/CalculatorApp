﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorConsole
{
    public class Matematics
    {


        public static double Add(double x , double y)
        {
            return x + y;
        }

        public static double Divide(double x, double y)
        {
            if (x == 0 && y == 0)
            {
                throw new ArgumentNullException($"{nameof(x)} and {nameof(y)} 0 ga teng ");
                
            }else if(y==0)
            {
                throw new DivideByZeroException($"{nameof(y)} 0 ga teng bolishi mumkun emas");
            }
            return x / y;
        }

        public static double Multiple(double x, double y)
        {
            return x * y;
        }


        public static double Substract(double x, double y)
        {
            return x - y;
        }


        public static bool IsValidate(int x)
        {
            if(x< 0)
            {
                return false;
            }
            return true;

        }

        public static int CheckPerimeter(int a, int b, int c)
        {
            return a + b + c;
        }


    }
}
