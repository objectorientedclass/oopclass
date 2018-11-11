using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fact
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int fact,i,n;
                fact=1;
            Console.Write("enter number");
            n=int.Parse(Console.ReadLine());
            for( i=1;i<=n;i++)
            {
                fact=fact*i;
            }
            Console.WriteLine("fact("+n+")="+fact);
           Console.ReadKey();
 
    }
            
        }
    }

