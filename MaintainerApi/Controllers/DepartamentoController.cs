using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using MaintainerApi.Repository;
using MaintainerApi.ViewModels.Departamento;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MaintainerApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartamentoController : ControllerBase
    {
        private readonly DepartamentoRepository _departamentoRepository;
        private readonly IMapper _mapper;

        public DepartamentoController(DepartamentoRepository departamentoRepository, IMapper mapper)
        {
            _departamentoRepository = departamentoRepository;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<DepartamentoViewModel> Get()
        {
            return Ok(_mapper.Map<DepartamentoViewModel>(_departamentoRepository.GetAll()));
        }
    }
}