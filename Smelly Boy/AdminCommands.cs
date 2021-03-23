using DSharpPlus.CommandsNext;
using DSharpPlus;
using DSharpPlus.CommandsNext.Attributes;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Smelly_Boy
{
    class AdminCommands : BaseCommandModule
    {
        [Command("Noob")]
        [Description("Will DM Vincent that he is a noob")]
        public async Task Noob(CommandContext ctx)
        {
            await ctx.Channel.SendMessageAsync("Vincent should start farming").ConfigureAwait(false);
        }
    }
}
