using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_math_
{
    class Program
    {
        static void Main(string[] args)
        {
            parallelogram p = new parallelogram(4,3,2);
            Rectangle r = new Rectangle(3,2);
            Squar s = new Squar(2, 2);
            Console.WriteLine("Area:{0} Surrounding:{1}", p.CalculateArea(), p.Calculatesurrounding());
            Console.WriteLine("Area:{0} Surrounding:{1}", r.CalculateArea(), r.Calculatesurrounding());
            Console.WriteLine("Area:{0} Surrounding:{1}", s.CalculateArea(), s.Calculatesurrounding());
            Console.ReadKey();
        }
    }
}
