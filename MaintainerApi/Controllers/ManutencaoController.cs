using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using MaintainerApi.Models;
using MaintainerApi.Repository;
using MaintainerApi.ViewModels.Manutencao;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MaintainerApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ManutencaoController : ControllerBase
    {
        private readonly ManutencaoRepository _manutencaoRepository;
        private readonly IMapper _mapper;

        public ManutencaoController(ManutencaoRepository manutencaoRepository, IMapper mapper)
        {
            _manutencaoRepository = manutencaoRepository;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<ManutencaoViewModel> Get()
        {
            return Ok(_mapper.Map<ManutencaoViewModel>(_manutencaoRepository.GetAll()));
        }


        [HttpGet("id")]
        public ActionResult<ManutencaoViewModel> Get(int id)
        {
            return Ok(_mapper.Map<ManutencaoViewModel>(_manutencaoRepository.GetById(id)));
        }


        [HttpPost]
        public ActionResult<ManutencaoViewModel> Create(SaveManutencaoViewModel saveViewModel)
        {
            var manutencao = _manutencaoRepository.Add(_mapper.Map<Manutencao>(saveViewModel));

            if (manutencao == null)
                return BadRequest();

            return (_mapper.Map<ManutencaoViewModel>(manutencao));
        }

        [HttpPut]
        public ActionResult<ManutencaoViewModel> Edit(SaveManutencaoViewModel saveViewModel)
        {
            var manutencao = _manutencaoRepository.Add(_mapper.Map<Manutencao>(saveViewModel));

            if (manutencao == null)
                return BadRequest();

            return Ok(_mapper.Map<ManutencaoViewModel>(manutencao));
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
          if(id == 0)
          {
            return BadRequest();
          }

          _manutencaoRepository.Remove(id);

          return Ok();
        }

    }
}
