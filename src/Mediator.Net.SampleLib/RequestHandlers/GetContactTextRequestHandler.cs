using System.Threading;
using System.Threading.Tasks;
using Mediator.Net.Context;
using Mediator.Net.Contracts;
using Mediator.Net.SampleLib.Messages.Requests;

namespace Mediator.Net.SampleLib.RequestHandlers
{
    public class GetContactTextRequestHandler : IRequestHandler<GetContactTextRequest, GetContactTextResponse>
    {
        private readonly IAboutTextService _service;

        public GetContactTextRequestHandler(IAboutTextService service)
        {
            _service = service;
        }
        public async Task<GetContactTextResponse> Handle(ReceiveContext<GetContactTextRequest> context, CancellationToken cancellationToken)
        {
            var text = await _service.GetContactText();
            return new GetContactTextResponse(text);
        }
    }
}
