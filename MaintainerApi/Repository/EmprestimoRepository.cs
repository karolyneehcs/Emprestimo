using MaintainerApi.Data;
using MaintainerApi.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MaintainerApi.Repository
{
    public class EmprestimoRepository : Repository<Emprestimo>
    {
        public EmprestimoRepository(MaintainerApiContext context) : base(context)
        {

        }

        public override IQueryable<Emprestimo> GetAll()
        {
            return base.GetAll().Include(a => a.Exemplar).Include(a => a.Obra).Include(a => a.Funcionario).Include(a => a.Usuario);
        }
    }
}
