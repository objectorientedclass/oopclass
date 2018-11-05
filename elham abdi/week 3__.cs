using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minmax
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[4];
            int max, min, i;
            Console.Write("enter numbers");
            for (i = 0; i < 3; i++)
                a[i] = int.Parse(Console.ReadLine());
            max = min = a[0];
            for (i = 1; i < 4; i++)
            {
                if (a[i] > max)
                {
                    max = a[i];
                }
                if (a[i] < min)
                {
                    min = a[i];
                }
            }

            Console.WriteLine("max is {0} and min is {1}", max, min);
            Console.ReadKey();
        }
    }
}
