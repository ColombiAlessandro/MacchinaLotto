using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MacchinaLotto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Lotto l = new Lotto("1", "12/10/2005");
            /*
            Lotto c = new Lotto("2", "3/12/1923");
            Console.WriteLine(l.Equals(c));
            try
            {
                Console.WriteLine(l.EstraiSingolo());
                Console.WriteLine(l.EstraiSingolo());
                Console.WriteLine(l.EstraiSingolo());
                Console.WriteLine(l.EstraiSingolo());
                Console.WriteLine(l.EstraiSingolo());
                Console.WriteLine(l.EstraiSingolo());
            } catch(Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            Console.Clear();
            l.EstraiCinque();
            l.EstraiCinque();
            l.EstraiCinque();
            l.EstraiCinque();
            l.EstraiCinque();
            l.EstraiCinque();
            l.EstraiCinque();
            l.EstraiCinque();
            l.EstraiCinque();
            l.EstraiCinque();
            */
            l.EstraiCinque();
            int[] controllo = new int[4];
            
            

            int[] tot = l.RegistroEstrazioni();
            controllo[0] = tot[0];
            controllo[1] = tot[1];
            controllo[2] = tot[2];
            controllo[3] = tot[3];
            int g = l.VerificaEstrazioni(controllo, 4);
            /*for(int i = 0; i < tot.Length; i++)
            {
                Console.WriteLine(tot[i]);
            }*/
            Console.WriteLine(l.toString());
        }
    }
}
