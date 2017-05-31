using AutoMapper;
using SysLibrary.AppService.DTOs;
using SysLibrary.Domain.Entities;
using SysLibrary.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;
using SysLibrary.AppService.AppServices.Interfaces;

namespace SysLibrary.AppService.AppServices.AppServices
{
    public class AdminAppService: IAdminAppService
    {

        private readonly IAdminService _service;

        public AdminAppService(IAdminService service)
        {
            _service = service;
        }

        public AdminDTO getById(int id)
        {
            var admin = _service.GetById(id);

            var teste = Mapper.Map< Admin, AdminDTO>(admin);

            return teste;


        }
    }
}
