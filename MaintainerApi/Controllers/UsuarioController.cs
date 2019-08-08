using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using MaintainerApi.Models;
using MaintainerApi.Repository;
using MaintainerApi.ViewModels.Usuario;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MaintainerApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly UsuarioRepository _usuarioRepository;
        private readonly IMapper _mapper;

        public ActionResult<UsuarioViewModel> AcessoViewModel { get; private set; }

        public UsuarioController(UsuarioRepository usuarioRepository, IMapper mapper)
        {
            _usuarioRepository = usuarioRepository;
            _mapper = mapper; 
        }

        [HttpGet]
        public ActionResult<UsuarioViewModel> GetAll()
        {
            return Ok(_mapper.Map<UsuarioViewModel>(_usuarioRepository.GetAll()));
        }

        [HttpPost]
        public ActionResult<UsuarioViewModel> Create(SaveUsuarioViewModel saveViewModel)
        {
            var usuario = _usuarioRepository.Add(_mapper.Map<Usuario>(saveViewModel));

            if (usuario == null)
                return BadRequest();

            return Ok(_mapper.Map<UsuarioViewModel>(usuario));
        } 

        [HttpPut]
        public ActionResult<UsuarioViewModel> Edit(SaveUsuarioViewModel saveViewModel)
        {
            var usuario = _usuarioRepository.Add(_mapper.Map<Usuario>(saveViewModel));

            if (usuario == null)
                return BadRequest();

            return Ok(_mapper.Map<UsuarioViewModel>(usuario));
        }
        
    }
}