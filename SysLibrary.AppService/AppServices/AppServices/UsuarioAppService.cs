using System;
using System.Collections.Generic;
using System.Text;
using SysLibrary.AppService.DTOs;
using SysLibrary.Domain.Entities;
using SysLibrary.Domain.Interfaces.Services;
using SysLibrary.AppService.AppServices.Interfaces;

namespace SysLibrary.AppService.AppServices.AppServices
{
    public class UsuarioAppService : AppServiceBase<Usuario, UsuarioDTO>, IUsuarioAppService
    {
        private readonly IUsuarioService _service;

        public UsuarioAppService(IUsuarioService service)
        :base(service)
        {
            _service = service;
        }
    }
}
