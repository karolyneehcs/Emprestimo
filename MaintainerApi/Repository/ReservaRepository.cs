using MaintainerApi.Data;
using MaintainerApi.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MaintainerApi.Repository
{
    public class ReservaRepository : Repository<Reserva>
    {
        public ReservaRepository(MaintainerApiContext context) : base(context)
        {

        }

        public override IQueryable<Reserva> GetAll()
        {
            return base.GetAll().Include(a => a.Obra).Include(a => a.Usuario);
        }
    }
}
