using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MaintainerApi.Models
{
    public class Emprestimo : Registro
    {
        public int ObraId { get; set; }
        public int ExemplarId { get; set; }
        public int UsuarioId { get; set; }
        public bool Retirada { get; set; }
        public int Retorno { get; set; }
        public int FuncionarioId { get; set; }
        public Exemplar Exemplar { get; set; }
        public Obra Obra { get; set; }
        public Funcionario Funcionario { get; set; }
        public Usuario Usuario { get; set; }
    }
}
