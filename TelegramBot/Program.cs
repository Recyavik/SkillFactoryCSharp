using Telegram.Bot;

namespace TelegramBot
{
    internal class Program
    {
        public static class BotCredentials
        {
            public static readonly string BotToken = "6128456325:AAGTR7g68wJ3S8kCfv5tjSBW3bDNBaMWXjg";
        }
        static void Main(string[] args)
        {
            var botClient = new TelegramBotClient(BotCredentials.BotToken);
            var me = botClient.GetMeAsync().Result;
            Console.WriteLine("Привет! Меня зовут {0}.", me.FirstName);
        }
    }
}
