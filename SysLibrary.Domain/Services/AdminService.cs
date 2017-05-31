using SysLibrary.Domain.Entities;
using SysLibrary.Domain.Interfaces.Services;
using SysLibrary.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SysLibrary.Domain.Services
{
    public class AdminService : ServiceBase<Admin> , IAdminService
    {
        private readonly IAdminRepository _repository;

           public AdminService(IAdminRepository adminRepository)
              : base(adminRepository)
           {
               _repository = adminRepository;

           }
    }
}
