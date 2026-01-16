using System.ComponentModel.Design;
using System; //enne nimeruumi viidatakse selles failis / klassis kasutatud pakettidele moodulitele ja süsteemi muudele osadele, süsteemi muuks osaks võib olla kas OS võimalused või  ka teised projektid
             //teised projektid viidatakse tavaliselt solution failist

namespace esimeneprojekt;  // nimeruum, sissaldab loogeliste sulgude vahel konteinerit kus asub kogu programmi kood nimw all "esimeneprojekst".

internal class Program  //programmi klass, mis on ka omakorda konteineri tüüp , kus sees on kogu programmi kood.
{
    static void Main(string[] args) // "Main" on programmi ees olev meetod mis vaikimis käivitatakse kui ei ole teist meetodit määratud.
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
        
        
        int mingiarv = 4;

        mingiarv = mingiarv + 15;   //

        mingiarv = mingiarv - 15;   //

        mingiarv = mingiarv * 15;   //

        mingiarv = mingiarv / 15;   //


        mingiarv += 15;   //

        mingiarv -= 15;   //

        mingiarv *= 15;   //

        mingiarv /= 15;   //

          O M I S T U S    O P E R A A T O R I D 


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


         V Õ R D L U S    O P E R A A T O R I D 
        
        // == e. on võrdne on täpselt sama , ühel pool võrdusmärki olev objekt peab olema täpselt sama mis teisel pool võrdusmärki.

        // > e. "on suure kui" märgist vasakul pool olev objekt peab olema suurem kui paremalpool olev väärtus

        // < "on väiksem kui" märgist vasakul pool olev väärtus peab olema väiksem kui paremal pool olev väärtus

        // >= "on suurem, või võrdne" vasakul olev väärtus peab olema suure või võrdne paremal oleva väärtusega

        // <= "Väiksem kui, või võrdne"märgist vasakul pool olev objekt peab olema väiksem kui või sama suur kui paremal pool olev väärtus

        // != "ei tohi olla" võrdusmärgi vasakul pool ei tohi olla samasugust väärtust mis paremal pool ülejäänud väärtused on lubatud


        L O O G I L I S E D      O P E R A A T O R I D

        // && e. "AND" loogiline tehe, mida kasutatakse tingimuste kirjutamisel ning mis annab positiivse vastuse "true" juhul kui mõlemal pool märki "&&" olevad tingimused on tõesed
        (true + true = true)
        // || e. "OR" on loogiline tehe mis annab vastuse "true" kui ühel pool märki "||" on tehte tulemus true (True = True)

        // ! e. "NOT" on loogiline tehe, mida kasutatakse tingimuse , avaldise või tulemuse inventeerimiseks. (False = True || True = Falsse)

                         --      T I N G I M U S L A U S E      --
        
        if (true) { } //kaitstud sõna if kutsub esile tingimus lause mille tingimusavaldis on sellele järgnevatele sulgude vahel.järgneb loogeliste sulgude vahel koodi plokk mis teostatakse siis kui tingimuse avaldis annab tingimuse "true" . "False" tulemuse puhul jäetakse kood vahele

        else if (true) { } //kaitstud sõnad else ja if (koos else if) kutsuvad esile sekundaarse tingimuslause mille tingimus on samamoodi sellele  järgnevate sulgude vahel, ning millele peab alati eelnema kas if või teine else if.else if tingimust kontrollitakse ainult siis kui sellele eelnev tingimus tagastab avaldis tulemusena "false" minnakse edasi järgmise tingimuse juurde.

        else   // kaitstud sõna else kutsub esile järeltingimus lause, Millele peab eelnema alati kas if või else if tingimuslause. Ning mille koodiploki sisu täidetakse ila oma tingimuse avaldise kontrollita kuna else kasutatakse kõigi teiste tingimuste läbikukkumisel(kõik eelnevad tagastavad tulemuse false).
        
        //   - S Ü N T A K S -- */


        /*  Console.WriteLine("Ommik");
          string vastus = Console.ReadLine();
          Console.WriteLine(":3");


          // 1      2   3   4  5
          string näidis = "def";*/ //1 muutuja kirjutatakse alustades andmetüübist , ilma andmetüübita ei saa muutujat deklareerida. 
                                   //2 seejärele kirjutatkse muutuja nimi mis kirjeldab andmeid ja nende nende andme eesmärki
                                   //  soovitatakse kasutada muutujate nimetamisele cameCase stiili. esimene sõna on väikse tähega ja ülejäänud on suuretähega algavad.
                                   //3 omistusoperaator mis annab andmed sisse.
                                   //4 andmed mida omistatakse.
                                   //5 lauselõpumärk.

