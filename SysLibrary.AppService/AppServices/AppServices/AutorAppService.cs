using System;
using System.Collections.Generic;
using System.Text;
using SysLibrary.AppService.DTOs;
using SysLibrary.Domain.Entities;
using SysLibrary.Domain.Interfaces.Services;
using SysLibrary.AppService.AppServices.Interfaces;

namespace SysLibrary.AppService.AppServices.AppServices
{
    public class AutorAppService : AppServiceBase<Autor, AutorDTO>, IAutorAppService
    {
        private readonly IAutorService _service;

        public AutorAppService(IAutorService service)
        :base(service)
        {
            _service = service;
        }
    }
}
