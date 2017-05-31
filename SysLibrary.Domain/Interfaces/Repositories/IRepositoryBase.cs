using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SysLibrary.Domain.Interfaces.Repositories
{
    public interface IRepositoryBase<TEntity> where TEntity: class
    {
        void add(TEntity obj);

        void Remove(TEntity obj);

        void Update(TEntity obj);

        void Dispose();

        TEntity GetById(int id);

        IEnumerable<TEntity> GetAll();
    }
}
