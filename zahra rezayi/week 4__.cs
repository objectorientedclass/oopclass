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
            double a,n, t_manfi, t_mosbat, T_sefr;
            t_manfi = 0; t_mosbat = 0; T_sefr = 0;
            for(int i=-1;i<=n;i++)
            {
                Console.Write("enter number");
                a = double.Parse(Console.ReadLine());
                if(a<=-1)
                {
                    t_manfi = t_manfi + 1;
                }
                else if(a==-1)
                {
                    T_sefr = T_sefr + 1;
                }
                else if (a>-1)
                {
                    t_mosbat = t_mosbat + 1;
                }
Console.Write("tedad manfi={0}\ntedad sefr={1}\ntedad mosbat={2}",t_manfi,T_sefr,t_mosbat);
                Console.ReadKey();
            }
        }
    }
}
