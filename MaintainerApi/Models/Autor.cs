using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MaintainerApi.Models
{
    public class Autor
    {
        public int Id { get; set; }
        public int Nome { get; set; }
        public ICollection<ObraAutor> ObraAutores { get; set; }

    }
}
