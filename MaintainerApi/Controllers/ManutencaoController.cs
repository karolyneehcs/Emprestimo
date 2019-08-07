using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
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
    }
}