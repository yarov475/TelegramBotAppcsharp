using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Telegram.Bot.Types;
using Telegram.Bot;


namespace TelegramBotAppcsharp.Models.Commands
{
    public class HelloCommand : Command
    {
        public override string Name => "Hello";
        public override  async void Execute(Message message, TelegramBotClient client)
        {
            var chatId = message.Chat.Id;
            var messageId = message.MessageId;
            // to do: bot logic

            await client.SendTextMessageAsync(chatId, "Hello! I love You!!!", replyToMessageId: messageId);
        }
    }
}