using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericProblems
{
    internal class Generic
    {
        public static int CheckMaximum(int number1, int number2, int number3)
        {

            int maximum = number1.CompareTo(number2) == 1 ? number1 : number2;
            maximum = maximum.CompareTo(number3) == 1 ? maximum : number3;
            Console.WriteLine("The maximum number is {0}", maximum);
            Console.WriteLine("\n");
            return maximum;
        }

        public static float CheckMaximumFloat(float number4, float number5, float number6)
        {
            float maximumFloat = number4.CompareTo(number5) == 1 ? number4 : number5;
            maximumFloat = maximumFloat.CompareTo(number6) == 1 ? maximumFloat : number6;
            Console.WriteLine("The maximum float number is {0}", maximumFloat);
            Console.WriteLine("\n");
            return maximumFloat;
        }

        public static string CheckMaximumString(string s1, string s2, string s3)
        {
            string maximumString = s1.CompareTo(s2) == 1 ? s1 : s2;
            maximumString = maximumString.CompareTo(s3) == 1 ? maximumString : s3;
            Console.WriteLine("The maximum float number is {0}", maximumString);
            return maximumString;
        }
    }
}
