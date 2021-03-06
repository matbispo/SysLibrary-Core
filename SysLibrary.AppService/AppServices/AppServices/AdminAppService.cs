﻿using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using SysLibrary.AppService.DTOs;
using SysLibrary.Domain.Entities;
using SysLibrary.Domain.Interfaces.Services;
using SysLibrary.AppService.AppServices.Interfaces;

namespace SysLibrary.AppService.AppServices.AppServices
{
    public class AdminAppService: AppServiceBase<Admin,AdminDTO> ,IAdminAppService
    {

        private readonly IAdminService _service;

        public AdminAppService(IAdminService service)
        :base(service)
        {
            _service = service;
        }
    }
}
