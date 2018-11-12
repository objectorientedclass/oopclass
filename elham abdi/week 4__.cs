using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fibo
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, i, n;
            a = 0;
            b = 1;
            c = 0;
            Console.Write("enter the number");
            n = int.Parse(Console.ReadLine());
            for(i=0;i<n;i++)
            {
                c = a + b;
                a = b;
                b = c;
            }
            Console.WriteLine("{0}",c);
            Console.ReadKey();
            
        
        }
    }
}
