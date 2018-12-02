using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    using System;
    public class date1
    {
        private int year;
        private int month;
        private int day;
        public  date1()
        {
            setdate(0, 0, 0);
        }
        public void setdate(int yearvalue, int monthvalue, int dayvalue)
    {

        year = (yearvalue > 0) ? yearvalue : 0;

        month = (monthvalue > 0 && monthvalue<= 12)? monthvalue:0;
        day = (dayvalue > 0 && dayvalue <= 30) ? dayvalue : 0;
    }
        public string tostring()
        {
            return string.Format("{0}:{1}:{2}";year,month,day);
        }
        }
        static void Main(string[] args)
        {
        }
    }
}
