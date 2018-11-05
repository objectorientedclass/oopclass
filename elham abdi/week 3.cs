using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace moadel
{
    class Program
    {
        static void Main(string[] args)
        {
            string n;
            float x;
            Console.Write("enter name and family:");
            n = Console.ReadLine();
            Console.Write("enter the average");
            x = float.Parse(Console.ReadLine());
            if (x > 17)
                Console.WriteLine("Excellent Student");
            else if (12< x && x<17 )
                Console.WriteLine("Usaul Student");
            else Console.WriteLine("Weak Student");
            Console.ReadKey();
               


        }
    }
}
