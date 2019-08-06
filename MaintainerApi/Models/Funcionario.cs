using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MaintainerApi.Models
{
    public class Funcionario : Registro
    {
        public string Matricula { get; set; }
        public int Salario { get; set; }
        public int DepartamentoId { get; set; }
        public Departamento Departamento { get; set; }
        public ICollection<Emprestimo> Emprestimos { get; set; }
    }
}
