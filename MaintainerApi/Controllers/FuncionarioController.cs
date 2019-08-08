using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using MaintainerApi.Models;
using MaintainerApi.Repository;
using MaintainerApi.ViewModels.Funcionario;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MaintainerApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FuncionarioController : ControllerBase
    {
        private readonly FuncionarioRepository _funcionarioRepository;
        private readonly IMapper _mapper;

        public FuncionarioController(FuncionarioRepository funcionarioRepository, IMapper mapper)
        {
            _funcionarioRepository = funcionarioRepository;
            _mapper = mapper; 
        }

        [HttpGet]
        public ActionResult<FuncionarioViewModel> Get()
        {
            return Ok(_mapper.Map<FuncionarioViewModel>(_funcionarioRepository.GetAll()));
        }

        [HttpPost]
        public ActionResult<FuncionarioViewModel> Create(SaveFuncionarioViewModel saveViewModel)
        {
            var funcionario = _funcionarioRepository.Add(_mapper.Map<Funcionario>(saveViewModel));

            if (funcionario == null)
                return BadRequest();

            return Ok(_mapper.Map<FuncionarioViewModel>(funcionario));
        }

        [HttpPut]
        public ActionResult<FuncionarioViewModel> Edit(SaveFuncionarioViewModel saveViewModel)
        {
            var funcionario = _funcionarioRepository.Add(_mapper.Map<Funcionario>(saveViewModel));

            if (funcionario == null)
                return BadRequest();

            return Ok(_mapper.Map<FuncionarioViewModel>(funcionario));
        }
    }
}