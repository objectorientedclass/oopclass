using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            int area, perimeter;
            Console.Write("Enter width of rectangle: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("eNTER HEIGHT OF RECTANGLE: ");
            y = Convert.ToInt32(Console.ReadLine());
            area = x * y;
            perimeter = 2 * (x + y);
            Console.WriteLine("Area is {0},Perimeter is{1}", area, perimeter);
            Console.Write("\n\npress any key to exit");
            Console.ReadLine();

        }
    }
}
