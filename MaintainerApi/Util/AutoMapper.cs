using AutoMapper;
using MaintainerApi.Models;
using MaintainerApi.ViewModels.Autor;
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


        }
    }
}
