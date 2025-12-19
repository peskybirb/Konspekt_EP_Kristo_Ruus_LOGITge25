namespace esimeneprojekt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //näiteprogramm 1

            /*
            int palk = 2345;
            int kulud = 0;

            Console.WriteLine("kas see kuu kulusid või väljaminekuid olid (jah/ei) ?");
            string kasutajavastus = "";
            kasutajavastus = Console.ReadLine();
            if (kasutajavastus == "jah") ;
            {
                Console.WriteLine("sisestage kõik kulud ühe arvuna");
                kulud = int.Parse(Console.ReadLine());
            }

            int kontojääk = palk - kulud;
            Console.WriteLine(kontojääk+" puulehte on alles.");

            Console.WriteLine("Palusn sisesta oma hästi tehtud töö boonus");
            int boonus = int.Parse(Console.ReadLine());
            kontojääk = kontojääk + boonus;
            Console.WriteLine("sinu lõppväjavõte on "+kontojääk+" puulehte");
            

            //ctrl + k + c/u
            
                     LIHT ANDMTÜÜBID         
            string tekst = "mingisugune inimloetav tekst" //tekst
            char täht = 'A'; // üks täht '' vahele
            int arv = 1; //täisarv
            float komakohagaarv = 1.5f; //32bi
            double suuremakomakohagaarv = 1.5d; //64bit
            decimal kümendsüstemikomakohagaarv = 1.5M;
            var X = 123; //umbmäärane andmetüübiga ajutine muutuja
            var Y = "ABC";
            bool jahvõiei = false; //kas true või false.

            
            //string string = "abc"; //very bad 
            string sõne = "abc"; //good
            

            
             * programm küsib kas ta on 18 "alaealise sisse ei lasta"
             * kui ta on vanem kui 18 , pakutakse mojitot
             */

            int kasutajavanus = 0;
            Console.WriteLine("kui vana sa oled?");
            kasutajavanus = int.Parse(Console.ReadLine());
            if (kasutajavanus >= 18)
            {
                Console.WriteLine("Tere siin on sinu mojito🍸");
            }
            else
            {
                Console.WriteLine("Alaealisi sisse ei lubata , mine vembutembumaale");
            }
            
        }
    }
}
