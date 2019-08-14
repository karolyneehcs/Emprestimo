using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using MaintainerApi.Models;
using MaintainerApi.Repository;
using MaintainerApi.ViewModels.Exemplar;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MaintainerApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExemplarController : ControllerBase
    {
        private readonly ExemplarRepository _exemplarRepository;
        private readonly IMapper _mapper;

        public ExemplarController(ExemplarRepository exemplarRepository, IMapper mapper)
        {
            _exemplarRepository = exemplarRepository;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<ExemplarViewModel> Get()
        {
            return Ok(_mapper.Map<ExemplarViewModel>(_exemplarRepository.GetAll()));
        }

        [HttpGet("{id}")]
        public ActionResult<ExemplarViewModel> Get(int id)
        {
            return Ok(_mapper.Map<ExemplarViewModel>(_exemplarRepository.GetById(id)));
        }

        [HttpPost]
        public ActionResult<ExemplarViewModel> Create(SaveExemplarViewModel saveViewModel)
        {
            var exemplar = _exemplarRepository.Add(_mapper.Map<Exemplar>(saveViewModel));

            if (exemplar == null)
                return BadRequest();

            return Ok(_mapper.Map<ExemplarViewModel>(exemplar));
        }

        [HttpPut]
        public ActionResult<ExemplarViewModel> Edit(SaveExemplarViewModel saveViewModel)
        {
            var exemplar = _exemplarRepository.Add(_mapper.Map<Exemplar>(saveViewModel));

            if (exemplar == null)
                return BadRequest();

            return Ok(_mapper.Map<ExemplarViewModel>(exemplar));
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
          if(id == 0)
          {
            return BadRequest();
          }

          _exemplarRepository.Remove(id);

          return Ok();
        }

    }
}
