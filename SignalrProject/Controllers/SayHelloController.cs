using Microsoft.AspNetCore.Mvc;

// Note we do not need a controller for the sample but I want to 
// demonstrate that this is a normal webapi app and controllers are
// still fucntional and you can build on them 
namespace SignalrProject.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SayHelloController : ControllerBase
    {
        

        private readonly ILogger<SayHelloController> _logger;

        public SayHelloController(ILogger<SayHelloController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "SayHello")]
        public string Get()
        {
            _logger.LogInformation("Saying hello");
            return "Hello";
        }
    }
}