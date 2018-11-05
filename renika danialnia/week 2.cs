using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, masahat;
            Console.Write("tool=");
            a = double.Parse(Console.ReadLine());
            Console.Write("arz=");
            b = double.Parse(Console.ReadLine());
            masahat = a * b;
            Console.WriteLine("masahat={0}", masahat);
                Console.ReadKey();
        }
    }
}
