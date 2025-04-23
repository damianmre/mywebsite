using Microsoft.AspNetCore.Mvc;
using mywebapi.Services;

namespace mywebapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WoordenController : ControllerBase
    {
        private readonly WoordenschatService _woordenschatService;

        public WoordenController(WoordenschatService woordenschatService)
        {
            _woordenschatService = woordenschatService;
        }

        [HttpGet]
        [Route("getwoorden")]
        public IActionResult GetWoorden()
        {
            var woorden = _woordenschatService.GetWoordenAsync().Result;
            if (woorden == null || !woorden.Any())
            {
                return NotFound("Geen woorden gevonden.");
            }
            return Ok(woorden);
        }
    }
}
