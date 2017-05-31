using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using SysLibrary.AppService.DTOs;
using SysLibrary.Domain.Entities;

namespace SysLibrary.AppService.MapperConfig
{
    public class AutoMapperConfig : Profile
    {
          public AutoMapperConfig()
          {
              CreateMap<AdminDTO, Admin>();
            CreateMap<Admin, AdminDTO>();
        }
    }
}
