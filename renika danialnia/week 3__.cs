using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice;
            Console.WriteLine("madrake tahsili shoma chist?");
            Console.WriteLine("[1]sikl");
            Console.WriteLine("[2]diplom");
            Console.WriteLine("[3]foghe diplom");
            Console.WriteLine("[4]lisans");
            Console.WriteLine("[5]foghe lisans");
            Console.WriteLine("[6]doctora");
            Console.WriteLine("[7]na moshakhas");
            Console.Write("code madrak ra vared konid");
            choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("sikl");
                    break;
                case 2:
                    Console.WriteLine("diplom");
                    break;
                case 3:
                    Console.WriteLine("foghe diplom");
                    break;
                case 4:
                    Console.WriteLine("lisans");
                    break;
                case 5:
                    Console.WriteLine("foghe lisans");
                    break;
                case 6:
                    Console.WriteLine("doctora");
                    break;
                case 7:
                  
                    Console.WriteLine("na moshakhas");
                    break;
                    Console.Readkey();
                     }


        }
    }
}
