using System;
using System.Collections.Generic;
using System.Text;

namespace MethodOverloading
{
    internal class Methods
    {
        public static int Add(int a, int b)
        {
            return a + b;   
        }
        public static double Add(double a, double b)
        {
            return a + b;
        }
        public static string Add(int a, int b, bool isTrue)
        {
            var sum = 0;
            string answer = "";

            if (isTrue)
            {
                sum = a + b;

                if (sum == 1)
                {
                    return $" {sum} dollar.";
                }
                else
                {
                    return $" {sum} dollars.";
                }
            }
            return answer;
        }
    }
}
