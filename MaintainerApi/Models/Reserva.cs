using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MaintainerApi.Models
{
    public class Reserva : Registro
    {
        public int UsuarioId { get; set; }
        public int ObraId { get; set; }
        public bool Reservado { get; set; }
        public bool Retirado { get; set; }
        public Obra Obra { get; set; }
        public Usuario Usuario { get; set; }
    }
}
