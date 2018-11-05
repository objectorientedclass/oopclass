using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            string name, family;
            double moadel;
            Console.Write("name ra vared konid:");
            name =Console.ReadLine();
            Console.Write("family ra vared konid:");
            family = Console.ReadLine();
            Console.Write("moadel ra vared konid;");
            moadel = double.Parse(Console.ReadLine());
            if (moadel > 17)
                Console.WriteLine("momtaz");
            else
                if (moadel < 12)
                    Console.WriteLine("mashrut");
                else
                    Console.WriteLine("mamuli");
            Console.ReadLine(); 
        }
    }
}
