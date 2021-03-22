using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace sa_2_demo_1.Controllers
{
    [ApiController]
    public class CalcController : ControllerBase
    {
        [HttpGet]
        [Route("api/calc/sum")]
        public ActionResult GetSum([FromQuery]int x, [FromQuery]int y)
        {
            var sum = x + y;
            return Ok(sum);
        }

        [HttpGet]
        [Route("api/calc/sum/body")]
        public ActionResult GetSumBody([FromForm]int x, [FromForm]int y)
        {
            var sum = x + y;
            return Ok(sum);
        }

        [HttpGet]
        [Route("api/calc/sum/body-json")]
        public ActionResult GetSumBodyJson([FromBody]dynamic body)
        {
            var sum = body.x + body.y;
            return Ok(sum);
        }

    }
}
