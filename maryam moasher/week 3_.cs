using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication10
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, max, min;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            max = a;
            min = b;
            if (b > max)
                max = b;
            else
                min = b;
            if (c > max)
                max = c;
            if (c < min)
                min = c;
            Console.WriteLine("max: "+max+" min:"+min );
            Console.ReadLine();



        }
    }
}
