internal class Program
{
    private static void Main(string[] args)
    {
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
}
}
