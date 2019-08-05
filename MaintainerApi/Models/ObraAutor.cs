using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MaintainerApi.Models
{
    public class ObraAutor
    {
        public int AutorId { get; set; }
        public int ObraId { get; set; }
        public string Ordem { get; set; }
        public Obra Obra { get; set; }
        public Autor Autor { get; set; }
    }
}
