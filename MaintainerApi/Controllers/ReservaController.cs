using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using MaintainerApi.Repository;
using MaintainerApi.ViewModels.Reserva;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MaintainerApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReservaController : ControllerBase
    {
        private readonly ReservaRepository _reservaRepository;
        private readonly IMapper _mapper;

        public ReservaController(ReservaRepository reservaRepository, IMapper mapper)
        {
            _reservaRepository = reservaRepository;
            _mapper = mapper; 
        }

        [HttpGet]
        public ActionResult<ReservaViewModel> Get()
        {
            return Ok(_mapper.Map<ReservaViewModel>(_reservaRepository.GetAll()));
        }
    }
}