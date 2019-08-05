using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MaintainerApi.Models
{
    public class Manutencao
    {
        public int Id { get; set; }
        public int ExemplarId { get; set; }
        public int FuncionarioId { get; set; }
        public string MotivoManutencao { get; set; }
        public int MotivoManutencaoId { get; set; }
        public bool Retirado { get; set; }
        public int Retorno { get; set; }
        public MotivoManutencao MotivoManutencaoList { get; set; }
        public Exemplar Exemplar { get; set; }
        public Funcionario Funcionario { get; set; }

    }
}
