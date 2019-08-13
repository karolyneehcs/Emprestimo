using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using MaintainerApi.Models;
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

        [HttpGet]
        public ActionResult<DepartamentoViewModel> Get(int Id)
        {
            return Ok(_mapper.Map<DepartamentoViewModel>(_departamentoRepository.GetById(Id)));
        }


        [HttpPost]
        public ActionResult<DepartamentoViewModel> Create(SaveDepartamentoViewModel saveViewModel)
        {
            var departamento = _departamentoRepository.Add(_mapper.Map<Departamento>(saveViewModel));

            if (departamento == null)
                return BadRequest();

            return Ok(_mapper.Map<DepartamentoViewModel>(departamento));
        }

        [HttpPut]
        public ActionResult<DepartamentoViewModel> Edit(SaveDepartamentoViewModel saveViewModel)
        {
            var departamento = _departamentoRepository.Add(_mapper.Map<Departamento>(saveViewModel));

            if (departamento == null)
                return BadRequest();

            return Ok(_mapper.Map<DepartamentoViewModel>(departamento));
        }
    }
}