using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
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
    }
}