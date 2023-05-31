using Microsoft.AspNetCore.Mvc;
using NlogFileDemo.Interface;

namespace NlogFileDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private ILog objLogger;

        public ValuesController(ILog log) {
            objLogger = log;
        }

        [HttpGet]
        public IEnumerable<string> Get()
        {
            objLogger.Information("Information is logged");
            objLogger.Warning("Warning is logged");
            objLogger.Debug("Debug log is logged");
            objLogger.Error("Error is logged");
            
            return new string[] { "value1", "value2" };
        }
    }
}
