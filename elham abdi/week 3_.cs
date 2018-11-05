using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace madrak
{
    class Program
    {
        static void Main(string[] args)
        {
            int code;
            Console.Write("enter lisence code");
            code = int.Parse(Console.ReadLine());
            switch(code)
            {
                case 1:
                    Console.WriteLine("zirediplom");break;
                case 2:
                    Console.WriteLine("diplom");break;
                case 3:
                    Console.WriteLine("foghediplom");break;
                case 4:
                    Console.WriteLine("lisans");break;
                case 5:
                    Console.WriteLine("foghlisans");break;
                case 6:
                    Console.WriteLine("doktora");break;
                case 7:
                    Console.WriteLine("na moshakas");break;
                   

                
            }
        }
    
    }
}
