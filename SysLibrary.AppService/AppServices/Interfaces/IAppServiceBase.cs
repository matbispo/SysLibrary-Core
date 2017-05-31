using System;
using System.Collections.Generic;
using System.Text;

namespace SysLibrary.AppService.AppServices.Interfaces
{
    public interface IAppServiceBase<TEntity, TDTO> where TEntity: class
    {
        IEnumerable<TDTO> GetAll();

        TDTO GetById(int id);

        bool Save(TDTO dto);

        bool Delete(TDTO dto);
    }
}
