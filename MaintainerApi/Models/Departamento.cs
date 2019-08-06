using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MaintainerApi.Models
{
    public class Departamento : Registro
    {
        public string Nome { get; set; }
        public int ChefeId { get; set; }
        ICollection<Funcionario> Funcionarios { get; set; }
    }
}
