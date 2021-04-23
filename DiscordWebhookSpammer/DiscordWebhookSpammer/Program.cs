using System;
using System.Threading;
using System.Collections.Specialized;
using System.Net;

namespace DiscordWebhookSpammer
{
    public class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome Mixy Discord Webhook Spammer.", Console.ForegroundColor = ConsoleColor.Red);
            Console.WriteLine("Enter your webhook.", Console.ForegroundColor = ConsoleColor.Yellow);
            var webhook = Console.ReadLine();
            Console.WriteLine("Enter your webhook name.");
            var webhookname = Console.ReadLine();
            Console.WriteLine("Enter message.");
            var message = Console.ReadLine();
            Console.WriteLine("Enter how many times do you send a message.");
            var spamcount = Convert.ToInt32(Console.ReadLine());
            Console.ResetColor();
            for (int i = 0; i < spamcount; i++)
            {
                Send(message, webhook, webhookname);
                Console.WriteLine(i.ToString(), Console.ForegroundColor = ConsoleColor.Cyan);
                Thread.Sleep(2000);
            }
            Console.WriteLine("Finish!")
            Console.ReadKey();
        }
        
        public static void Send(string content, string webhookUrl, string username)
        {
            wc.UploadValues(webhookUrl, new NameValueCollection()
            {
                {
                    "content", content
                },
                {
                    "username", username
                },
            }
        }
    }
}
