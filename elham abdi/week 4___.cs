using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fact
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, n, f;
            Console.Write("enter the number");
            n = int.Parse(Console.ReadLine());
            for (i = 1; i <= n; i++)
            {
                f *= i;
            }     
            Console.WriteLine("factoriel{0}", f);
            Console.ReadKey();


            
               
        }
    }
}
