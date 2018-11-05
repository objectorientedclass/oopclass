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
            int a;
            a =int.Parse(Console.ReadLine());
            Console.WriteLine("Enter of a:18 ");
            Console.WriteLine("name:maryam");
            Console.WriteLine("famili:moasher");
            if (a > 17)
                Console.WriteLine("momtaz");
            else
                if (a < 17 && a > 12)
                    Console.WriteLine("mamoli");
                else
                    if (a < 12)
                        Console.WriteLine("mashrot");
            Console.ReadLine();
            

        }
    }
}
