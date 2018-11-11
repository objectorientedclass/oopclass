using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zoj
{
    class Program
    {
        static void Main(string[] args)
        {
            int odd, even, n, j;
            even = 0;
            odd = 0;
            Console.Write("enter 10 numbers");
            for (j = 1; j <= 10; j++) ;
            {
                n = int.Parse(Console.ReadLine());
                if (n % 2 == 0) even = even + 1;
                else odd = odd + 1;
            }
            Console.WriteLine("odd={0} even={1}", odd, even);
            Console.ReadKey();
        }
    }
}
