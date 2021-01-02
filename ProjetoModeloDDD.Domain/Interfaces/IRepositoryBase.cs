using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoModeloDDD.Domain.Interfaces
{
    public interface IRepositoryBase <TEntity> where TEntity : class
    {
        void add(TEntity obj);
        TEntity getById(int id);
        IEnumerable<TEntity> GetAll();
        void Update(TEntity obj);
        void Remove(TEntity obj);
        void Dispose();    }
}
