using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class complex
    {
        static void Main(string[] args)
        {
            complex start=new complex (2,5);
            complex finish = new complex (4, 3);
            complex objcomplex = new complex();
            complex objcompex = start + finish;
            complex objcompex 1 = start -finish;
            
            Console.WriteLine("sum is :{0} and sub is :{1}");
        }
    }
}
