using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using teste_webmotors.Models;
using teste_webmotors.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace teste_webmotors.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MotorsController : ControllerBase
    {
        private readonly WebMotorService _webMotorServices;
        public MotorsController(WebMotorService webMotorServices)
        {
            _webMotorServices = webMotorServices;
        }

        // GET: api/<WebMotorController>
        [HttpGet]
        public IEnumerable<WebMotorsModel> Get()
        {
            return _webMotorServices.getAnunciosAll().ToList();
        }

        // GET api/<WebMotorController>/5
        [HttpGet("{id}")]
        public WebMotorsModel Get(int id)
        {
            return _webMotorServices.getAnuncioId(id);
        }

        // POST api/<WebMotorController>
        [HttpPost]
        public void Post(WebMotorsModel webmotors)
        {
            if(webmotors.ID > 0) {
                _webMotorServices.updateAnuncio(webmotors);
            }
            else
            {
                _webMotorServices.InsertAnuncio(webmotors);
            }
                                  
        }
        

        // DELETE api/<WebMotorController>/5
        [HttpDelete("{id}")]
        public IEnumerable<WebMotorsModel> Delete(int id)
        {
            _webMotorServices.deleteAnuncio(id);
            return _webMotorServices.getAnunciosAll().ToList();
        }

    }
}
