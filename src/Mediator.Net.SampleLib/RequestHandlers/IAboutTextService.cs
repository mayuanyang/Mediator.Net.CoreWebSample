using System.Threading.Tasks;

namespace Mediator.Net.SampleLib.RequestHandlers
{
    public interface IAboutTextService
    {
        Task<string> GetContactText();
    }
}