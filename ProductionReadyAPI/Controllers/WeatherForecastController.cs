using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Contracts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ProductionReadyAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly ILoggerManager _logger;

        public WeatherForecastController(ILoggerManager logger)
        {
            _logger = logger;
        }
       [HttpGet]
       public IEnumerable<string> Get()
        {
            _logger.LogInfo("Here is info message");
            _logger.LogDebug("Here is debug message");
            _logger.LogWarn("Here is warn message");
            _logger.LogError("Here is Error message");

            return new string[] { "value1", "value2" };
        }

     
    }
}
