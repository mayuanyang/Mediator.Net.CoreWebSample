using Mediator.Net.Contracts;

namespace Mediator.Net.SampleLib.Messages.Requests
{
    public class GetAboutTextResponse : IResponse
    {
        public string Text { get; }

        public GetAboutTextResponse(string text)
        {
            Text = text;
        }
    }
}