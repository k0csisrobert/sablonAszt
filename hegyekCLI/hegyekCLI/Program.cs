namespace hegyekCLI
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] beolvasas = File.ReadAllLines("hegyek.csv");
            List<Hegycsucs> hegyek = new List<Hegycsucs>();

            foreach (var item in beolvasas.Skip(1))
            {
                hegyek.Add(new Hegycsucs(item));
            }

            //8. feladat
            foreach (var item in hegyek)
            {
                if (item.Magassag>950)
                {
                    Console.WriteLine($"{item.Nev} {item.Hegyseg} {item.Magassag}");
                }
            }
            Console.WriteLine("");

            //11. feladat
            Console.WriteLine($"Kérem a keresett szót: ");
            string bekert= Console.ReadLine();
            Console.WriteLine("........");
            foreach (var item in hegyek)
            {
                if (tartalmaz(bekert, item.Nev, item.Hegyseg) == true)
                {
                    Console.WriteLine($"{item.Nev}");
                }
            }
            
        }

        public static bool tartalmaz(string szo, string hegycsucs, string hegyseg)
        {
            if (hegycsucs.ToLower().Contains(szo.ToLower()) || hegyseg.ToLower().Contains(szo.ToLower()))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
