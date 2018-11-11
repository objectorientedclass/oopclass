using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fibonachi
{
    class Program
    {
        static void Main(string[] args)
        {
            int fibonachi, n;
            int a = 1, b = 1;
            fibonachi = 0;
            Console.Write("enter number=");
            n = int.Parse(Console.ReadLine());
            Console.Write("{0} {1}", a, b);
            for (int i = 3; i <= n; i++) 
            {
                fibonachi = a + b;
                Console.Write("{0}", fibonachi);
                a = b;
                b = fibonachi;
            }
            Console.ReadKey();
        }
    }
}
