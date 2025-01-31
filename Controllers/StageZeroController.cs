using Microsoft.AspNetCore.Mvc;

namespace HNG12StageZero.Controllers
{
    [ApiController]
    [Route("/")]
    public class StageZeroController : Controller
    {
        [HttpGet]
        public IActionResult Get()
        {
            DateTime today = DateTime.UtcNow;
            var result = {
            email = "nbinael@yahoo.com",
            current_datetime = today.ToString("yyyy-MM-ddTHH:mm:ssZ"),
            github_url = "https://github.com/binael/HNG12ProjectZero"
            };
            
            return Ok(result)
        }
    }
}
