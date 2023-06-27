namespace Module_10_2_1
{
    public class NewMessenger : IWhatsApp, IViber //Используем явную реализацию интерфейса
    {
        void IWhatsApp.SendMessage(string messeger)
        {
            Console.WriteLine("{0} : {1} ", "WhatsApp", messeger);
        }

        void IViber.SendMessage(string messeger)
        {
            Console.WriteLine("{0} : {1} ", "Viber", messeger);
        }
    }
    public interface IWhatsApp
    {
        public void SendMessage(string messeger);

    }
    public interface IViber
    {
        public void SendMessage(string messeger);
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            NewMessenger newMessenger = new NewMessenger();

            ((IWhatsApp)newMessenger).SendMessage("Hello World!");
            ((IViber)newMessenger).SendMessage("Hello World!");

            Console.ReadKey();
        }
    }
}