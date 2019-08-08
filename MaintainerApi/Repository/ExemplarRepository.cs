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

        public IQueryable<Exemplar> ToPagged(IQueryable<Exemplar> entities, int page, int pageSize)
        {
            return page == 0 ? entities.Skip((page - 1) * pageSize).Take(pageSize) : entities; 
        }
        public IQueryable<Exemplar> OrderBy(IQueryable<Exemplar> entity, string atributo, string direcao)
        {
            switch(atributo)
            {
                case "idObra":
                    entity = (direcao == "asc")
                        ? entity.OrderBy(c => c.ObraId)
                        : entity.OrderByDescending(c => c.ObraId);
                    return entity;
                case "numero":
                    entity = (direcao == "asc")
                        ? entity.OrderBy(c => c.Numero)
                        : entity.OrderByDescending(c => c.Numero);
                    return entity;
                default:
                    entity = (direcao == "asc")
                        ? entity.OrderBy(n => n.Id)
                        : entity.OrderByDescending(n => n.Id);
                    return entity;
            }
        }
    }
}
