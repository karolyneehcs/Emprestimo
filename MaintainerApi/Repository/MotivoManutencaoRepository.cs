using MaintainerApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MaintainerApi.Repository
{
    public class MotivoManutencaoRepository : Repository<MotivoManutencao>
    {
        public MotivoManutencaoRepository(MaintainerApiContext context) : base(context)
        {

        }
    }
}
