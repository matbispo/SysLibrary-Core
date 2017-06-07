using System;
using System.Collections.Generic;
using System.Text;
using SysLibrary.AppService.DTOs;
using SysLibrary.Domain.Entities;
using SysLibrary.Domain.Interfaces.Services;
using SysLibrary.AppService.AppServices.Interfaces;

namespace SysLibrary.AppService.AppServices.AppServices
{
    public class EmprestimoAppService : AppServiceBase<Emprestimo, EmprestimoDTO>, IEmprestimoAppService
    {
        private readonly IEmprestimoService _service;

        public EmprestimoAppService(IEmprestimoService service)
        :base(service)
        {
            _service = service;
        }
    }
}
