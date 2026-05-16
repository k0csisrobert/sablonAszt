using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hegyekCLI
{
    public class Hegycsucs
    {
        //Hegycsúcs neve;Hegység;Magasság

        public string Nev { get; private set; }
        public string Hegyseg { get; private set; }
        public int Magassag {  get; private set; }

        public Hegycsucs(string sor)
        {
            string[] adatok = sor.Split(";");
            Nev = adatok[0];
            Hegyseg = adatok[1];
            Magassag = int.Parse(adatok[2]);
        }
    }
}
