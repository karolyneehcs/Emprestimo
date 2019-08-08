using MaintainerApi.Data;
using MaintainerApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MaintainerApi.Repository
{
    public class EditoraRepository : Repository<Editora>
    {
        public EditoraRepository(MaintainerApiContext context) : base(context)
        {

        }

        public IQueryable<Editora> ToPagged(IQueryable<Editora> entities, int page, int pageSize)
        {
            return page == 0 ? entities.Skip((page - 1) * pageSize).Take(pageSize) : entities; 
        }

        public IQueryable<Editora> OrderBy(IQueryable<Editora> entity, string atributo, string direcao)
        {
            switch(atributo)
            {
                case "nome":
                    entity = (direcao == "asc")
                        ? entity.OrderBy(c => c.Nome)
                        : entity.OrderByDescending(c => c.Nome);
                    return entity;
                case "cidade":
                    entity = (direcao == "asc")
                        ? entity.OrderBy(c => c.Cidade)
                        : entity.OrderByDescending(c => c.Cidade);
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
