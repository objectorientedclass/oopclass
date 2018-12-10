using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace tarikh
{
    class date
    {
        static void Main(string[] args)
        {
            date date1 = new date();
            string output;



            date.setdate(1397 / 9 / 5);
            output = date1.ToString();
            Console.WriteLine("date is :{0}";output);
        }
    }
}
