using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using MaintainerApi.Models;
using MaintainerApi.Repository;
using MaintainerApi.ViewModels.Editora;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MaintainerApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EditoraController : ControllerBase
    {
        private readonly EditoraRepository _editoraRepository;
        private readonly IMapper _mapper;

        public EditoraController(EditoraRepository editoraRepository, IMapper mapper)
        {
            _editoraRepository = editoraRepository;
            _mapper = mapper; 
        }

        [HttpGet]
        public ActionResult<EditoraViewModel> Get()
        {
            return Ok(_mapper.Map<EditoraViewModel>(_editoraRepository.GetAll())); 

        }

        [HttpPost]
        public ActionResult<Editora> Create(SaveEditoraViewModel saveViewModel)
        {
            var editora = _editoraRepository.Add(_mapper.Map<Editora>(saveViewModel));

            if (editora == null)
                return BadRequest();

            return Ok(editora);
        }

        [HttpPut]
        public ActionResult<Editora> Edit(SaveEditoraViewModel saveViewModel)
        {
            var editora = _editoraRepository.Add(_mapper.Map<Editora>(saveViewModel));

            if (editora == null)
                return BadRequest();

            return Ok(editora);
        }
    }
}