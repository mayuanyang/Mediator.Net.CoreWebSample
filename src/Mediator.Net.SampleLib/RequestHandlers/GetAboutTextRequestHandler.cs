using System.Threading.Tasks;
using Mediator.Net.Context;
using Mediator.Net.Contracts;
using Mediator.Net.SampleLib.Messages.Requests;
using Microsoft.Extensions.Configuration;

namespace Mediator.Net.SampleLib.RequestHandlers
{
    public class GetAboutTextRequestHandler : IRequestHandler<GetAboutTextRequest, GetAboutTextResponse>
    {
        private IConfigurationRoot _configuration;

        public GetAboutTextRequestHandler(IConfigurationRoot configuration)
        {
            _configuration = configuration;
        }
        public Task<GetAboutTextResponse> Handle(ReceiveContext<GetAboutTextRequest> context)
        {
            var dummy = _configuration.GetSection("DummyConnectionString").Value;
            return Task.FromResult(new GetAboutTextResponse(dummy));
        }
    }
}
