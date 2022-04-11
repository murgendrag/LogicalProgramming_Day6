using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logicalprogramming
{
    public class Coupon
    {
        public static void DistinctCoupon()
        {
            int[] Couponarray = new int[100];
            Random random = new Random();
            for (int i = 1; i < 100; i++)
            {
                int Number = random.Next(100);
                Couponarray[i] = Number;
                Console.WriteLine(Couponarray[i]);
            }
         }
    }
}
