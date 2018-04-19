using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class EulerProblem3
    {
        public static void problem3() {

            List<int> Nums = new List<int>();
            Console.WriteLine("Input Number");
            int num = Convert.ToInt32(Console.ReadLine());

            for(int i = 1; i <= num; i++)
            {
                if(num % i == 0)
                {
                    bool isPrime = true;
                    for(int j = 2; i<=9; i++)
                    {
                        if (num % j == 0)
                        {
                            isPrime = false;
                        }
                    }
                    if (isPrime)
                    {
                        Nums.Add(i);
                    }
                    
                }
            }


            Console.WriteLine("Output:");
            Nums.ForEach(Console.WriteLine);
            Console.ReadLine();

        }
    }
}
