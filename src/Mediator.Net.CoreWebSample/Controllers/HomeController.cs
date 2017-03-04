using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mediator.Net.SampleLib.Messages.Requests;
using Microsoft.AspNetCore.Mvc;

namespace Mediator.Net.CoreWebSample.Controllers
{
    public class HomeController : Controller
    {
        private readonly IMediator _mediator;

        public HomeController(IMediator mediator)
        {
            _mediator = mediator;
        }
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> About()
        {
            var response = await _mediator.RequestAsync<GetAboutTextRequest, GetAboutTextResponse>(new GetAboutTextRequest());
            ViewData["Message"] = response.Text;

            return View();
        }

        public async Task<IActionResult> Contact()
        {
            var response =
                await _mediator.RequestAsync<GetContactTextRequest, GetContactTextResponse>(new GetContactTextRequest());
            ViewData["Message"] = response.Text;

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
