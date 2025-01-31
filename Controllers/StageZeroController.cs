using Microsoft.AspNetCore.Mvc;

namespace HNG12StageZero.Controllers
{
    [ApiController]
    [Route("/")]
    public class StageZeroController : Controller
    {
        [HttpGet]
        public JsonResult Get()
        {
            StageZero result = new StageZero();

            return new JsonResult(Ok(result));
        }
    }
}
