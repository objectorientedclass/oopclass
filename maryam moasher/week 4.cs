using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication17
{
    class Program
    {
        static void Main()
        {
            int EnterNumber = 5;
            int result = EnterNumber;
            for (int i = 1; i < EnterNumber; i++)
            {
                result = result * i;
            }
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
