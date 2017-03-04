using System;
using System.Threading.Tasks;
using Mediator.Net.Context;
using Mediator.Net.Contracts;
using Mediator.Net.SampleLib.Messages.Events;

namespace Mediator.Net.SampleLib.EventHandlers
{
    public class WorkHasBeenDoneEventHandler : IEventHandler<WorkHasBeenDoneEvent>
    {
        public Task Handle(IReceiveContext<WorkHasBeenDoneEvent> context)
        {
            return Task.FromResult(0);
        }
    }
}
