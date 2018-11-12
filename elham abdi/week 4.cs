using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mosbatmanfi
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, neg, pos, zero, i,num;
            neg = 0;pos = 0;zero = 0;
            Console.Write("tedad adad ");
            n = int.Parse(Console.ReadLine());
            Console.Write("enter numbers");
            for(i=1;i<=n;i++)
            {
                num = int.Parse(Console.ReadLine());
                if (num <= -1) neg = neg + 1;
                else if (num >= 1) pos = pos + 1;
                else zero = zero + 1;
                    

            }
            Console.WriteLine("neg={0} and pos={1} and zero={2}", neg, pos, zero);
            Console.ReadKey();
            

            

        }
    }
}
