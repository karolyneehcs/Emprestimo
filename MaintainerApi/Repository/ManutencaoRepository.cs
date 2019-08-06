using MaintainerApi.Data;
using MaintainerApi.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MaintainerApi.Repository
{
    public class ManutencaoRepository : Repository<Manutencao>
    {
        public ManutencaoRepository(MaintainerApiContext context) : base(context)
        {

        }

        public override IQueryable<Manutencao> GetAll()
        {
            return base.GetAll().Include(a => a.Exemplar).Include(a =>a.Funcionario).Include(a => a.MotivoManutencaoList);
        }
    }
}
