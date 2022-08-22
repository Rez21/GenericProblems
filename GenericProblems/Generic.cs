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
            return maximum;
        }
    }
}
