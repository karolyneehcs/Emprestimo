using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using MaintainerApi.Models;
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

        [HttpGet]
        public ActionResult<ReservaViewModel> Get(int Id)
        {
            return Ok(_mapper.Map<ReservaViewModel>(_reservaRepository.GetById(Id)));
        }

        [HttpPost]
        public ActionResult<ReservaViewModel> Create(SaveReservaViewModel saveViewModel)
        {
            var reserva = _reservaRepository.Add(_mapper.Map<Reserva>(saveViewModel));

            if (reserva == null)
                return BadRequest();

            return Ok(_mapper.Map<ReservaViewModel>(reserva));
        }

        [HttpPut]
        public ActionResult<ReservaViewModel> Edit(SaveReservaViewModel saveViewModel)
        {
            var reserva = _reservaRepository.Add(_mapper.Map<Reserva>(saveViewModel));

            if (reserva == null)
                return BadRequest();

            return Ok(_mapper.Map<ReservaViewModel>(reserva));
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
          if(id == 0)
          {
            return BadRequest();
          }

          _reservaRepository.Remove(id);

          return Ok();
        }
    }
}
