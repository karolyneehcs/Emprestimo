using MaintainerApi.Data;
using MaintainerApi.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MaintainerApi.Repository
{
    public class ObraRepository : Repository<Obra>
    {
        public ObraRepository(MaintainerApiContext context) : base(context)
        {

        }

        public override IQueryable<Obra> GetAll()
        {
            return base.GetAll().Include(a => a.Editora);
        }
    }
}
