using SysLibrary.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SysLibrary.Domain.Interfaces.Repositories
{
    public interface IAdminRepository: IRepositoryBase<Admin>
    {

        //IEnumerable<Admin> getAll();
    }
}
