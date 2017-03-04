using System.Threading.Tasks;
using Mediator.Net.Context;
using Mediator.Net.Contracts;
using Mediator.Net.SampleLib.Messages.Requests;

namespace Mediator.Net.SampleLib.RequestHandlers
{
    public class GetAboutTextRequestHandler : IRequestHandler<GetAboutTextRequest, GetAboutTextResponse>
    {
        public Task<GetAboutTextResponse> Handle(ReceiveContext<GetAboutTextRequest> context)
        {
            return Task.FromResult(new GetAboutTextResponse("Your application description page."));
        }
    }
}
