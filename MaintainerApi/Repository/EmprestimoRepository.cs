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

        public IQueryable<Emprestimo> ToPagged(IQueryable<Emprestimo> entities, int page, int pageSize)
        {
            return page == 0 ? entities.Skip((page - 1) * pageSize).Take(pageSize) : entities; 
        }

        public IQueryable<Emprestimo> OrderBy(IQueryable<Emprestimo> entity, string atributo, string direcao)
        {
            switch(atributo)
            {
                case "idObra":
                    entity = (direcao == "asc")
                        ? entity.OrderBy(c => c.ObraId)
                        : entity.OrderByDescending(c => c.ObraId);
                    return entity;
                case "idExemplar":
                    entity = (direcao == "asc")
                        ? entity.OrderBy(c => c.ExemplarId)
                        : entity.OrderByDescending(c => c.ExemplarId);
                    return entity;
                case "idUsuario":
                    entity = (direcao == "asc")
                        ? entity.OrderBy(c => c.UsuarioId)
                        : entity.OrderByDescending(c => c.UsuarioId);
                    return entity;
                case "idFuncionario":
                    entity = (direcao == "asc")
                        ? entity.OrderBy(c => c.FuncionarioId)
                        : entity.OrderByDescending(c => c.FuncionarioId);
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
