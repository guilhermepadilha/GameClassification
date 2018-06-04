using GameClassification.Domain.Interfaces;
using GameClassification.Infra.Data.Contexto;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace GameClassification.Infra.Data.Repositories
{
    public class RepositoryBase<TEntity> : IDisposable, IRepositoryBase<TEntity> where TEntity : class
    {
        protected GameClassificationContext Db = new GameClassificationContext();

        public void Add(TEntity obj)
        {
            try
            {
                Db.Set<TEntity>().Add(obj);
                Db.SaveChanges();

            }
            catch (Exception ex)
            {
                throw;
            }
           
        }

        public IEnumerable<TEntity> GetAll()
        {
            return Db.Set<TEntity>().ToList();
        }

        public TEntity GetById(int id)
        {
            return Db.Set<TEntity>().Find(id);
        }

        public void Update(TEntity obj)
        {
            Db.Entry(obj).State = EntityState.Modified;
            Db.SaveChanges();
        }

        public void Remove(TEntity obj)
        {
            Db.Set<TEntity>().Remove(obj);
            Db.SaveChanges();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public void Dipose()
        {
            throw new NotImplementedException();
        }
    }
}
