using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MaintainerApi.Models
{
    public class Obra : Registro
    {
        public string Titulo { get; set; }
        public string Publicacao { get; set; }
        public int EditoraId { get; set; }
        public Editora Editora { get; set; }
        public ICollection<Exemplar> Exemplares { get; set; }
        public ICollection<Emprestimo> Emprestimos { get; set; }
        public ICollection<Reserva> Reservas { get; set; }
        public ICollection<GeneroObra> GeneroObras { get; set; }
        public ICollection<ObraAutor> ObraAutores { get; set; }
    }
}
