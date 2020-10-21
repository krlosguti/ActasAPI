using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using ActasAPI.Data;
using ActasAPI.Models;
using AutoMapper;
using ActasAPI.Dtos;
using Microsoft.AspNetCore.JsonPatch;

namespace ActasAPI.Controllers{
    [Route("api/[Controller]")]
    [ApiController]
    public class ActasController:ControllerBase
    {
        private readonly IActaAPIRepository _repository;
        private readonly IMapper _mapper;

        public ActasController(IActaAPIRepository repository, IMapper mapper)
        {
            _repository=repository;
            _mapper=mapper;
        }

        [HttpGet]
        public ActionResult<IEnumerable<ActaReadDto>> Get()
        {
            var items = _repository.Get();
            return Ok(_mapper.Map<IEnumerable<ActaReadDto>>(items));
        }

        [HttpGet("{id}",Name="Get")]
        public ActionResult<ActaReadDto> Get(int id)
        {
            var item = _repository.Get(id);
            if (item==null)
            {
                return NotFound();
            }
            return Ok(_mapper.Map<ActaReadDto>(item));
        }

        [HttpPost]
        public ActionResult <ActaReadDto> Create(ActaCreateDto item)
        {
            var itemModel = _mapper.Map<Acta>(item);
            _repository.Create(itemModel);
            _repository.SaveChanges();
            var itemReadDto = _mapper.Map<ActaReadDto>(itemModel);
            return CreatedAtRoute(nameof(Get),new {Id = itemReadDto.ActaId}, itemReadDto);
        }

        [HttpPut("{id}")]
        public ActionResult Update(int id, ActaUpdateDto itemUpdateDto)
        {
            var itemModel = _repository.Get(id);
            if (itemModel == null)
            {
                return NotFound();
            }
            _mapper.Map(itemUpdateDto, itemModel);
            _repository.Update(itemModel);
            _repository.SaveChanges();
            return NoContent();
        }

        [HttpPatch("{id}")]
        public ActionResult Update(int id, JsonPatchDocument<ActaUpdateDto> patchDoc)
        {
            var itemModel = _repository.Get(id);
            if(itemModel == null)
            {
                return NotFound();
            }
            var itemToPatch = _mapper.Map<ActaUpdateDto>(itemModel);
            patchDoc.ApplyTo(itemToPatch, ModelState);
            if(!TryValidateModel(itemToPatch))
            {
                return ValidationProblem(ModelState);
            }
            _mapper.Map(itemToPatch, itemModel);
            _repository.Update(itemModel);
            _repository.SaveChanges();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var itemModel = _repository.Get(id);
            if(itemModel == null)
            {
                return NotFound();
            }
            _repository.Delete(itemModel);
            _repository.SaveChanges();
            return NoContent();
        }
    }
}
