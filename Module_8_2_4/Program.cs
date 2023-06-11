namespace Module_8_2_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                DirectoryInfo dirInfo = new(@"C://PrimerC#");
                dirInfo.Create();
                string trashPath = "C://PrimerC#2";
                dirInfo.MoveTo(trashPath);
            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.ToString());
            }
           
        }
    }
}