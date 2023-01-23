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
            l.EstraiSingolo();
            Console.WriteLine(l.RegistroEstrazioni()[0] != 0);
        }
    }
}
