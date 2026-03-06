namespace FileWriterTutorial
{
    internal class Program
    {
        static void Main(string[] args)
        {

           

            if (File.Exists("KasutajaNimi.txt"))
            {
                string[] tervitus = File.ReadAllLines("kasutajaNimi.txt");
                Console.WriteLine(tervitus[0]);
            }
            else
            {
                Console.WriteLine("mis on su nimi");
                string vastus = Console.ReadLine();
                string vaste = "Tervetulemast " + vastus;
                File.WriteAllText("KasutajaNimi.txt", vaste);

            }
        }
    }
}
