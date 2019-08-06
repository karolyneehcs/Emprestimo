using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
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
    }
}