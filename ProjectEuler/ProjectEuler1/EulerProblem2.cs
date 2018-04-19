using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class EulerProblem2
    {
        public static void problem2()
        {
            // 1 1 2 3 5 8
            Console.WriteLine("Number in the sequence to go to:");
            int n = Convert.ToInt32(Console.ReadLine());
            int first = 0;
            int second = 1;
            int third = 0;

            int total = 1;
            int totalEven = 0;            
            
            while (third <= 4000000)
            {
                third = first + second;
                if (third % 2 == 0)
                {
                    totalEven += third;
                }
                total += third;

                first = second;
                second = third;
                         
                
                
                //Console.WriteLine(third);
            }
            Console.WriteLine("Total:");
            Console.WriteLine(total);
            Console.WriteLine("Total Even:");
            Console.WriteLine(totalEven);
            Console.ReadLine();
        }
    }
}
