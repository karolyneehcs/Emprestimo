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

        public IQueryable<Departamento> ToPagged(IQueryable<Departamento> entities, int page, int pageSize)
        {
            return page == 0 ? entities.Take((page - 1) * pageSize).Skip(pageSize) : entities; 
        }

        public IQueryable<Departamento> OrderBy(IQueryable<Departamento> entity, string atributo, string direcao)
        {
            switch(atributo)
            {
                case "nome":
                    entity = (direcao == "asc")
                        ? entity.OrderBy(c => c.Nome)
                        : entity.OrderByDescending(c => c.Nome);
                    return entity;
                case "idChefe:
                    entity = (direcao == "asc")
                        ? entity.OrderBy(c => c.ChefeId) 
                        : entity.OrderByDescending(c => c.ChefeId);
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
