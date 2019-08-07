using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
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
    }
}