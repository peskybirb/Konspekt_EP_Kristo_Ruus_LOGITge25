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
            
            /* ------------------------Teooria-------------------------------
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
            
            */
            int mingiarv = 4;

            mingiarv = mingiarv + 15;   //

            mingiarv = mingiarv - 15;   //

            mingiarv = mingiarv * 15;   //

            mingiarv = mingiarv / 15;   //


            mingiarv += 15;   //

            mingiarv -= 15;   //

            mingiarv *= 15;   //

            mingiarv /= 15;   //

            /*  O M I S T U S    O P E R A A T O R I D */


            // =  e. üksik võrdus märk omistab muutuja sisse väärtuse, mida adreseeritakse muutuja oma nimega
            int muutuuja = 1;
            // +=  e. võrdusmärk mille ees on pluss, automaatselt liidab muutujale otsa võrdusmärgi teselpool oleva väärtuse.
            muutuuja += 2;
            // -=  e. võrdusmärk mille ees on miinus, automaatselt lahutab muutujast võrdusmärgi teselpool oleva väärtuse.
            muutuuja -= 1;
            // *=  e. võrdusmärk mille ees on kordus märk, automaatselt korrutab muutujast võrdusmärgi teselpool oleva väärtuse.
            muutuuja *= 4;
            // /=  e. võrdusmärk mille ees on jamismärk, automaatselt jagab muutujast võrdusmärgi teselpool oleva väärtuse.
            muutuuja /= 4;
            // %= e. võrdusmärk mille ees on modulus, automaatselt jätab muutujasse jäägi
            muutuuja %= 2;
            // ++ e. kiirtehe mis liidab ainult 1 juurde
            muutuuja++;
            // -- e kiirtehe mis lahutab ainult 1 maha
            muutuuja--;

            /* --------------------------------------------------------------------------*/
            /* näiteülesanne 4 */
            // int muutuja = 0;

            Console.WriteLine("Palun sisesta oma vanus");
            int kasutajavanus = int.Parse(Console.ReadLine());

            Console.WriteLine("Palun sisesta oma vanavanaema vanus");
            int kasutajavanavanaemavanus = int.Parse(Console.ReadLine());

            //int vanustevahe = kasutajavanavanaemavanus - kasutajavanus;

            Console.WriteLine("Vannuste vahe hetkel on "+(kasutajavanavanaemavanus - kasutajavanus));
            Console.WriteLine("kui palju sa vanem oled ?");
           /*muutuja*/ kasutajavanus += int.Parse(Console.ReadLine());
            Console.WriteLine("Vanuste vahe nüüd on "+(kasutajavanavanaemavanus - kasutajavanus));
          
            // Console.WriteLine("vanuste vahe ei muutu :3 silly "+((kasutajavanavanaemavanus + muutuja)-(kasutajavanus + muutuja)));
            
            
            
            /*

         * programm küsib kas ta on 18 "alaealise sisse ei lasta"
         * kui ta on vanem kui 18 , pakutakse mojitot


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
        */

            /*
             Näite programme 3 
            küsib  kasutajalt tema kasutaja nime. 
            küsib kasutajalt tema parooli.
            logib kasutaja sisse kui mõlemad on õiged.

            (eraldi failina githubis)
            //hint: &&
             */


        }
    }
}
