//==============================================
//Copyright (c) Coalition Good-Hearted Engineers
//Free to Find Comfort and Peace
//==============================================

using Microsoft.AspNetCore.Mvc;
using RESTFulSense.Controllers;

namespace Sheenam.Api.Controllers
{
    [ApiController]
    [Route("api /[controller]")]
    public class HomeController : RESTFulController
    {
        [HttpGet]

        public ActionResult<string> Get() => "Hello Mario, the princes is another castle.";
    }
}
