using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysLibrary.Domain.Interfaces.Services
{
    public interface IServiceBase<TEntity> where TEntity: class
    {
        void add(TEntity obj);

        void Remove(TEntity obj);

        void Update(TEntity obj);

        void Dispose();

        TEntity GetById(int id);

        IEnumerable<TEntity> GetAll();
    }
}
