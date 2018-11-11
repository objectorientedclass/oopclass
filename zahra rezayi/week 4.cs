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
            int fibo, n;
            int a = 1, b = 1;
            fibo = 0;
            Console.Write("enter number=");
            n = int.Parse(Console.ReadLine());
            Console.Write("{0} {1}", a, b);
            for (int i = 3; i <= n; i++) 
            {
                fibo = a + b;
                Console.Write("{0}", fibo);
                a = b;
                b = fibo;
            }
            Console.ReadKey();
        }
    }
}
