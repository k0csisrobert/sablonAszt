using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace celloveszetCLI1
{
    public class cellovo
    {
        //Ricsi;26;97;33;0
        public string nev { get; private set; }
        public int L1 { get; private set; }
        public int L2 { get; private set; }
        public int L3 { get; private set; }
        public int L4 { get; private set; }

        public cellovo(string sor)
        {
            string[] adatok = sor.Split(";");
            this.nev = adatok[0];
            this.L1 = int.Parse(adatok[1]);
            this.L2 = int.Parse(adatok[2]);
            this.L3 = int.Parse(adatok[3]);
            this.L4 = int.Parse(adatok[4]);
        }

        public int Legnagyobb()
        {
            List<int> legnagyobbak = new List<int>() {L1, L2, L3, L4};
            return legnagyobbak.Max();
        }
    }
}
