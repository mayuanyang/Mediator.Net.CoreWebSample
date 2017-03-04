using Mediator.Net.Contracts;

namespace Mediator.Net.SampleLib.Messages.Requests
{
    public class GetContactTextResponse : IResponse
    {
        public string Text { get; }

        public GetContactTextResponse(string text)
        {
            Text = text;
        }
        
    }
}