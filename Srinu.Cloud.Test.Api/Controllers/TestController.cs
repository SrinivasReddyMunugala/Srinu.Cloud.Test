using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Srinu.Cloud.Test.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        private readonly ILogger _logger;

        public TestController(ILogger<TestController> logger)
        {
            this._logger = logger;
        }

        [HttpGet(Name = "pubsubdata")]
        public async Task<IActionResult> pubsubdata(HttpContext httpContext )
        { 
        
            HttpResponse response = httpContext.Response;

            _logger.LogInformation("function got called");
            _logger.LogInformation(httpContext?.Request?.Body?.ToString());
            _logger.LogInformation("function call ended");
            return Ok(response);

        }
    }
}
