using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mostatildatatype
{
    class datatypetest
    {
        static void Main(string[] args)
        {
            int l, w;
            Console.Write("enter lenghth");
            l = int.Parse(Console.ReadLine());
            Console.Write("enter width");
            w = int.Parse(Console.ReadLine());
            typetest(l,w);

        }
        static void typetest(int l)
        {
            int a, s;
            a = l * w;
            s = (l + w) / 2;
            Console.WriteLine("masahat={0} mohit={1}", a, s);
        }
    }
}
