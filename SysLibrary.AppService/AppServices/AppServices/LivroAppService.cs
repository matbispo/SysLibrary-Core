using System;
using System.Collections.Generic;
using System.Text;
using SysLibrary.AppService.DTOs;
using SysLibrary.Domain.Entities;
using SysLibrary.Domain.Interfaces.Services;
using SysLibrary.AppService.AppServices.Interfaces;

namespace SysLibrary.AppService.AppServices.AppServices
{
    public class LivroAppService : AppServiceBase<Livro, LivroDTO>, ILivroAppService
    {
        private readonly ILivroService _service;

        public LivroAppService(ILivroService service)
        :base(service)
        {
            _service = service;
        }
    }
}
