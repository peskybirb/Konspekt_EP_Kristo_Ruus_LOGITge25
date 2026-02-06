internal class Program
{
    private static void Main(string[] args)
    {
        List<float> graphData = new List<float>()
                {
                    3.6F ,
                    0 ,
                    4.5F ,
                    23.8F ,
                    106F ,
                    42.2F ,
                    0 ,
                    -5.2F ,
                    7F ,
                    0 ,
                    6F ,
                };
        int keskpunkt = 45;
        foreach (var unitOfData in graphData)
        {
            string displayableData = "";

            float calculatedData = keskpunkt + unitOfData;

            if (calculatedData < keskpunkt)
            {
                int i_i = 0;
                while (i_i < calculatedData)
                {
                    displayableData += "_";
                    i_i++;
                }
                //joonista kuni andmest arvuni 0 
                int i = (int)calculatedData;
                while (i < 0)
                {
                    displayableData += "H";
                    i++;
                }

                int j = 45;
                while (j < 90)
                {
                    displayableData += "_";
                    j++;
                }

            }
            else if (calculatedData > keskpunkt)
            {
                //joonista alates 0ist arvust andmeni 
                int j = 0;
                while (j < 45)
                {
                    displayableData += "_";
                    j++;
                }
            }
            else
            {
                int m = 0;
                while (m < 45)
                {
                    displayableData += "_";
                    m++;
                }
                // kui arv on 0 jookista joone element.
                displayableData = "X";
            }
            Console.WriteLine(displayableData);



        }
}
