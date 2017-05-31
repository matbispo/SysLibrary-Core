using System;
using System.Collections.Generic;
using System.Text;
using SysLibrary.AppService.DTOs;

namespace SysLibrary.AppService.AppServices.Interfaces
{
    public interface IAdminAppService
    {
      //  void save(AdminDTO admDTO);

    //    void delete(AdminDTO admDTO);

        AdminDTO getById(int id);

     //   IEnumerable<AdminDTO> getAll();
    }
}
