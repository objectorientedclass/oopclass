using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zojfard
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int sumodd,sumeven, n,i;
            sumeven = 0;
            sumodd = 0;
            Console.Write("enter 10 numbers");
            for(i=1;i<=10;i++)

            {
                n = int.Parse(Console.ReadLine());
                if (n % 2 == 0) sumeven = sumeven + 1;

                else sumodd = sumodd + 1;
                
            
                    
            }

            Console.WriteLine("odd ={0} even={1}", sumodd, sumeven);
            Console.ReadKey();
        }
    }
}
