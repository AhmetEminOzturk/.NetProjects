using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api.PresentationLayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet]
        public IActionResult Deneme(int id)
        {
            return Ok();
        }
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            return Ok();
        }
    }
}
