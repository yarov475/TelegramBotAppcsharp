using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;
using Telegram.Bot;
using TelegramBotAppcsharp.Models.Commands;
namespace TelegramBotAppcsharp.Models
{
    public static class Bot
    {
        private static TelegramBotClient client;
        private static List<Command> CommandsList;
        public static IReadOnlyList<Command> Commands { get => CommandsList.AsReadOnly(); }
        public  static async Task<TelegramBotClient> Get()
        {
        if(client != null)
            {
            return client;
            }
            CommandsList = new List<Command>();
            CommandsList.Add(new HelloCommand());
            // to do: add more commands
            client = new TelegramBotClient(appSettings.Key);
            var hook = string.Format(appSettings.Url, "api/message/update");
            await client.SetWebhookAsync(hook);
                return client;
        }
       
    }
}