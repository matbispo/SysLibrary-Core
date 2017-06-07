using System;
using System.Collections.Generic;
using System.Text;
using SysLibrary.AppService.DTOs;
using SysLibrary.Domain.Entities;
using SysLibrary.Domain.Interfaces.Services;
using SysLibrary.AppService.AppServices.Interfaces;

namespace SysLibrary.AppService.AppServices.AppServices
{
    public class EditoraAppService : AppServiceBase<Editora, EditoraDTO>, IEditoraAppService
    {
        private readonly IEditoraService _service;

        public EditoraAppService(IEditoraService service)
        :base(service)
        {
            _service = service;
        }
    }
}
