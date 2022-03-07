using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logicalprogramming
{
    public class ReversetheNumber
    {
        public static void DisplayReverseNumber()
        {
            int n;
            int reverse=0;
            int rem;
            Console.WriteLine("Enter the number to be reversed");
            n = Convert.ToInt32(Console.ReadLine());
            while (n!= 0)
            {
                rem = n % 10;
                reverse= reverse * 10 + rem;
                n= n/ 10;
            }

            Console.WriteLine(" Reverse number " + reverse);
        }
    }
}
