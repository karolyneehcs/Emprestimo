using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MaintainerApi.Models
{
    public class Autor : Registro
    {
        public int Nome { get; set; }
        public ICollection<ObraAutor> ObraAutores { get; set; }

    }
}
