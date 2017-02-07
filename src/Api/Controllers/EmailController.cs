using Domain.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    public class EmailController : Controller
    {
        [HttpGet]
        public IActionResult TestAction()
        {
            return Ok("this is a test.");
        }
    }
}
