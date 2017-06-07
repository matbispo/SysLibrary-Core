using System;
using System.Collections.Generic;
using System.Text;
using SysLibrary.AppService.DTOs;
using SysLibrary.Domain.Entities;
using SysLibrary.Domain.Interfaces.Services;
using SysLibrary.AppService.AppServices.Interfaces;

namespace SysLibrary.AppService.AppServices.AppServices
{
    public class AutorLivroAppService : AppServiceBase<AutorLivro, AutorLivroDTO>, IAutorLivroAppService
    {
        private readonly IAutorlivroService _service;

        public AutorLivroAppService(IAutorlivroService service)
        :base(service)
        {
            _service = service;
        }
    }
}
