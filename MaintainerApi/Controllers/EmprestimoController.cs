using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using MaintainerApi.Models;
using MaintainerApi.Repository;
using MaintainerApi.ViewModels.Emprestimo;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MaintainerApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmprestimoController : ControllerBase
    {
        private readonly EmprestimoRepository _emprestimoRepository;
        private readonly IMapper _mapper;

        public EmprestimoController(EmprestimoRepository emprestimoRepository, IMapper mapper)
        {
            _emprestimoRepository = emprestimoRepository;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<EmprestimoViewModel> Get()
        {
            return Ok(_mapper.Map<EmprestimoViewModel>(_emprestimoRepository.GetAll()));
        }

        [HttpGet("{id}")]
        public ActionResult<EmprestimoViewModel> Get(int id)
        {
            return Ok(_mapper.Map<EmprestimoViewModel>(_emprestimoRepository.GetById(id)));
        }

        [HttpPost]
        public ActionResult<EmprestimoViewModel> Create(SaveEmprestimoViewModel saveViewModel)
        {
            var emprestimo = _emprestimoRepository.Add(_mapper.Map<Emprestimo>(saveViewModel));

            if (emprestimo == null)
                return BadRequest();

            return Ok(_mapper.Map<EmprestimoViewModel>(emprestimo));
        }

        [HttpPut]
        public ActionResult<EmprestimoViewModel> Edit(SaveEmprestimoViewModel saveViewModel)
        {
            var emprestimo = _emprestimoRepository.Add(_mapper.Map<Emprestimo>(saveViewModel));

            if (emprestimo == null)
                return BadRequest();

            return Ok(_mapper.Map<EmprestimoViewModel>(emprestimo));
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
          if(id == 0)
          {
            return BadRequest();
          }

          _emprestimoRepository.Remove(id);

          return Ok();
        }
    }
}
