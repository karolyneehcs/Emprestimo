using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using MaintainerApi.Repository;
using MaintainerApi.ViewModels.Genero;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MaintainerApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GeneroController : ControllerBase
    {
        private readonly GeneroRepository _generoRepository;
        private readonly IMapper _mapper;

        public GeneroController(GeneroRepository generoRepository, IMapper mapper)
        {
            _generoRepository = generoRepository;
            _mapper = mapper; 
        }

        [HttpGet]
        public ActionResult<GeneroViewModel> Get()
        {
            return Ok(_mapper.Map<GeneroViewModel>(_generoRepository.GetAll()));
        }
    }
}