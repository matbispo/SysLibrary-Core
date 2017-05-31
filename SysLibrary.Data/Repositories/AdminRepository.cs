using SysLibrary.Data.Context;
using SysLibrary.Domain.Entities;
using SysLibrary.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysLibrary.Data.Repositories
{
    public class AdminRepository : RepositoryBase<Admin>, IAdminRepository
    {
        private readonly IContextDb _db;

        public AdminRepository(IContextDb db): base(db)
        {
            _db = db;
        }

        /*public IEnumerable<Admin> getAll()
        {
            return _db.Admins.ToList();
        }*/
    }
}
