using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CodeSculptor_UI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class DataController : ControllerBase
    {
        public static Component cmp = new Component();

        [HttpPost]
        public IActionResult SaveComponent(Component component)
        {
            cmp = component;
            return Ok(true);
        }

        [HttpGet]
        public IActionResult GetComponent()
        {
            return Ok(cmp);
        }
    }

    public class Component
    {
        public string HTML { get; set; }
        public string CSS { get; set; }
        public List<string> ExternalCSSLinks { get; set; }
    }
}
