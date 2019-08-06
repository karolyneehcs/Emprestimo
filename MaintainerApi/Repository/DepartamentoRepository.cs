using MaintainerApi.Data;
using MaintainerApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MaintainerApi.Repository
{
    public class DepartamentoRepository : Repository<Departamento>
    {
        public DepartamentoRepository(MaintainerApiContext context) : base(context)
        {
               
        }
    }
}
