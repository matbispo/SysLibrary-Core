using System;
using System.Collections.Generic;
using System.Text;
using SysLibrary.AppService.DTOs;
using SysLibrary.Domain.Entities;

namespace SysLibrary.AppService.AppServices.Interfaces
{
    public interface IUsuarioAppService : IAppServiceBase<Usuario, UsuarioDTO>
    {
    }
}
