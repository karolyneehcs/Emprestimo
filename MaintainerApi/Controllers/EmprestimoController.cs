using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
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
    }
}