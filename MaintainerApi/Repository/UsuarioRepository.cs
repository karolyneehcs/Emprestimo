using MaintainerApi.Data;
using MaintainerApi.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MaintainerApi.Repository
{
    public class UsuarioRepository : Repository<Usuario>
    {
        public UsuarioRepository(MaintainerApiContext context) : base(context)
        {

        }

        public override IQueryable<Usuario> GetAll()
        {
            return base.GetAll().Include(a => a.UsuarioList);
        }
    }
}
