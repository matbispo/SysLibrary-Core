using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SysLibrary.AppService.AppServices.Interfaces;
using SysLibrary.AppService.DTOs;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SysLibrary.API.Controllers
{
    [Route("api/[controller]")]
    public class AdminController : Controller
    {
        private readonly IAdminAppService _admContext;

        public AdminController(IAdminAppService admContext)
        {
            _admContext = admContext;
        }

        // GET: api/values
        [HttpGet]
        public JsonResult GetAll()
        {
            JsonResult jr = null;

            try
            {
                var listEtt = _admContext.GetAll();
                jr = new JsonResult(listEtt);
            }
            catch (Exception)
            {
                throw;
            }

            return jr;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public JsonResult GetById(int id)
        {
            JsonResult jr = null;

            try
            {
                var entt = _admContext.GetById(id);
                jr = new JsonResult(entt);
            }
            catch (Exception)
            {
                throw;
            }

            return jr;
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]AdminDTO admin)
        {
            _admContext.Add(admin);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]AdminDTO admin)
        {
            _admContext.Update(admin);
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            try
            {
                // depois alterar esse excluir para passar so o id e verificar se o objeto existe
                var entt = _admContext.GetById(id);
                _admContext.Delete(entt);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
