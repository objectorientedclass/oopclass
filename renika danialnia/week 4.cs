using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mosbat_manfi
{
    class Program
    {
        static void Main(string[] args)
        {
            double a,n, manfi, mosbat, sefr;
            manfi = 0; mosbat = 0; sefr = 0;
            for(int i=-1;i<=n;i++)
            {
                Console.Write("enter number");
                a = double.Parse(Console.ReadLine());
                if(a<=-1)
                {
                    manfi = manfi + 1;
                }
                else if(a==-1)
                {
                    sefr = sefr + 1;
                }
                else if (a>-1)
                {
                    mosbat = mosbat + 1;
                }
Console.Write("tedad manfi={0}\ntedad sefr={1}\ntedad mosbat={2}",manfi,sefr,mosbat);
                Console.ReadKey();
            }
        }
    }
}
