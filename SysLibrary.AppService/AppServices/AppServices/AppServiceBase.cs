using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using SysLibrary.AppService.AppServices.Interfaces;
using SysLibrary.Domain.Interfaces.Services;
using SysLibrary.AppService.MapperConfig;
using SysLibrary.Domain.Entities;
using SysLibrary.AppService.DTOs;

namespace SysLibrary.AppService.AppServices.AppServices
{
    public class AppServiceBase<tEntity, TDTO> : IAppServiceBase<tEntity, TDTO> where tEntity : class
    {
        private readonly IServiceBase<tEntity> _service;

        public AppServiceBase(IServiceBase<tEntity> service)
        {
            _service = service;
        }

        public bool Save(TDTO dto)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TDTO> GetAll()
        {
            throw new NotImplementedException();
        }

        public TDTO GetById(int id)
        {

            throw new NotImplementedException();

        }

        public bool Delete(TDTO dto)
        {
            throw new NotImplementedException();
        }

    }
}
