using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DiscordWebhookSpammer
{
    public class Program
    {
        static void Main()
        {
            string webhook, webhookname, message;
            int spamcount;
            Console.WriteLine("Welcome Mixy Discord Webhook Spammer.", Console.ForegroundColor = ConsoleColor.Red);
            Console.WriteLine("Enter your webhook.", Console.ForegroundColor = ConsoleColor.Yellow);
            webhook = Console.ReadLine();
            Console.WriteLine("Enter your webhook name.");
            webhookname = Console.ReadLine();
            Console.WriteLine("Enter message.");
            message = Console.ReadLine();
            Console.WriteLine("Enter how many times do you send a message.");
            spamcount = Convert.ToInt32(Console.ReadLine());
            Console.ResetColor();
            for (int i = 0; i < spamcount; i++)
            {
                Thread.Sleep(2000);
                Discord.Send(message, webhook, webhookname, "");
                Console.WriteLine(i.ToString(), Console.ForegroundColor = ConsoleColor.Cyan);
            }
            Console.ReadKey();
        }
    }

    public class Discord
    {
        public class Http
        {
            public static byte[] Post(string url, NameValueCollection pairs)
            {
                using (WebClient webClient = new WebClient())
                    return webClient.UploadValues(url, pairs);
            }
        }
        public static void Send(string content, string webHookUrl, string username, string avatarUrl)
        {
            Http.Post(webHookUrl, new NameValueCollection()
            {
                {
                    "content", content
                },

                {
                    "username", username
                },

                {
                    "avatar_url", avatarUrl
                }

            });
        }
    }
}
