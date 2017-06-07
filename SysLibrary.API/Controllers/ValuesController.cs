using System;
using SysLibrary.AppService.AppServices.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;



namespace SysLibrary.API.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        private readonly IAdminAppService _admContext;

        public ValuesController(IAdminAppService admContext)
        {
            _admContext = admContext;
        }

        // GET api/values
        [HttpGet]
        public JsonResult Get() 
        {            
            JsonResult ad;

            try
            {
                // var teste = _admContext.GetById(1);
                var teste = _admContext.GetAll();

                ad = new JsonResult(teste);

            }
            catch (Exception)
            {
                throw;
            }

            return ad; 
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
