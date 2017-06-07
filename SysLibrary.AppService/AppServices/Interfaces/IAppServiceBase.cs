using System;
using System.Collections.Generic;
using System.Text;

namespace SysLibrary.AppService.AppServices.Interfaces
{
    public interface IAppServiceBase<TEntity, TDTO> where TEntity: class
    {
        IEnumerable<TDTO> GetAll();

        TDTO GetById(int id);

        void Add(TDTO dto);

        void Update(TDTO dto);

        void Delete(TDTO dto);
    }
}
