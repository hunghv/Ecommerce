using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Logging.Entities;
using Logging.Helper;
using Logging.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private ILoggingRepository _loggingRepository;
        public ValuesController(ILoggingRepository loggingRepository)
        {
            _loggingRepository = loggingRepository;
        }
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            LoggingHelper.LogException("hunghv3", new Exception("hunghv3"), LogMessageType.Error);
            _loggingRepository.LogException("hunghv2", new Exception("hunghv123"), LogMessageType.Error);
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
