using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class EulerProblem1
    {
        public static void problem1()
        {
            int total = 0;
            Console.WriteLine("Input Number");
            string s = Console.ReadLine();
            int n = Convert.ToInt32(s);
            for (int i = 0; i <= n; i++)
            {
                if (i % 5 == 0)
                {
                    if (i % 3 == 0)
                    {
                        total += i;
                    }
                }
            }
            Console.Write(String.Format("The total sun of multiples 3 and 5 below {0} = {1}",n.ToString(), total.ToString()));
            Console.Read();
        }     

    }
}
