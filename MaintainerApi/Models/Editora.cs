using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MaintainerApi.Models
{
    public class Editora : Registro
    {
        public string Nome { get; set; }
        public string Cidade { get; set; }
        public ICollection<Obra> Obras { get; set; }
    }
}
