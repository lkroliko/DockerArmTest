using Microsoft.AspNetCore.Mvc;

namespace DockerArmTest.Controllers
{
    [ApiController]
    [Route("")]
    public class RootControler : ControllerBase
    {
        private readonly IConfiguration _configuration;
        private readonly ILogger<WeatherForecastController> _logger;

        public RootControler(IConfiguration configuration, ILogger<WeatherForecastController> logger)
        {
            _configuration = configuration;
            _logger = logger;
        }

        public IResult Get()
        {
            _logger.LogInformation("Root get entered");

            var value = _configuration.GetValue<string>("TestOption");

            return Results.Ok<string>($"TestOption: {value}");
        }
    }
}