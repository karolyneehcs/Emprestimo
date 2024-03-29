﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using MaintainerApi.Models;
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

        [HttpGet("{id}")]
        public ActionResult<GeneroViewModel> Get(int id)
        {
            return Ok(_mapper.Map<GeneroViewModel>(_generoRepository.GetById(id)));
        }

        [HttpPost]
        public ActionResult<Genero> Create(SaveGeneroViewModel saveViewModel)
        {
            var genero = _generoRepository.Add(_mapper.Map<Genero>(saveViewModel));

            if (genero == null)
                return BadRequest();

            return Ok(_mapper.Map<GeneroViewModel>(genero));
        }

        [HttpPost]
        public ActionResult<GeneroViewModel> Edit(SaveGeneroViewModel saveViewModel)
        {
            var genero = _generoRepository.Add(_mapper.Map<Genero>(saveViewModel));

            if (genero == null)
                return BadRequest();

            return Ok(_mapper.Map<GeneroViewModel>(genero));
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
          if(id == 0)
          {
            return BadRequest();
          }

          _generoRepository.Remove(id);

          return Ok();
        }
    }
}
