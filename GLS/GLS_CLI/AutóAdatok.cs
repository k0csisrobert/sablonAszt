using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GLS_CLI
{
    public class AutóAdatok
    {
        public string Dátum { get; private set; }
        public string Sofőr { get; private set;}
        public int km{ get; private set; }
        public int CsomagokSzáma { get; private set; }
        public int Fogyasztás { get; private set; }

        public AutóAdatok(string sor)
        {
            Dátum = sor.Split(';')[0];
            Sofőr = sor.Split(';')[1];
            this.km = int.Parse(sor.Split(';')[2]);
            CsomagokSzáma = int.Parse(sor.Split(';')[3]);
            Fogyasztás = int.Parse(sor.Split(';')[4]);
        }

        public AutóAdatok(string dátum, string sofőr, int km, int csomagokSzáma, int fogyasztás)
        {
            this.Dátum = dátum;
            this.Sofőr = sofőr;
            this.km = km;
            this.CsomagokSzáma = csomagokSzáma;
            this.Fogyasztás = fogyasztás;
        }
    }
}
