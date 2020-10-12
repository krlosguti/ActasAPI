using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace ActasAPI.Controllers{
    [Route("api/[Controller]")]
    [ApiController]
    public class ActasController:ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] {"this","is","hard","coded"};
        }

    }
}