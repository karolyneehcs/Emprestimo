using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MaintainerApi.Models
{
    public class Exemplar
    {
        public int Id { get; set; }
        public int ObraId { get; set; }
        public int Numero { get; set; }
        public string Aquisicao { get; set; }
        public string SituacaoExemplar { get; set; }
        public ICollection<Manutencao> Manutencoes { get; set; }
        public Obra Obra { get; set; }
        public ICollection<Emprestimo> Emprestimos { get; set; }
    }
}
