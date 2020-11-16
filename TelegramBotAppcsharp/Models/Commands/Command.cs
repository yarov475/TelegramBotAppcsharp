﻿using Telegram.Bot.Types;
using Telegram.Bot;

namespace TelegramBotAppcsharp.Models.Commands
{
    public  abstract class Command
    {
        public abstract string Name { get; }
        public abstract void Execute(Message message, TelegramBotClient client);
        public bool Contains( string command)
        {
            return command.Contains(this.Name) && command.Contains(appSettings.Name);
        }
    }
}