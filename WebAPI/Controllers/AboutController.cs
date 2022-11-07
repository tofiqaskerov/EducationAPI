using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutController : ControllerBase
    {
        private readonly IAboutService _aboutservice;

        public AboutController(IAboutService aboutservice)
        {
            _aboutservice = aboutservice;
        }
        [HttpPost("aboutAdd")]
        public IActionResult Add(About about)
        {
            var result = _aboutservice.Add(about);
            if (result.Success) return Ok(new { status = 200, message = result.Message });
            return BadRequest(new { message = result.Message });
        }
        [HttpGet("get_first_about")]
        public IActionResult GetFirstAbout()
        {
            var result = _aboutservice.GetFirstAbout();
            if (result.Success) return Ok(new { status = 200, data = result.Data});

            return BadRequest(new { message = result.Message });
        }
    }
}
