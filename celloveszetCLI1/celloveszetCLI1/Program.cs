namespace celloveszetCLI1
{
    public class Program
    {
        static void Main(string[] args)
        {
            var beolvasas = File.ReadAllLines("lovesek.csv");
            List<cellovo> cellovok = new List<cellovo>();
            foreach (var item in beolvasas)
            {
                cellovok.Add(new cellovo(item));
            }

            //9. feladat
            foreach (var item in cellovok)
            {
                Console.WriteLine($"{item.nev} {item.Legnagyobb()}");
            }
            Console.WriteLine("");

            //10. feladat
            cellovo legjobbatLovo = cellovok[0];
            foreach (var item in cellovok)
            {
                if (legjobbatLovo.Legnagyobb() < item.Legnagyobb())
                {
                    legjobbatLovo=item;
                    Console.WriteLine($"A legnagyobb találatot lovő eredményei: \n {legjobbatLovo.nev} {legjobbatLovo.L1} {legjobbatLovo.L2} {legjobbatLovo.L3} {legjobbatLovo.L4}");
                }
            }
            Console.WriteLine("");

            //11. feladat
            cellovo legrosszabb = cellovok[0];
            
            foreach (var item in cellovok)
            {
                double atlag = (item.L1 + item.L2 + item.L3 + item.L4) / 4.0;
                double legAlacsonyabb = (legrosszabb.L1 + legrosszabb.L2 + legrosszabb.L3 + legrosszabb.L4) / 4.0;
                if (atlag < legAlacsonyabb)
                {
                    legrosszabb = item;
                }
            }
            double rosszAtlag = (legrosszabb.L1 + legrosszabb.L2 + legrosszabb.L3 + legrosszabb.L4) / 4;
            Console.WriteLine($"A leggyengebbatlagu talalatot lovo eredmenyei: \n{legrosszabb.nev} {rosszAtlag}");

        }

        
    }
}
