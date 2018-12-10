using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program6
{
    class complex
    {
        private int real;
        private int imag;
        public complex()
        {
            real=0;
            image = 0;

        }
        public complex(int real,int imge)
        {
            this. real = real;
            this. imag = imag;
        }
        public static complex operator+(complex c1,complex c2)
    {
        return new complex(c1.real + c2.real, c1.imag + c2.imag);
    }
        public static operator-(complex c1,complex c2)
        {
            return new complex(c1.real-c2.real,c1.imag-c2.imag);
        }
        static void Main(string[] args)
        {
        }
    }
}
