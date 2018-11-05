using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication9
{
    class Program
    {
        static void Main(string[] args)
        {
            string nam, family;
            double a, b, c, ave;
            Console.Write("nam ra vared konid=");
            nam = Console.ReadLine();
            Console.Write("family ra vared konid=");
            family = Console.ReadLine();
            Console.Write("nomreie riazi ra vared konid=");
            a = double.Parse(Console.ReadLine());
            Console.Write("nomreie englisi ra vared konid=");
            b=double.Parse(Console.ReadLine());
            Console.Write("nomreie barname nvisi ra vared konid=");
            c = double.Parse(Console.ReadLine());
            ave = (a + b + c) / 3;
            Console.WriteLine("ave is={0}",ave);
            Console.ReadKey();


        }
    }
}
