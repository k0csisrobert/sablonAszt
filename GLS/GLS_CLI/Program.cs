namespace GLS_CLI
{
    public class Program
    {
        //5. feladat
        public static double NapiFogyasztás(int fogyasztas, int megtettKm)
        {
            if (fogyasztas <= 0 || megtettKm <= 0)
            {
                return 0;
            }
            else
            {
                return fogyasztas / (double)((double)(megtettKm) / 100);
            }
        }


        static void Main(string[] args)
        {
            List<AutóAdatok> autoAdatok = new List<AutóAdatok>();
            string[] sorok = File.ReadAllLines("GLS.txt");
            foreach (var item in sorok)
            {
                autoAdatok.Add(new AutóAdatok(item));
            }

            //2. feladat

            Console.WriteLine($"Az autó használatban töltött napjainak száma: {autoAdatok.Count}");

            //3. feladat
            int soforokSzama = autoAdatok.GroupBy(adat => adat.Sofőr).Count();
            Console.WriteLine($"Különböző sofőrök száma: {soforokSzama}");

            //4. feladat
            int osszesKm = autoAdatok.Sum(adat => adat.km);
            Console.WriteLine($"Az összes megtett kilométer: {osszesKm} km");

            //6. feladat
            int osszesFogyasztas = autoAdatok.Sum(adat => adat.Fogyasztás);
            Console.WriteLine($"Átlagos fogyasztás: {NapiFogyasztás(osszesFogyasztas, osszesKm)} liter/100km");

            //7. feladat

            var sofor = autoAdatok.GroupBy(adat => adat.Sofőr)
                .Select(x => new { SoforNev = x.Key, VezetettNap = x.Count() })
                .OrderByDescending(sofor => sofor.VezetettNap).First();

            Console.WriteLine($"A legtöbbet vezető sofőr: {sofor.SoforNev}, napok száma: {sofor.VezetettNap}");
        }
    }
}
