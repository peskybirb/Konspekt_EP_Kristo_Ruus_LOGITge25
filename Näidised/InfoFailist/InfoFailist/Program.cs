using System.Text;

namespace InfoFailist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //try cahtch research
            //Tuple<int,List<string>,int,bool,string> player = new Tuple
            const string SaveGameLocation = "savegame.txt";
            if(File.Exists("savgame.txt"))
            {
                List<string> info = new List<string>();
                info.Add("_integer");
                info.Add("_List");
                info.Add("_anotherinteger");
                info.Add("_boolean");
                info.Add("_message");

                File.WriteAllText(SaveGameLocation, info);
            }
            else if(File.Exists(SaveGameLocation))
            {
                int elud = 0;

                string[] loadedFiles = File.ReadAllLines(SaveGameLocation);
                /*
                for (int i = 0; i < loadedFiles.Length; i++)
                {
                    string[] seeRida = loadedFiles[i].Split("_");
                    if(seeRida.Length <= 1)
                    {
                        loadedFiles[i] = string.Join('_', new string[] { seeRida[0], "_" }); //parse to int
                    }
                }
                */

                foreach (string rida in loadedFiles)
                {
                    string[] seeRida = rida.Split('_');
                    
                }
            }
        }
    }
}
