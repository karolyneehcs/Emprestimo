using AutoMapper;
using MaintainerApi.Models;
using MaintainerApi.ViewModels.Autor;
using MaintainerApi.ViewModels.Departamento;
using MaintainerApi.ViewModels.Editora;
using MaintainerApi.ViewModels.Emprestimo;
using MaintainerApi.ViewModels.Exemplar;
using MaintainerApi.ViewModels.Funcionario;
using MaintainerApi.ViewModels.Genero;
using MaintainerApi.ViewModels.Manutencao;
using MaintainerApi.ViewModels.MotivoManutencao;
using MaintainerApi.ViewModels.Obra;
using MaintainerApi.ViewModels.Reserva;
using MaintainerApi.ViewModels.Usuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MaintainerApi.Util
{
    public class AutoMapper : Profile
    {
        public AutoMapper()
        {
            CreateMap<Autor, SaveAutorViewModel>().ReverseMap();
            CreateMap<Autor, AutorViewModel>().ReverseMap();

            CreateMap<Departamento, SaveDepartamentoViewModel>().ReverseMap();
            CreateMap<Departamento, DepartamentoViewModel>().ReverseMap();

            CreateMap<Editora, SaveEditoraViewModel>().ReverseMap();
            CreateMap<Editora, EditoraViewModel>().ReverseMap();

            CreateMap<Emprestimo, SaveEmprestimoViewModel>().ReverseMap();
            CreateMap<Emprestimo, EmprestimoViewModel>().ReverseMap();

            CreateMap<Exemplar, SaveExemplarViewModel>().ReverseMap();
            CreateMap<Exemplar, ExemplarViewModel>().ReverseMap();

            CreateMap<Funcionario, SaveFuncionarioViewModel>().ReverseMap();
            CreateMap<Funcionario, FuncionarioViewModel>().ReverseMap();

            CreateMap<Genero, SaveGeneroViewModel>().ReverseMap();
            CreateMap<Genero, GeneroViewModel>().ReverseMap();

            CreateMap<Manutencao, SaveManutencaoViewModel>().ReverseMap();
            CreateMap<Manutencao, ManutencaoViewModel>().ReverseMap();

            CreateMap<MotivoManutencao, SaveMotivoManutencaoViewModel>().ReverseMap();
            CreateMap<MotivoManutencao, MotivoManutencaoViewModel>().ReverseMap();

            CreateMap<Obra, SaveObraViewModel>().ReverseMap();
            CreateMap<Obra, ObraViewModel>().ReverseMap();

            CreateMap<Reserva, SaveReservaViewModel>().ReverseMap();
            CreateMap<Reserva, ReservaViewModel>().ReverseMap();

            CreateMap<Usuario, SaveUsuarioViewModel>().ReverseMap();
            CreateMap<Usuario, UsuarioViewModel>().ReverseMap(); 


        }
    }
}
