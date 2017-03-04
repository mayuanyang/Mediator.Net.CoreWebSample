using System.Threading.Tasks;

namespace Mediator.Net.SampleLib.RequestHandlers
{
    class AboutTextService : IAboutTextService
    {
        public Task<string> GetContactText()
        {
            return Task.FromResult("this is contact info");
        }
    }
}