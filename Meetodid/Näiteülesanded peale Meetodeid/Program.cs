namespace Näiteülesanded_peale_Meetodeid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
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

                        TehteTulemus = Liitmine(Arv1, Arv2);

                        break;


                    case ("-"):

                        TehteTulemus = Lahutamine(Arv1, Arv2);

                        break;

                    case ("*"):

                        TehteTulemus = Korrutamine(Arv1, Arv2);

                        break;

                    case ("/"):

                        TehteTulemus = Jagamine(Arv1, Arv2);

                        break;

                    case ("^"):

                        TehteTulemus = Astendamine(Arv1, Arv2);

                        break;

                    case ("V"):

                        TehteTulemus = Juurimine(Arv1, Arv2);

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

        }
        */

            /*
            Console.WriteLine("Sisesta oma nimi");
            string kasutajanimi = GetAnswer();
            Console.WriteLine("Tere " + kasutajanimi);
            Console.WriteLine("palun sisesta ka oma tänava nimi");
            string TänavaNimi = GetAnswer();
            Console.WriteLine(kasutajanimi+ " Tere elad "+TänavaNimi+" tänaval");
            */

            int Vanus = 0;
            Console.WriteLine("Kui vana sa oled ?");
            Vanus = int.Parse(Console.ReadLine());

            Vastus;





        }

private static void Vastus(int Vanus)
        {
            Console.WriteLine("kui vana sa oled_");
            string vanus = GetAnswer();
            int arvuvanus = int.Parse(Vanus)
          if(arvuvanus >= 65)
            {
                Console.WriteLine("Kuidas jalad käivad?");
            }
            else
            {
                Console.WriteLine("Kui palju monsterit läks täna ?");
            }

        }


private static string GetAnswer()
        {
            string input = "";
            do
            {
                Console.WriteLine("Palun sisesta: ");
                input = Console.ReadLine();
            } while(input == "");
            return input;
        }

        private static double Juurimine(float arv1, float arv2)
        {
            return arv1 * arv2 * arv1;  
        }

        private static double Astendamine(float arv1, float arv2)
        {
            return Math.Pow(arv1, arv2);
        }

        private static double Jagamine(float arv1, float arv2)
        {
            return arv1 / arv2;
        }

        private static double Korrutamine(float arv1, float arv2)
        {
            return arv1 * arv2;
        }

        private static double Lahutamine(float arv1, float arv2)
        {
            return arv1 - arv2;
        }

        private static double Liitmine(float arv1, float arv2)
        {
            return arv1 + arv2;
        }
    }
}
