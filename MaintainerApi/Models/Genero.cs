using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MaintainerApi.Models
{
    public class Genero
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public ICollection<GeneroObra> GeneroObras { get; set; }
    }
}
