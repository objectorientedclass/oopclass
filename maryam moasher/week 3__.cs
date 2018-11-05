using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication12
{
    class Program
    {
        static void Main(string[] args)
        {
            String grade="C";
            switch (grade) {
                case "A":
                    Console.WriteLine("zire diplom");
                    break;
                case"B":
                    Console.WriteLine("diplom");
                    break;
                case"C":
                    Console.WriteLine("lisans");
                    break;
                case"D":
                    Console.WriteLine("foghe lisans");
                    break;
                case"E":
                    Console.WriteLine("doktora");
                    break;
                case"F":
                    Console.WriteLine("foghe doktora");
                    break;
                case"G":
                    Console.WriteLine("namoshakhas");
                    break;
            }
            Console.ReadLine();
        }
    }
}
