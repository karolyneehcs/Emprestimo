using MaintainerApi.Data;
using MaintainerApi.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MaintainerApi.Repository
{
    public class ExemplarRepository : Repository<Exemplar>
    {
        public ExemplarRepository(MaintainerApiContext context) : base(context)
        {

        }

        public override IQueryable<Exemplar> GetAll()
        {
            return base.GetAll().Include(a => a.Obra);
        }
    }
}
