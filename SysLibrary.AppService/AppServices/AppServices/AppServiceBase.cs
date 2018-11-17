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

        public void Add(TDTO dto)
        {
            var entity = Mapper.Map<TDTO, tEntity>(dto);
            _service.add(entity);
        }

        public void Update(TDTO dto)
        {
            var entity = Mapper.Map<TDTO, tEntity>(dto);
            _service.Update(entity);
        }

        public IEnumerable<TDTO> GetAll()
        {
            var listEntt = _service.GetAll();
            ICollection<TDTO> itens = new List<TDTO>();

            foreach (var item in listEntt)
            {
                itens.Add(Mapper.Map<tEntity, TDTO>(item));
            }

            return itens;
        }

        public TDTO GetById(int id)
        {
            var entt = _service.GetById(id);
            var mapDto = Mapper.Map<tEntity, TDTO>(entt);
            return mapDto;   
        }

        public void Delete(TDTO dto)
        {
            var entity = Mapper.Map<TDTO, tEntity>(dto);
            _service.Remove(entity);
        }
    }
}
