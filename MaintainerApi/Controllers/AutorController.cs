using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using MaintainerApi.Models;
using MaintainerApi.Repository;
using MaintainerApi.ViewModels.Autor;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MaintainerApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AutorController : ControllerBase
    {
        private readonly AutorRepository _autorRepository;
        private readonly IMapper _mapper;
        public AutorController(AutorRepository autorRepository, IMapper mapper)
        {
            _autorRepository = autorRepository;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<AutorViewModel> Get()
        {
            return Ok(_mapper.Map<AutorViewModel>(_autorRepository.GetAll()));
        }

        [HttpGet("{id}")]
        public ActionResult<AutorViewModel> Get(int Id)
        {
            return Ok(_mapper.Map<AutorViewModel>(_autorRepository.GetById(Id)));
        }

        [HttpPost]
        public ActionResult<AutorViewModel> Create(SaveAutorViewModel saveViewModel)
        {
            var autor = _autorRepository.Add(_mapper.Map<Autor>(saveViewModel));

            if (autor == null)
                return BadRequest();

            return Ok(_mapper.Map<AutorViewModel>(autor));
        }

        [HttpPut]
        public ActionResult<AutorViewModel> Edit(SaveAutorViewModel saveViewModel)
        {
            var autor = _autorRepository.Add(_mapper.Map<Autor>(saveViewModel));

            if (autor == null)
                return BadRequest();

            return Ok(_mapper.Map<AutorViewModel>(autor));
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            if(id == 0)
            {
                return BadRequest();
            }
            _autorRepository.Remove(id);

            return Ok();
        }
    }
}