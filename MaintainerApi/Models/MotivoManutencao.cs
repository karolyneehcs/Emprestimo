using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MaintainerApi.Models
{
    public class MotivoManutencao : Registro
    {
        public string descricao { get; set; }
        public ICollection<Manutencao> Manutencoes { get; set; }
    }
}
