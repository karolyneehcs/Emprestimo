using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using MaintainerApi.Models;
using MaintainerApi.Repository;
using MaintainerApi.ViewModels.MotivoManutencao;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MaintainerApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MotivoManutencaoController : ControllerBase
    {
        private readonly MotivoManutencaoRepository _motivoManutencaoRepository;
        private readonly IMapper _mapper;

        public MotivoManutencaoController(MotivoManutencaoRepository motivoManutencaoRepository, IMapper mapper)
        {
            _motivoManutencaoRepository = motivoManutencaoRepository;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<MotivoManutencaoViewModel> Get()
        {
            return Ok(_mapper.Map<MotivoManutencaoViewModel>(_motivoManutencaoRepository.GetAll()));
        }

        [HttpGet]
        public ActionResult<MotivoManutencaoViewModel> Get(int Id)
        {
            return Ok(_mapper.Map<MotivoManutencaoViewModel>(_motivoManutencaoRepository.GetById(Id)));
        }

        [HttpPost]
        public ActionResult<MotivoManutencaoViewModel> Create(SaveMotivoManutencaoViewModel saveViewModel)
        {
            var motivoManutencao = _motivoManutencaoRepository.Add(_mapper.Map<MotivoManutencao>(saveViewModel));

            if (motivoManutencao == null)
                return BadRequest();

            return Ok(_mapper.Map<MotivoManutencao>(motivoManutencao));
        }

        [HttpPut]
        public ActionResult<MotivoManutencaoViewModel> Edit(SaveMotivoManutencaoViewModel saveViewModel)
        {
            var motivoManutencao = _motivoManutencaoRepository.Add(_mapper.Map<MotivoManutencao>(saveViewModel));

            if (motivoManutencao == null)
                return BadRequest();

            return Ok(_mapper.Map<MotivoManutencaoViewModel>(motivoManutencao));
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
          if(id == 0)
          {
            return BadRequest();
          }

          _motivoManutencaoRepository.Remove(id);

          return Ok(); 
        }
    }
}