        // ;           - iga koodi lause koodiploki sees lõppeb lauselõpu märgiga.
        // Console     - Console on C# käsurea addreseerimise pakett millega saab erinevaid operatsioone teha.
        // .           - kasutatakse addresseerimiseks et saada punktile eelnevalt objektist mingisuguse meetod funktsiooni mis kirjutatakse pärast punkti 
        //               võib mõelda kui kaustas olevat / släshi.
        // WriteLine   - WriteLine on funktsiooon mida parasjagu kasutatakse . WriteLine kuvab käsureale teksti või kaasatud parameetreid
        // ()          - sulupaar mis omab funktsiooni tõõks vajaliku infot / parameetreid
        // {}          - loogelised sulud tähistavad koodi plokki konteineri jaoks.
        // []          - kantsulud tähistavad masiivi.
        // ""          - tähistavad sõne andmetüüpi andmeid, andmed ise asuvad jutumärkide vahel.
        // string      - andmetüüp mis kirjutatakse alati muutuja ette , andmetüüübis endas asuvad ka andmetüübile vajalikud funktsioonid.
        // "vastus"    - muutuja mille nimi on vastus mis omab string tüüpi andmeid.mis omistatakse sinna sisse omistusoperaatoriga.
        // ReadLine(); - ReadLine on funktsiooon mida parasjagu kasutatakse . ReadLine loeb käsurealt vaike tüüpi sõne väärtuseid.
        // //          - tähistab ühearealist kommentaari
        // /* */       - tähistab plokk kommentaari , kõik tärnide vahel on välja kommenteeritud
        // ///         - funktsiooni summery kommentaar , kirjeldab meetodit mille tekst kuvatakse välja tool tip-ina
        //             - taane - aitab arendajal aru saada kus kohas millise koodiploki sees kood parasjagu asub , ning aitab järgepidada.



        /*---------------------------------- näiteülesanne 4 ----------------------------------------*/

        /*
        // int muutuja = 0;

        Console.WriteLine("Palun sisesta oma vanus");
        int kasutajavanus = int.Parse(Console.ReadLine());

        Console.WriteLine("Palun sisesta oma vanavanaema vanus");
        int kasutajavanavanaemavanus = int.Parse(Console.ReadLine());

        //int vanustevahe = kasutajavanavanaemavanus - kasutajavanus;

        Console.WriteLine("Vannuste vahe hetkel on "+(kasutajavanavanaemavanus - kasutajavanus));
        Console.WriteLine("kui palju sa vanem oled ?");
        kasutajavanus += int.Parse(Console.ReadLine());
        Console.WriteLine("Vanuste vahe nüüd on "+(kasutajavanavanaemavanus - kasutajavanus));
      
        // Console.WriteLine("vanuste vahe ei muutu :3 silly "+((kasutajavanavanaemavanus + muutuja)-(kasutajavanus + muutuja)));
        
        
        */
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
        /*------------------ näite programm 5 -------------------*/
        /*
        Console.WriteLine("Kui kaugele oli su viimane kuulitõuge? (m)");
        float kaugus = float.Parse(Console.ReadLine());
        if (kaugus <= 1.00 && kaugus >= 0.00)
        {

            Console.WriteLine("when you try your best but you don't succeed");
        }
        else if (kaugus <= 2.00 && <= 1.01)
        {
            Console.WriteLine("natukene veel võibolla");
        }
        else if (kaugus <= 3.00 && kaugus >= 2.01)
        {
            Console.WriteLine("hell yeah broth tegid ära");
        }
        else if (kaugus < 0)
        {
            Console.WriteLine("Vale pool silly billy");
        }
        else 
        {
            Console.WriteLine("NAH sa defo oled cheatinud");
        }
         */

        /*----------------- Näite Programm 6 -----------------------*/
        /*
        Console.WriteLine("Palun sisesta oma vanus.NB! kirjuta täis arvuna!");
        int isikuvanus = 0;
        isikuvanus = int.Parse(Console.ReadLine());
        if (isikuvanus <= 0) 
        {
            Console.WriteLine("ajarändureid me ei teeninda!!!");
        }
        else if (isikuvanus > 0 && isikuvanus < 18)
        {
            Console.WriteLine("Palun sisesta oma nimi");
            string kasutajanimi = "";
            kasutajanimi = Console.ReadLine();
            Console.WriteLine($"Kallis {kasutajanimi} palun kutsu siia oma lapsevanem ");
        }
        else
        {
            Console.WriteLine("Palun kirjuta siia oma eesnimi");
            string eesnimi = "";
            eesnimi = Console.ReadLine();

            Console.WriteLine("Palun kirjuta siia ka oma perekonnanimi");
            string perekonnanimi = "";
            perekonnanimi = Console.ReadLine();
            if (eesnimi == "" || perekonnanimi == "")
            {
                Console.WriteLine("sisestama pidi mõlemad nimed :<");
            }
            else
            {
                Console.WriteLine($"Teretulemast {eesnimi} {perekonnanimi}");
            }

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

        // --------------- näiteülesanne 7 ---------------

        int minuArv = 9001;
        Console.WriteLine(minuArv);
        double minuDOuble = minuArv;
        Console.WriteLine(minuDOuble);


        double minuUuusDouble = 6.7;
            Console.WriteLine(minuUuusDouble);
        int minuUusArv = (int)minuUuusDouble;
        Console.WriteLine(minuUusArv);

    }
}
