namespace Meetodite_töö
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            double[] Arvud = { 7.6d, 6.8d, 5.7d, 2.9d, 7.2d };

            //Esimene ülesanne: Tervitus
            Tervitus();


            //Teine ülesanne: Arvutus
            double arvutusTulemus = Arvutus(Arvud);
            Console.WriteLine("\n"+arvutusTulemus);


            //Kolmas ülesanne: Tänavanime pikkus
            Console.WriteLine("\nKus tänaval sa elad ?");
            string tänavaNimi = Console.ReadLine();
            int tänavaNimePikkus = TänavaNimePikkus(tänavaNimi);
            Console.WriteLine("\nSinu tänava nimes on " + tänavaNimePikkus+" tähte");


            //neljas ülesanne: Raha põhjal sõnum
            Console.WriteLine("\nKui palju raha sa poes kulutasid ?");
            tänavaNimi = Console.ReadLine();
            string sõnum = RahaVahemik(tänavaNimi);
            Console.WriteLine(sõnum);


        }

        //neljas ülesanne: Raha põhjal sõnum
        public static string RahaVahemik(string kulutatudRaha)
        {
            float Raha = float.Parse(kulutatudRaha);
            if (Raha < 0)
            {
                return "Oppa, sissetulek!";
            }
            else if (Raha >= 0 && Raha < 5)
            {
                return "sänakimoney";
            }
            else if (Raha >= 5 && Raha < 10)
            {
                return "tänane söögiraha";
            }
            else if (Raha >= 10 && Raha < 25)
            {
                return "tavaline extraspend";
            }
            else if (Raha >= 25 && Raha < 75)
            {
                return "täielik priiskamine";
            }
            else
            {
                return "appi milline priiskamine !!!!!!";
            }
        }

        //Kolamas ülesanne: Tänavanime pikkus
        public static int TänavaNimePikkus(string tänavaNimi)
        {
            return tänavaNimi.Length;
        }

        //Teine ülesanne: Arvutus
        public static double Arvutus(double[] Arvud)
        {
            double tulemus = 0;
            foreach (double d in Arvud)
            {
                tulemus -= d;
            }
            return tulemus;
        }

        //Esimene ülesanne: Tervitus
        public static void Tervitus()
        {
            Console.WriteLine("Tere !");
        }


    }
}
