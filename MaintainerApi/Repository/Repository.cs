using MaintainerApi.Data;
using MaintainerApi.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MaintainerApi.Repository
{
    public class Repository<TEntity> where TEntity : Registro
    {

        protected readonly MaintainerApiContext _context;
        protected readonly DbSet<TEntity> _entity;

        public Repository(MaintainerApiContext context)
        {
            _context = context.DbSet<TEntity>();
        }
        public virtual TEntity Add(TEntity entity)
        {
            _entity.Add(entity);
            SaveChanges();

            return entity; 
        }
        public virtual TEntity Update(TEntity entity)
        {
            _entity.Update(entity);
            SaveChanges();

            return entity;
        }
        public virtual TEntity Remove(int id)
        {
            var entity =_entity.Remove(_entity.Find(id));
            SaveChanges();

            return entity.Entity;
        }
        public virtual TEntity GetById(int id)
        {
            return _entity.FirstOrDefault(a => a.Id == id ); 
        }

        public virtual IQueryable<TEntity> GetAll()
        {
            return _entity.AsNoTracking();

        }

        public void SaveChanges()
        {   
            try
            {
                _context.SaveChanges();
            }
            catch(Exception e)
            {
                    

            }
            
        }
    }
}
