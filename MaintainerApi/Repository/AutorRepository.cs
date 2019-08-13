using MaintainerApi.Data;
using MaintainerApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MaintainerApi.Repository
{
    public class AutorRepository : Repository<Autor>
    {
        public AutorRepository(MaintainerApiContext context) : base(context)
        {

        }

        public IQueryable<Autor> ToPagged(IQueryable<Autor> entities, int page, int pageSize)
        {
            return page == 0 ? entities.Skip((page - 1) * pageSize).Take(pageSize) : entities;
        }

        public IQueryable<Autor> OrderBy(IQueryable<Autor> entity, string atributo, string direcao)
        {
            switch (atributo)
            {

                case "nome":
                    entity = (direcao == "asc")
                        ? entity.OrderBy(n => n.Nome)
                        : entity.OrderByDescending(n => n.Nome);
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
