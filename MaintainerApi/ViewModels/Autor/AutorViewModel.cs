using MaintainerApi.Models;
using MaintainerApi.ViewModels.Obra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MaintainerApi.ViewModels.Autor
{
    public class AutorViewModel
    {
        public int Id { get; set; }
        public int Nome { get; set; }
        public ICollection<ObraViewModel> ObraList { get; set; }
    }
}
