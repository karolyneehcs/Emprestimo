using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using MaintainerApi.Models;
using MaintainerApi.Repository;
using MaintainerApi.ViewModels.Obra;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MaintainerApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ObraController : ControllerBase
    {
        private readonly ObraRepository _obraRepository;
        private readonly IMapper _mapper;

        public ObraController(ObraRepository obraRepository, IMapper mapper)
        {
            _obraRepository = obraRepository;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<ObraViewModel> Get()
        {
            return Ok(_mapper.Map<ObraViewModel>(_obraRepository.GetAll()));
        }

        [HttpGet("{id}")]
        public ActionResult<ObraViewModel> Get(int id)
        {
            return Ok(_mapper.Map<ObraViewModel>(_obraRepository.GetById(id)));
        }

        [HttpPost]
        public ActionResult<ObraViewModel> Create(SaveObraViewModel saveViewModel)
        {
            var obra = _obraRepository.Add(_mapper.Map<Obra>(saveViewModel));

            if (obra == null)
                return BadRequest();

            return Ok(_mapper.Map<ObraViewModel>(obra));
        }

        [HttpPut]
        public ActionResult<ObraViewModel> Edit(SaveObraViewModel saveViewModel)
        {
            var obra = _obraRepository.Add(_mapper.Map<Obra>(saveViewModel));

            if (obra == null)
                return BadRequest();

            return Ok(_mapper.Map<ObraViewModel>(obra));
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
          if(id == 0)
          {
            return BadRequest();
          }

          _obraRepository.Remove(id);

          return Ok();
        }
    }
}
