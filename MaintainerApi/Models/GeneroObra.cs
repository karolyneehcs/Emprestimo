using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MaintainerApi.Models
{
    public class GeneroObra
    {
        public int GeneroId { get; set; }
        public int ObraId { get; set; }
        public Genero Genero { get; set; }
        public Obra Obra { get; set; }
    }
}
