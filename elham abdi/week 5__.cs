using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fibo_bazgashti
{
    class Program
    {
        static void Main(string[] args)
        {int fibo(int n)
            { if (n == 1 || n == 2) return 1;
                else return fibo(n - 1) + fibo(n - 2);
                Console.ReadKey();
                    }
        }
    }
}
