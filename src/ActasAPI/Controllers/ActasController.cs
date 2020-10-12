using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using ActasAPI.Data;
using ActasAPI.Models;

namespace ActasAPI.Controllers{
    [Route("api/[Controller]")]
    [ApiController]
    public class ActasController:ControllerBase
    {
        private readonly IActaAPIRepository _repository;

        public ActasController(IActaAPIRepository repository)
        {
            _repository=repository;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Acta>> Get()
        {
            var items = _repository.Get();
            return Ok(items);
        }

        [HttpGet("{id}")]
        public ActionResult<Acta> Get(int id)
        {
            var item = _repository.Get(id);
            if (item==null)
            {
                return NotFound();
            }
            return Ok(item);
        }

    }
}