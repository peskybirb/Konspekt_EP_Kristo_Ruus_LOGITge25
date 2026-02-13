using System.ComponentModel.Design;
using System;
using System.Net.Http.Headers; //enne nimeruumi viidatakse selles failis / klassis kasutatud pakettidele moodulitele ja süsteemi muudele osadele, süsteemi muuks osaks võib olla kas OS võimalused või  ka teised projektid
                               //teised projektid viidatakse tavaliselt solution failist

namespace esimeneprojekt;  // nimeruum, sissaldab loogeliste sulgude vahel konteinerit kus asub kogu programmi kood nimw all "esimeneprojekst".

internal class Program  //programmi klass, mis on ka omakorda konteineri tüüp , kus sees on kogu programmi kood.
{
    static void Main(string[] args) // "Main" on programmi ees olev meetod mis vaikimis käivitatakse kui ei ole teist meetodit määratud.
    {
        /* ------------------------Teooria-------------------------------
        //ctrl + k + c/u

        ---------  J U H U A R V  ---------
        
        //random klass annab võimaluse programmeerijale genereerida pseudo randdom väärtusi.
        Random juhuArv = new Random(); // klassinimi random on kasutatav kui andmetüüp, mis ütleb et jäegnevas muutujas nimega
                                       // juhuArv on uus random tüüpi objekt mis omistatakse sinna "new Random()"käsuga
                                       // konstruktor ulatab muutuja sisse random tüüpi klassi.random nüüd ise ei ole see
                                       // juhuarv, ta toimib kui juhuarvude genereetor 

        int miski = juhuArv.Next(-5, 5); // .Next on juhuarvu meetod mis on genereeriv meetod juhuarvu genereerimiseks seda
                                         // saab kasutada kui mingi väärtusena nng ta tagastab suvalise arvu
                                         // ilma väärtusetta tagastab andmetüübi maksimaal piirides mingisuguse juhuarvu
                                         // .Next ühe parameetriga anname talle ühe piiri mille alumine väärtus on 0 vaikimisi
                                         // kah väärtusega aga kirjeldab ära terve vahemiku võib olla nii negatiivne kui
                                         // ka positiivne
        int näidea = juhuArv.Next(7);
        int näideb = juhuArv.Next(-7, 7);
        double näidec = juhuArv.NextDouble();  //.NextDouble annab double tüüpi andmetüüpe 
        float näided = juhuArv.NextSingle();   //.NextSingle annab float tüüpi väärtuseid mis on vahemiks 0.0 - 1.0
        
        -------------------------------------
        

                --------- LIHT ANDMTÜÜBID --------- 
        
        string tekst = "mingisugune inimloetav tekst" //tekst
        char täht = 'A'; // üks täht '' vahele
        int arv = 1; //täisarv
        float komakohagaarv = 1.5f; //32bi
        double suuremakomakohagaarv = 1.5d; //64bit
        decimal kümendsüstemikomakohagaarv = 1.5M;
        var X = 123; //umbmäärane andmetüübiga ajutine muutuja
        var Y = "ABC";
        bool jahvõiei = false; //kas true või false.

        -----------------------------------------------------------
        // K O M P O S I I T   A N D M E T Ü Ü B I D

        //1.          ---------  M  A  S  I  I  V  --------- 
        /* MASSIIV */

        // [] massiiv on komposiit andmetüüp mille sees saab olla mitmeid samat tüüpi lihtandmeid . massiivi tähistatakse kant sulgudega 
        //massiive saab olla ükskõik millist lihtandmetüüpi andmeid . masiivi kirjutamisel pead ette ütlema kui pikk või suur see on.
        // kuigi massivis saab olla lihtandmetüübid , saab massiive moodustada ka teistest masiividest ja teistest komposiit andmetüüpidest 
        // kui omn massiiv mis koosneb teistest masiividest on tegu mitme dimensioniga masiiv . näiteks on 2
        // dimensiooniline massiiv , andmemasiiv mis koosneb kahest erinevast masiivist 
        /*
        //esimene tekitus viis 
        int[] uusMassiiv = new int[3]; // andmetüüp int väljendab et tegu on täisarvu tüüpi andmega mis on masiiv ja omab endas täisarve
                                       //muutuja nimi on uus massiiv ning võrdusmärgi järele omistatakse sinna uus massiiv kolme elemendiga 
                                       // kus mitte ükski element ühtegi väärtust hetkel ei oma , kui mitu elementi mahub on kantsulgude 
                                       // sees 

        // teine tekitus viis
        int[] uusMassiiv2 = [1, 2, 3]; //Teine massiiiv tekitus viis kus massiivi pikkuse asemel antakse kohe kaasa kindlate
                                       //väärtustega elemendid , massiivi pikkust määratlema ei pea kuna see tuletatakse elementide arvust.

        // massiiivi sisestatud meetodid - - 

        int kuiPaljuOn = uusMassiiv.Length;     //massiiivi meetod lenght mille saame kasutusele võtta punkti abli loendab
                                                //kokku mitu elementi massiivis on ja tagastab selle väärtuse . selles näites omistatakse 
                                                // tagastatav väärtusess kuiPaljuOn . Väärtus saab olla ainult täisarv , poolikuid
                                                // või osalisi elemente pole olemas.
        */

        //                ----------  L  O  E  N  D  -----------
        /*
        // list<T>    ---> loend on konposiit andmetüüp kus sarnaselt masiiviga saab olla mitmeid samat tüüpi andmeid.
        //                 list kirjutatakse kui oma andmetüüp kus sulgude vahel on loendis olevate elementide andmetüüp
        //                 samamoodi nagu massiive saab loendeid olla ükskõik mis lihtandmetüüpi , komposiitandmetüüpi
        //                 (ka teine list)
        //                 erinevalt masiivist aga ei pea ütlema kui pikk loend ise on . loendi eripära on see et teda
        //                 saab dünaamiliselt oma pikkuselt muuta ST et elemente saab eemaldada selle elemendi asukohaga.
        //                 masiiv on konstantse pikkusega ehk muutumatu ja ei saa ära võtta elemente selle kohaga.
        //                 listi üksikelemendi andmetüüp asub noolsulgude vahel "<>"kaitstud sõna "List" järel.


        // Esimene tekitus viis 

        List<int> arvuloend = new List<int>(); // andmetüübi kirjeldus lList<int> näite et tegu on andmetüübiga listis noolsulgude
                                               // vahel on andmete tüüp . antud juhul on need täisarvud.muutuja end animeks kus 
                                               // muutujaid hoitakse on arvuloaend sellesse loendisse omistatakse kaitstud
                                               // sõna new abil uus pikkuseta tühi loend täisarvudega.


        //Teine tekitus viis

        List<int> arvuloend2 = new List<int>() {1,2,3};  // andmetüübi kirjeldus lList<int> näite et tegu on andmetüübiga
                                                         // listis noolsulgude
                                                         // vahel on andmete tüüp . antud juhul on need täisarvud.muutuja
                                                         // enda nimeks kus muutujaid hoitakse on arvuloaend2 , Sellesse
                                                         // omistatakse uus ja tühi loend täisarvudega kuid pärast andmetüübi
                                                         // taga olevaid sulge anname loogelistesulgude vahel talle kaasa koha
                                                         // ka elemendid. antud juhul on tegu täisarvudega 1 , 2 ja 3 . enam
                                                         // ei ole tegu pikkusetta ega tühja loendiga vaid sarnaselt masiivile
                                                         // tekib selle loendi pikkus põhinedes sellel mitu elementi
                                                         // kaasa on antud.

        //kolmas tekitus viis 

        List<int> arvuloend3 = new List<int>(3);// andmetüübi kirjeldus lList<int> näite et tegu on andmetüübiga listis
                                                // noolsulgude
                                                // vahel on andmete tüüp . antud juhul on need täisarvud.muutuja
                                                // enda nimeks kus muutujaid hoitakse on arvuloaend3.
                                                // omistatakse uus ja tühi loend täisarvudega kuid loend omab kolem tühja elementi
                                                // arve ega väärtusi nende elementide sees veel ei ole .elementide arv
                                                // sätestatakse peale noolsuge olevate tavaliste sulgude vahele 

        //                     6
        List <bool> näidis2 = new List<bool>(); // 6 - kaitstud sõna new kasutatakse  siis kui tahetatakse instanseerida uute
                                                //     muutujasse väärtust mille andmetüüp on komplektsne ja vajab konsturuktori
                                                //     väljakutset . komplektsetel andmetüüpidel on tihti vaja sisemiselt
                                                //     ülesseehitada ennast teiste andmetüüpide põhjal

        */
        // ----------  S Õ N A S T I K  --------
        /*

        //Dictionary <T, T>     ---> Disctionary on komposiit andmetüüp mis omab võti väärtus paare erinevalt teistest
        //andmetüüpidest saab dictionary omada kahte erinevat andmetüüpi millest esimene väljendab võtme andmetüüpi ja teine
        //võtme taga oleva väärtuse andmetüüpi. Need andmetüübid saavad üksteisest erineda või isegi omada klasse andmetüüpidena.
        //ja ka muid komposiit andmetüüpe. 

        //esimene tekitus viis
        Dictionary<int, string> sõnastik = new Dictionary<int, string>();
        // andmetüübi kirjeldus dictionary näitab et tegu on sõnastikuga ehk loendiga võtiväärtus paaridest , dictionary
        // noolsulgude vahel asutatakse kaks andmetüüpi , esimene neist on võtme andmetüüp , antud juhul "int". Teine neist
        // on võtme taga oleva väärtuse  andmetüüp , antud juhul "string". muutuja nimeks on "sõnastik" kuhu
        // omistataksekäsusõnaga new uus tühi sõnastik vastavate andmetüüpidega. 


        Dictionary<int, string> sõnastikkaks = new Dictionary<int, string>() { {1, "Astelpaju" },{2, "muulukas" },{3, "Maasikas" } };
        // andmetüübi kirjeldus dictionary näitab et tegu on sõnastikuga ehk loendiga võtiväärtus paaridest , dictionary
        // noolsulgude vahel asutatakse kaks andmetüüpi , esimene neist on võtme andmetüüp , antud juhul "int". Teine neist
        // on võtme taga oleva väärtuse  andmetüüp , antud juhul "string". muutuja nimeks on "sõnastik" kuhu
        // omistataksekäsusõnaga new uus tühi sõnastik vastavate andmetüüpidega. uuus sõnastika koos elementidega mis
        // asuvad sulgude taga loogelistes sulgudes mille andme paarid asuvad omakorda loogeliste sulgude sees. 


        //Dictionary<List<int>, string> sõnastikKast = new Dictionary<List<int>, string>();

        // -- SÕNASTIKU TÖÖRIISTAD --

        //     -  .Add  -
        sõnastik.Add(4, "Tikker");
        //.add võimaldab olemasolevad sõnastikku lisada elemente selle sõnastik lõppu sulgude sees on andmed
        // mis vastavad lisatava dictionary andmetüübi sätestusele.


        //    -  .Remove   -
        sõnastik.Remove(2);
        //.Remove eemaldab kindla võtme järgi sõnastikus oleva elemendi. Sulgude vahel on selle võtme andmetüübile vastav
        //väärtus . Mitte võtme taga olev väärtus.

        //     -  .Clear  -
        sõnastik.Clear();
        // teeb sõnastiku täielikult tühjaks

        //     -  .ConstinasKey  -
        sõnastik.ContainsKey(2);
        //.ContainsKey tagastab kas true või false vastavalt sellele kas ta leiab antud sõnastikus parameetrina kaasaantud võtme.

        //     -  .ConsinsValue  -
        sõnastik.ContainsValue("Tikker");
        //contains value tagastab kas true või false vastavalt sellele kas ta leiab antud sõnastikus parameetrina
        //kaasaantud väärtuse.


        */
    // --------------------------------------

    // ----------  T U P L E  -----------









    // ----------------------------------
    /*
   //                 ------ K A I T S T U D  S Õ N A D -----

   //kaitstu dsõnad on kindlad sõnad mida C# kasutab oma koodistruktuuride tähistamiseks 
   //et ära hoida näpuga järge ajamist , ning kompilaatori töö lihtsustamisesks , ei saa järgnevaid sõnu muutuja nimetamiseks kasutada

   //    abstract    as           base       bool       break       byte        case
   //    catch       char         checked    class      count       continue    decimal
   //    default     delegate     do         double     else        enum        event
   //    explicit    extern       false      finally    fixed       float       for
   //    foreach     goto         if         implicit   in          int         interface
   //    internal    is           lock       long       namespace   new         null
   //    object      operator     out        override   params      private     protected
   //    public      readonly     ref        return     sbyte       sealed      short 
   //    sizeof      stackalloc   static     string     struck      switch      this
   //    throw       true         try        typeof     uint        ulong       unchecked 
   //    unsafe      ushort       using      virtual    void        volatile    while

   // ----------------------------------------------------------------------------------------------------
   /*
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

    //         ----- T I N G I M U S L A U S E    -IF/ELSE -    ------

   if (true) { } //kaitstud sõna if kutsub esile tingimus lause mille tingimusavaldis on sellele järgnevatele sulgude vahel.järgneb loogeliste sulgude vahel koodi plokk mis teostatakse siis kui tingimuse avaldis annab tingimuse "true" . "False" tulemuse puhul jäetakse kood vahele

   else if (true) { } //kaitstud sõnad else ja if (koos else if) kutsuvad esile sekundaarse tingimuslause mille tingimus on samamoodi sellele  järgnevate sulgude vahel, ning millele peab alati eelnema kas if või teine else if.else if tingimust kontrollitakse ainult siis kui sellele eelnev tingimus tagastab avaldis tulemusena "false" minnakse edasi järgmise tingimuse juurde.

   else   // kaitstud sõna else kutsub esile järeltingimus lause, Millele peab eelnema alati kas if või else if tingimuslause. Ning mille koodiploki sisu täidetakse ila oma tingimuse avaldise kontrollita kuna else kasutatakse kõigi teiste tingimuste läbikukkumisel(kõik eelnevad tagastavad tulemuse false).

   //         ----- T I N G I M U S L A U S E    -SWITCH/CASE -    ------
   */

    /*
    int option = 3;

    switch(option) {  //Switch on kaitstud sõna alternatiivselt tingimus kontrolli jaoks mida saab alternativvselt if else i asemel kasutada , Sulgude vahele käib 
                      //muutuja nimi , mille põhjal tingimuslik ümberlülitus toimub . Siin sulgude vahel ei ole tingimus ise, vaid kõigest kontrollitav muutuja
                      //või omakorda sulgude vahel muu tingimuse avaldis.pärast lülitusvalikut tuleb koodiplokk.

        case 1:       // koodiploki sees on erinevad juhtumid ja erinevad vasted , väärtuste korral mis võivad olla lülitusvalikus olema muutja sees 
                      //iga juhtum /vaste kirjutatakse kaitstud sõnada "Case" ning , ning väärtus selle järel millele see juhtum vastab.antud juhtul.
                      //see juhtum toimib, kui muutujas option on täisarv 1, peale võimallik väärtust on koolon väljendades juhtumi täitumisel tehtavat koodiplokki.

            Console.WriteLine("nope");
            break;
            case 2:  // juhtume võib olla mitmeid antud juhtul on siin näidises 3+1 , kolm kindlat väärtust ja üks vaike väärtus (ehk default)

            break;

            case 3:
            Console.WriteLine(option);  // antud juhtul kuvatakse muutujas option asuv väärtus välja 
            break;

        default:  //default juhtum täitub siis kui ülejäänud juhtumid ei kata switchi lülitusvalikus olevas muutujas asuvat väärtust
                  // toimib nag else , kuid erinevalt if elsei else struktuuist , võib default olla ka alguses.
            Console.WriteLine("best wishes stranger");
            break;    // Kui antud juhtumi tegevus on tehtud väljutakse mitte ainult juhtumist vaid ka kogu käesolevast switchcase tingimustikust
                      // peale breaki on lauselõpu märk.
    }
    */

    /*



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

    /* andmetüübi castimine e. teisendamine.


     //Castimine, on arvu teisendamine ühest andmetüübist teise. Castimist on kahte eri liiki , automaatne (implicit) ja automaatne (explicit) , 
    automaatne castimine toimub siis 
     // kui teisendatakse väiksemast andmetüübist suuremasse selliselt juhtul programmeerija spetsiifiliselt castima ei pea
     // manuaalne castimine toimub siis kui toimub castimine väiksemast andmetüüübist suuremasse , sellel juhtul on vaja panna muutuja ette sulupaar kui on soovitav andmetüüp sees.

    //manuaalne castimine

      double minuData1 = 1.23d;            // tekitatakse või onolemas double tüüpi andmed muutujas minuData1 
     float minuFloat1 = (float)minuData1; // toimub teisendaminne väiksemasse Float andmetüüpi suuremast double andmetüübist
     long minuLong1 = (long)minuData1;   // toimub teisendaminne väiksemasse long andmetüüpi suuremast float andmetüübist
     int minuInt1 = (int)minuLong1;     // toimub teisendaminne väiksemasse int andmetüüpi suuremast long andmetüübist
     char newChar1 = (char)minuInt1;   // toimub teisendaminne väiksemasse char andmetüüpi suuremast int andmetüübist

    //automaatne castimine

     int backtoint = newChar1;           //toimub automaat teisendus väiksemast char andmetüübist suuremasse int andmetüüpi
     long backtolong = backtoint;        //toimub automaat teisendus väiksemast int andmetüübist suuremasse long andmetüüpi
     float backtofloat = backtolong;     //toimub automaat teisendus väiksemast long andmetüübist suuremasse float andmetüüpi
     double backtodouble = backtofloat;  //toimub automaat teisendus väiksemast float andmetüübist suuremasse double andmetüüpi

    // suuremast andmetüübist castimisega väiksemassa andmetüüpi on andme resulutsioonil kadu ja andmeid ei saa tagasi kui castida tagasi suuremasse andmetüüpi.

    //       ------------  P A R S I M I N E  --------------

    // parsimine on tekstist katse teisendada mingit tüüpi arvandmeid . teisendus toimub küsides mingist andmetüübist  talle sisse ehitatud meetodi Parse() abil mingist sõnest arvandmeid

    string seenontekst = "1";                    // mingisugune sõne mis omab endas mingit potensiaalset arvväärtust
    int teisendatud = int.Parse(seenontekst);   // muutuja "teisendatud" kuhu omistatakse Parse() meeetodi abil sõnest arvväärtus 
    Console.WriteLine(teisendatud);            // teisenduse väljakuvamine.


    // Parsimisel on ka alternatiivne meetod "TryParse()" tryparse üritab teisendada ning kui teisendus kukub läbi, tagastatakse algne väärtus/false

    string seenontekst2 = "2";                     // mingisugune sõne mis omab endas mingit potensiaalset arvväärtust     
    int teisendatud2 = int.Parse(seenontekst2);    // muutuja "teisendatud2" omab potensiaalset muutujat 
    Console.WriteLine(teisendatud2);               // teisenduse väljakuvamine

    //converteerimine on mingisuguse andme otsene teisendus ükskõik mis teise andmetüüpi. Selle jaoks on olemas moodul "Convert" 
    //Convert moodulis on sarnaselt arvandmetüüpides olevale ToString() meetodile ka muude andmetüüpide vastavad konventermismeetodid.

    var mingiInfo = "6.7";                                    //teisendamist vaja info
    string mingiInfoTekst Convert.ToString(mingiInfo);        // convert teisendab mingist tundmatust andmetüübist ifo strngiks /sõneks
    char mingiInfoChar; Convert.ToChar(mingiInfo);            // teisendus täheks 
    int mingiInfoInt; Convert.ToInt32(mingiInfo);             // teisendab int andmetüübiks
    long mingiInfoLong; Convert.ToInt64(mingiInfo);           // teisendab Long andmetüübiks 
    decimal mingiInfoDecimal; Convert.ToDecimal(mingiInfo);   // teisendab decimaliks
    double mingiInfoDouble; Convert.ToDouble(mingiInfo);      // teisendab double andmetüübiks
    byte mingiInfoByte; Convert.ToByte(mingiInfo);            // teisendab baidiks
    bool mingiInfoBool; Convert.ToBoolean(mingiInfo);         // teisendab Boolean andmetüübiks

    //  ---------------------- T S Ü K L I D ------------------
    /*
    // truslid on programmeerimises viis kuidas automatiseerida korduv tegevus ära , see aitab hoida andmmahtu kokku . programeerija sama 
    //koodi mitu korda kirjutamisest, ning väldib ka korduvatest tekkinud vigu. C# on neli peamis tsükli liiki -

    // tsüklitel on 3 peamist komponenti - käsklus ise , tsükli tingimus ja tehtav kood
    // do-while
    // while
    // for 
    // foreach
    */
    // ------------------   D O   W H I L E    -------------------
    /*
    //1.do-while   // erineb kõigist teistest sellega et tingimuste kontroll toimub pärast esimese tegevuse ringi kõikide teistes tsüklitestoimub
                   // tingimuste kontroll enne esimest ringi


                int tsüklimuutuja = 0;                  //mingisugune muutuja mis omab tsükli töö tingimusabil kontrollimiseks vajalikku väärtust e. tsüklimuutujat
                do                                      // do on kaitstud sõna mis alustab do while tsüklit , sellele järgne tsüklis tehtav                                        // koodiplokk ning mis esimene ring täidetakse ilma tingimuse kontrollita
    {

                 Console.WriteLine(tsüklimuutuja);      //koodiploki sees olev tegevus, antud juhul kuvatakse tsüklimuutuja arv välja                     
                tsüklimuutuja++;                        //ning tsüklimuutujat suurendatakse
        // ILMA TSÜKLIMUUTUJA kaasmata käib tsükkel lõpmatult
    }           while  (tsüklimuutuja != 5 );           // while on kaitstud sõna mis do while tsükli lõpetab, pärast seda toimub esimenne tingimuskontroll kus kontrollitakse
                                                        // tsükli tööse kaasatud olukorda , kui tingimus täitub e. true , täidetakse veel 1 ring ning täidetakse veel 1 ring
                                                        // ning kontrollitakse tingimust uuesti.antud juhul tsükkel toimib niikaua kuni tsükli muutuja ei ole 5.
    */

    //        ----------------------   W H I L E    -------------------
    /*
    //2.while
    // "While" tsükkel on kõige tüüpilisemat laadi tsükkel , tal on tingimuse kontroll esimese ringi alguse. kuid tsükkel ei
    // oma sisse ehitatud tsükkli muutujat , selle peab sätestama programmeerija  
    string tsüklimuutuja2 = "";
    while (tsüklimuutuja2 != "0")   // while on kaitstud sõna mis alustab while tsükkli, sellele järgneb sulgude
                                    // vahel olev tingimuse kontroll , kus kontrollitakse tsüklimuutuja hetke seisu ning kui avaldis
                                    // tagastab true , tsükkel töötab veel ühe ringi. kui tingimus ei täitu siis ei täiteta
                                    // ka järgnevat ringi ja tsükli töö katkeb . Antud juhul kontrollitakse et tsükli muutuja ei oleks
                                    // võrdne sõne muutujaga kus on tähemärk arvu 0 kohta.
    {
        Console.WriteLine("esita tekst: ");   // koodiploki "{}" sees olev tegevus , antud juhul küsitakse kasutajalt et sisestada tekst 
        tsüklimuutuja2 = Console.ReadLine();  // mis seejärel omistatakse tsüklimuutuja sisse.
    }
    */


    //            --------------------- F O R -------------------- 
    /*
    //3.for 
    int[] arvuMasiiv = new int[5];      // muutuja kus on andmed , mida tsükkel läbi töötleb (array)
     // for tsükkel võrreldes eelnevatega omab endas tsükli töö edasi viimiseks tsükli  enda sätestuste sees peale tingimus kontrolli 
     // ka iseenda tsüklimuutujat, ning selle iseenda tsüklimuutuja muutmist . 
    for(int k = 0; k < arvuMasiiv.Length; k++)    // kaitstud sõna for alustab for tsükkli, pärast mida on sulud mille vahel on
                                                  // kõik tsükli töö jaoks vajalik , esimene parameeter tekitab tsükli töö jaoks
                                                  // kohalik muutuja - tsükli muutuja ei eksisteeri väljaspool tsükli konteksti, 
                                                  // selle sätestuses on int k kohalik muutuja "int k = 0;" 
                                                  // teine parameeter on tsükli töö kontrollimiseks vajalik tingimuse kontroll
                                                  // samamoodi nagu while või do while juures tingimuse täitumisel tsükkel teeb ühe ringi
                                                  // miite täitumisel tsükkel katkeb. Kolmas parameeter on tsüklimuutuja muutmine selles
                                                  // näiteks kiirtehtega ++ inkrementeeritakse , on võimalik ka muud funktsiooni kasutada
                                                  // iga for tsükkli parameeter on tegelikus oma täielik koodilause seega
                                                  // eraldatakse sulgude vahel lauselõpu märgiga väljaarvatud viimane , viimase
                                                  // lõpetab sulg ")"
                                                  // sulgudele järgneb koodi plokk {} . 
    {
        Console.WriteLine("sisesta "k". arv");   // tegevus koodiploki sees us küsitakse kasutades tsüklimuutujat , kasutajalt järgmist/
                                                 // mingindat arvu.
        arvuMasiiv[k] = int.Parse(Console.ReadLine()); // kasutades tsüklimuutujat täidetakse massiiv 
    }

    */
    //        -------------------- F O R E A C H ---------------------
    /*
    //4.foreach  tsükkel võrreldes for tsükkliga ei oma mitut parameetrit aga kindalat funktsiooni kontrollivust.
    //koos iga elemendi jaoks tekitatava muutujaga for each tsükkel käib nii kaua kuni elemendid pole otsa saanud
    //foreach tsükkli tööd saab kontrollida ainult läbiselle töödeldava kollektsiooni enda ST seda et tsükli muutuja on 
    //kollektsiooni elementide arv , selle tsükli joks ei tekitata eraldi muutujat.

    List<string> sõnad = new List<string>() { "maasikas", "muulukas", "mustikas" };

    foreach (var üksSõna in sõnad)   //kaitstud sõna "foreach" alustab foreach tsükkli pärast mida on sulud mille vahel on 
                                     //tsükkli töö kontrolliv tingimus selle tingimuse sees tekitatakse ajutine muutuja
                                     //andmetüübiga var töödeldava elemendi üksikelemendi jaoks. Tingimuse keskel on järgmine 
                                     //kaitstud sõna "in" mis kontrollib et tsükkel töötals selle elemendi jaoks. Peale ühte 
                                     //ringi vaadatakse kas element on järgi kui on omistatakse nüüd muutujasse järgmine element ning tsükkel käib veel ühe ringi 
                                     // kui aga elemente veel ei ole tsükkel lõppeb . tsükkli tööd saaab kontrollida näiteks
                                     //kontrollitava kollektsiooni suurendamisega . tsükklil ei ole tsükli muutujat kuna 
                                     //tsükkel töötab kollektsiooni järgi. peale sulge on koodiplokk kus tehakse mingi tegevus
    {
        Console.WriteLine(üksSõna);  //antud juhul kuvatakse element välja

    }
    //NB! tsükkli töö ei pea olema ültse seotud kollektsiooniga , kollektsiooni
    //ise võib olla ainult tsükkli muutuja eesmärgil sätestatud
    */




    //-------------------  T E O O R I A   L Õ P P  ------------------

    ALGUS:
        Console.Clear();

        Console.WriteLine("Avamenüü :>");
        Console.WriteLine("1.Näiteprogramm 1");
        Console.WriteLine("2.Näiteprogramm 2");
        Console.WriteLine("3.Näiteprogramm 3");
        Console.WriteLine("4.Näiteprogramm 4");
        Console.WriteLine("5.Näiteprogramm 5");
        Console.WriteLine("6.Näiteprogramm 6");
        Console.WriteLine("7.Näiteprogramm 7");
        Console.WriteLine("8.Näiteprogramm 8");
        Console.WriteLine("9.Näiteprogramm 9");        
        Console.WriteLine("10.Näiteprogramm 10");
        Console.WriteLine("11.näiteprogramm 11");
        Console.WriteLine("exit.Sulge programm");


        string Valik = "";
        Valik = Console.ReadLine();
        
        switch (Valik)
        {


            default:
                Console.WriteLine("Ei ole valikus");
                Thread.Sleep(3000);
                goto ALGUS;
                break;
            //        -----------------------   näiteprogramm 1   -------------------------


            case "1":

                Console.Clear();
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
        Console.WriteLine(kontojääk + " puulehte on alles.");

        Console.WriteLine("Palusn sisesta oma hästi tehtud töö boonus");
        int boonus = int.Parse(Console.ReadLine());
        kontojääk = kontojääk + boonus;
        Console.WriteLine("sinu lõppväjavõte on " + kontojääk + " puulehte");

                Thread.Sleep(3000);
                Console.WriteLine("Vajauta enter et minna tagai avalehele");
                Console.ReadLine();
                goto ALGUS;
                break;
            //        -----------------------   näiteprogramm 2   -------------------------

                /*
                * klient tahab et programm teeks: 
                * programm küsib kasutajalt tema vanust
                * kui ta on noorem kui 18 öeldakse kasutajale "alaealisi sisse ei lasta"
                * kui on vanem kui 18, pakutakse mojitot
                */

            case "2":
                Console.Clear();
                int kasutajaVanus = 0; 
        Console.WriteLine("Kui vana sa oled?");
        kasutajaVanus = int.Parse(Console.ReadLine());
        if (kasutajaVanus >= 18)
        {
            Console.WriteLine("Tere, siin on sinu mojito 🍹");
        }
        else 
        {
            Console.WriteLine("Alaealisi sisse ei lasta, mine vembutembumaale. 🤡");
        }

                Thread.Sleep(3000);
                Console.WriteLine("Vajauta enter et minna tagai avalehele");
                Console.ReadLine();
                goto ALGUS;
                break;



            //        -----------------------   näiteprogramm 3   -------------------------

            /*
             Näite programme 3 
            küsib  kasutajalt tema kasutaja nime. 
            küsib kasutajalt tema parooli.
            logib kasutaja sisse kui mõlemad on õiged.

            (eraldi failina githubis)
            //hint: &&
             */

            case "3":
                Console.Clear();
                string KasutajaNimi = "";
                string KasutajaParool = "";


                Console.WriteLine("Palun sisesta oma kasutajanimi");
                KasutajaNimi = Console.ReadLine();

                Console.WriteLine("palun sisesta oma parool");
                KasutajaParool = Console.ReadLine();

                if (KasutajaNimi == "User1" && KasutajaParool == "qwerty")
                {
                    Console.WriteLine("Tere tulemast "+KasutajaNimi+", olete edukalt sisse logitud");  
                }
                else
                {
                    Console.WriteLine("Kasutajanimi või parool pole õige, Sissepääs on keelatud");
                }

                Thread.Sleep(3000);
                Console.WriteLine("Vajauta enter et minna tagai avalehele");
                Console.ReadLine();
                goto ALGUS;
                break;

            /*---------------------------------- näiteülesanne 4 ----------------------------------------*/

            case"4":
                Console.Clear();
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

                Thread.Sleep(3000);
                Console.WriteLine("vajauta enter et minna tagai avalehele");
                Console.ReadLine();
                goto ALGUS;
                break;


                /*------------------ näite programm 5 -------------------*/
                
                case"5":
                Console.Clear();
                Console.WriteLine("Kui kaugele oli su viimane kuulitõuge? (m)");
                float kaugus = float.Parse(Console.ReadLine());
                if (kaugus <= 1.00 && kaugus >= 0.00)
                {

                    Console.WriteLine("when you try your best but you don't succeed");
                }
                else if (kaugus <= 2.00 && kaugus >= 1.01)
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

                Thread.Sleep(3000);
                Console.WriteLine("vajauta enter et minna tagai avalehele");
                Console.ReadLine();
                goto ALGUS;
                break;

                /*----------------- Näite Programm 6 -----------------------*/
                
                case"6":
                Console.Clear();
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

                Thread.Sleep(3000);
                Console.WriteLine("vajauta enter et minna tagai avalehele");
                Console.ReadLine();
                goto ALGUS;
                break;




            // --------------- näiteülesanne 7 ---------------
            /*
            int minuArv = 9001;
            Console.WriteLine(minuArv);
            double minuDOuble = minuArv;
            Console.WriteLine(minuDOuble);


            double minuUuusDouble = 6.7;
                Console.WriteLine(minuUuusDouble);
            int minuUusArv = (int)minuUuusDouble;
            Console.WriteLine(minuUusArv);


            // castimise näide
            double minuData1 = 1.23d;
            float minuFloat1 = (float)minuData1;
            long minuLong1 = (long)minuData1;
            int minuInt1 = (int)minuLong1;
            char newChar1 = (char)minuInt1;

            int backtoint = newChar1;
            long backtolong = backtoint;
            float backtofloat = backtolong;
            double backtodouble = backtofloat;
            */
            case "7":

                Console.Clear();
                Console.WriteLine("Palun sisestage esimene arv");
                float Arv1 = 0;
                Arv1 = float.Parse(Console.ReadLine());

                Console.WriteLine("Palun sisestage teine arv");
                float Arv2 = 0;
                Arv2 = float.Parse(Console.ReadLine());


                Console.WriteLine("Mis tehet sa teha soovid?(+ , - , / , * , ^ , V)");
                string TehteTüüp = "";
                TehteTüüp = Console.ReadLine();
                double TehteTulemus = 0;

                if (TehteTüüp != "")
                {


                    switch (TehteTüüp)
                    {

                        case ("+"):

                            TehteTulemus = Arv1 + Arv2;

                            break;


                        case ("-"):

                            TehteTulemus = Arv1 - Arv2;

                            break;

                        case ("*"):

                            TehteTulemus = Arv1 * Arv2;

                            break;

                        case ("/"):

                            TehteTulemus = Arv1 / Arv2;

                            break;

                        case ("^"):

                            TehteTulemus = Math.Pow(Arv1, Arv2);

                            break;

                        case ("V"):

                            TehteTulemus = Math.Pow(Arv1, 1 / Arv2);

                            break;

                        default:

                            Console.WriteLine("Tehtetüüp pole valitud, tehet ei sooritata.");

                            return;
                    }
                    Console.WriteLine($"tehte tulemus on {Arv1} {TehteTüüp} {Arv2} = {TehteTulemus} ");
                }
                else 
                {
                    Console.WriteLine("Tehtetüüp pole valitud, tehet ei sooritata.");
                }

                Thread.Sleep(3000);
                Console.WriteLine("vajauta enter et minna tagai avalehele");
                Console.ReadLine();
                goto ALGUS;
                break;


            // ---------------------- the hell version. --------------------------------

            /*
            Console.WriteLine("Palun sisestage esimene arv");
            float Arv1 = 0;
            Arv1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Palun sisestage teine arv");
            float Arv2 = 0;
            Arv2 = float.Parse(Console.ReadLine());


            Console.WriteLine("Mis tehet sa teha soovid?(+ , - , / , * , ^ , V)");
            string TehteTüüp = "";
            TehteTüüp = Console.ReadLine();
            double TehteTulemus = 0;

            if (TehteTüüp != "")
            {


                if (TehteTüüp == "+")
                {
                    TehteTulemus = Arv1 + Arv2;
                    Console.WriteLine($"tehte tulemus on {Arv1} {TehteTüüp} {Arv2} = {TehteTulemus} ");
                }
                else if (TehteTüüp == "-")
                {
                    TehteTulemus = Arv1 - Arv2;
                    Console.WriteLine($"tehte tulemus on {Arv1} {TehteTüüp} {Arv2} = {TehteTulemus} ");
                }
                else if (TehteTüüp == "*")
                {
                    TehteTulemus = Arv1 * Arv2;
                    Console.WriteLine($"tehte tulemus on {Arv1} {TehteTüüp} {Arv2} = {TehteTulemus} ");
                }
                else if (TehteTüüp == "*")
                {
                    TehteTulemus = Arv1 * Arv2;
                    Console.WriteLine($"tehte tulemus on {Arv1} {TehteTüüp} {Arv2} = {TehteTulemus} ");
                }
                else if (TehteTüüp == "/")
                {
                    TehteTulemus = Arv1 / Arv2;
                    Console.WriteLine($"tehte tulemus on {Arv1} {TehteTüüp} {Arv2} = {TehteTulemus} ");
                }
                else if (TehteTüüp == "^")
                {
                    TehteTulemus = Math.Pow(Arv1, Arv2);
                    Console.WriteLine($"tehte tulemus on {Arv1} {TehteTüüp} {Arv2} = {TehteTulemus} ");
                }
                else if (TehteTüüp == "V")
                {
                    TehteTulemus = Math.Pow(Arv1, 1 / Arv2);
                    Console.WriteLine($"tehte tulemus on {Arv1} {TehteTüüp} {Arv2} = {TehteTulemus} ");
                }
                else
                {
                    Console.WriteLine("Tehtetüüp pole valitud, tehet ei sooritata.");
                }
            }

            */

            // -------------- näiteülesanne 8 ------------

            // Kirjuta programmis mis 
            // küsib kasutajatelt pikkust  sentimeetritest
            // küsib teiste pereliikmete pikkust 
            // programm arvutab välja perekonna keskmise pikkuse
            // vanemate keskmise pikkuse , laste pikkuse , ja mõlema vahe
            // kõik arvud programmis peab esitama komakohtadega arvudega



            //me fix later   *fixed 25.01.26
            case "8":
                Console.Clear();
                    List<int> vanused = new List<int>();
                    List<string> isikud = new List<string> () {"sinu", "oma venna", "oma isa", " oma ema"};
                    int i = 0;
                    do
                    {
                        Console.WriteLine("Sisesta "+isikud.ElementAt(i)+" pikkus sentimeetrites");
                        //kuvame kasutajale teate koos isikuga mida addresseritakse tsüklimuutuja abil järjendist "isikud"
                        vanused.Add(int.Parse(Console.ReadLine()));
                        //.add on listi meetod elemendi lisamiseks. lisatakse parsitud täisarv käsurea pealt
                        i++;
                        // lisatakse i muutujasse 1 
                    }
                    while (i < isikud.Count);

                    float perekonnakeskmine = ((float)(vanused.ElementAt(0)+ vanused.ElementAt(3) + vanused.ElementAt(1) + vanused.ElementAt(2)) /4)/100;
                    float Vanematekeskmine = ((float)(vanused.ElementAt(3) + vanused.ElementAt(2)) /2)/100;
                    float lastekeskmine = ((float)(vanused.ElementAt(0) + vanused.ElementAt(1)) /2)/100;
                    float Vahe = 0;
                    if (Vanematekeskmine > lastekeskmine)
                    {
                        Vahe = Vanematekeskmine - lastekeskmine;
                    }
                    else
                    {
                        Vahe = lastekeskmine - Vanematekeskmine;
                    }
                    Console.WriteLine("perekonna keskmine on "+Math.Round(perekonnakeskmine,2)+" m. vanematekeskmine on "+Math.Round(Vanematekeskmine,2)+" m. Lastekeskmine on "+Math.Round(lastekeskmine, 2) +" m. kahekeskmine vahe on "+Math.Round(Vahe, 2) +" m. ");

                Thread.Sleep(3000);
                Console.WriteLine("vajauta enter et minna tagai avalehele");
                Console.ReadLine();
                goto ALGUS;
                break;
                // näiteülesanne 9 - sünoptiku sõnus 

                /*
                // kirjuta programm mis küsib kasutajalt ilma prognoosi viie jägmise päeva temperatuur ja ilmakirjeldus 
                //kui sünoptik on sisestuse lõpetanud , kuva viie päeva mõlemad temperatuur ning ilma kirjeldus koos


                */
            case "9":
                Console.Clear();
                // FIX ME LATER 

                /*

                Console.WriteLine("tere sünoptik, ");
                float temps = new float[5];          // temperatuuri massiiv .
                string kirjeldus = new string[5];  // kirjelduse massiiv .

                for (int i = 0; i < temps.Lenght; i++)  // võtame sünoptikust temperatuuri andmed üksvaahavl .
                {
                    Console.WriteLine("Esita palun järgmine temperatuur");
                    temps[i] = float.Parse(Console.ReadLine());
                }                for (int i = 0; i < kirjeldus.Lenght; i++)  // võtame sünoptikust päeva kirjelduse andmed üksvaahavl .
                    // kirjelda ka eesolev nädal
                { 
                    Console.WriteLine("Kirjelda "+(i+1)+" päeva ");
                    temps[i] = float.Parse(Console.ReadLine());
                }
                Console.WriteLine("Palun esita uudisejaamale ilmateade: ");
                for(int i = 0; i < temps.Lenght; i++)
                {
                Console.WriteLine((i+1)+", Päeval on temperatuur " + temps[i]+" kraadi j ilm on "+ kirjeldus[i] + " .");
                }

                */

                Thread.Sleep(3000);
                Console.WriteLine("vajauta enter et minna tagai avalehele");
                Console.ReadLine();
                goto ALGUS;
                break;

            case "10":

                Console.Clear();
                //////////////////////    -------  PLEASE FIX ME LATER fr  -------- 
                

                //andmed mida soovitakse graafikus näidata
                List<float> graphData = new List<float>()
                {
                    -3.6F ,  // negatiivne
                    0 ,      // null
                    4.5F ,
                    23.8F ,
                    106F ,   // max value
                    42.2F ,
                    0 ,
                    -5.2F ,
                    7F ,
                    0 ,
                    6F ,
                    
                };
                // graafiku joonistamise jaoks vajalikud andmed (keskpunt)
                int keskpunkt = 45;
                foreach (var unitOfData in graphData)
                {
                    // kuvatav rida hetkel tühi
                    string displayableData = "";

                    // arvutatud andmed keskpunkti suhtes
                    float calculatedData = keskpunkt + unitOfData;

                    //while tsükkli muutuja
                    int o = 0;

                    while (o < 90) // tsükkel töötab niikaua kuni i ei ole 90 ega suurem
                    {
                        int sm0 = (int)(45 + unitOfData);
                        if (0 >= o && o < sm0) //kui "o" on vahemikus 0 aj sm0
                        {
                            displayableData += "▓";   //siis joonistame tumade tähemärgi
                        }
                        else if (sm0 >= o && o < 45)
                        {
                            displayableData += "▓";
                        }
                        else if (sm0 >= o && o < 90)
                        {
                            displayableData += "█";
                        }                        
                        else if (45 >= o && o < sm0)
                        {
                            displayableData += "█";
                        } 
                        else if (o >= sm0 && o < 45)
                        {
                            displayableData += "▓";
                        }
                        else
                        {
                            displayableData += "X";
                        }
                            o++;
                    }
                    
                    Console.WriteLine(displayableData);

                    //   Console.WriteLine(unitOfData);


                }


                ///////////////////////
                Thread.Sleep(3000);
                Console.WriteLine("vajauta enter et minna tagai avalehele");
                Console.ReadLine();
                goto ALGUS;
                
                break;
                

            case "exit":
                Console.Clear();
                Console.WriteLine("Programm sulgeb mõne sekundi pärast");
                Thread.Sleep(2500);
                Environment.Exit(0);
                break;

                




        }    

}
}
