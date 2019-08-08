using MaintainerApi.Data;
using MaintainerApi.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MaintainerApi.Repository
{
    public class FuncionarioRepository : Repository<Funcionario>
    {
        public FuncionarioRepository(MaintainerApiContext context) : base(context)
        {

        }

        public override IQueryable<Funcionario> GetAll()
        {
            return base.GetAll().Include(a => a.Departamento);
        }

    }
}
