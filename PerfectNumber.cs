using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logicalprogramming
{
    public class PerfectNumber
    {
       
        public static void DisplayPerfectNumber()
        {
            int min,max,n;
            
            Console.WriteLine("Enter the min range of perfect number");
            min=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the max range of perfect number");
            max=Convert.ToInt32(Console.ReadLine());

            for(n=min;n<max;n++)
            {
                int sum = 0;
                int i = 1;

                while (i < n)
                {

                    if (n % i == 0)
                    {
                        sum = sum + i;
                        i++;
                    }
                }
                    if(sum== n)
                    {
                        Console.WriteLine("{0}", n);
                    }

                    
                
            }
        }
    }
}
