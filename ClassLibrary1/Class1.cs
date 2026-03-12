namespace ClassLibrary1
{
    public class Class1
    {
        public Class1(string messageasstring)
        {
            MsgForUser = messageasstring;
        }
        public string MsgForUser { get; set; } = "HEllololo";
        public void WhatsTheWord()
        {
            Console.WriteLine(MsgForUser);
        }
    }

}
