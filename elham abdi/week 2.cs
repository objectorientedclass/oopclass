using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class average
    {
        static void Main(string[] args)
        {
            int i;
            string name;
          
            float ave, P,E,M;
            Console.Write("enter student's name and family");
            name = Console.ReadLine();
            Console.Write("enter student's ID number");
            i = int.Parse(Console.ReadLine());
            Console.Write("enter math mark");
            M = float.Parse(Console.ReadLine());
            Console.Write("enter programming mark");
            P = float.Parse(Console.ReadLine());
            Console.Write("enter english mark");
            E = float.Parse(Console.ReadLine());
            ave = (M + P + E) / 3;
            Console.WriteLine("average of {0} is {1}", name, ave);
            Console.ReadKey();
            
           
     
                
                
              



        }
    }
}
