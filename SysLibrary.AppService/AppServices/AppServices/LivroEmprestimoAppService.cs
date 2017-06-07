using SysLibrary.AppService.AppServices.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using SysLibrary.AppService.DTOs;
using SysLibrary.Domain.Entities;
using SysLibrary.Domain.Interfaces.Services;

namespace SysLibrary.AppService.AppServices.AppServices
{
    public class LivroEmprestimoAppService : AppServiceBase<LivroEmprestimo, LivroEmprestimoDTO>, ILivroEmprestimoAppService
    {
        private readonly ILivroEmprestimoService _service;

        public LivroEmprestimoAppService(ILivroEmprestimoService service)
        :base(service)
        {
            _service = service;
        }
    }
}
