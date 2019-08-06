using MaintainerApi.Data;
using MaintainerApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MaintainerApi.Repository
{
    public class GeneroRepository : Repository<Genero>
    {
        public GeneroRepository(MaintainerApiContext context) : base(context)
        {

        }
    }
}
