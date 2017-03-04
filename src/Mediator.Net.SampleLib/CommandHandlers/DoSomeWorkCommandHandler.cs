using System;
using System.Threading.Tasks;
using Mediator.Net.Context;
using Mediator.Net.Contracts;
using Mediator.Net.SampleLib.Messages.Commands;
using Mediator.Net.SampleLib.Messages.Events;

namespace Mediator.Net.SampleLib.CommandHandlers
{
    public class DoSomeWorkCommandHandler : ICommandHandler<DoSomeWorkCommand>
    {
        public async Task Handle(ReceiveContext<DoSomeWorkCommand> context)
        {
            await context.PublishAsync(new WorkHasBeenDoneEvent());
        }
    }
}
