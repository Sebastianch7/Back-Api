using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using QualaApi.Models;

namespace QualaApi.Controllers
{
    [Route("api/[controller]")]
    public class SucursalesController : Controller
    {
        List<Sucursal> sucursalesDB = new List<Sucursal>
            {
                new Sucursal
                {
                    Id = 1,
                    Codigo = 42342432,
                    Descripcion = "Normandia",
                    Direccion = "Piso 7",
                    Identificacion = "1022399551",
                    Moneda = 1,
                    Latitud = 51.505,
                    Longitud = -0.09,
                    Horario = "8:00am a 5:00pm",
                    Nombre = "Calle 80"
                },
                 new Sucursal
                {
                     Id = 2,
                    Codigo = 23110002,
                    Descripcion = "Chapinero",
                    Direccion = "Carrera 63 # 54",
                    Identificacion = "1022399551",
                    Moneda = 1,
                    Latitud = 51.505,
                    Longitud = -0.08,
                    Horario = "8:00am a 5:00pm",
                    Nombre = "Calle 80"
                }
            };

        // GET: api/values
        [HttpGet]
        public List<Sucursal> Get()
        {
            return sucursalesDB;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public dynamic Get(int id)
        {
            var item = sucursalesDB.Find(x => x.Id == id);
            if(item == null)
                return BadRequest("Sucursal no encontrada");

            return Ok(item);
        }

        [HttpPost]
        public dynamic Post(Sucursal sucursal)
        {
            sucursalesDB.Add(sucursal);
            return Ok();
        }
        
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
            var item = sucursalesDB.Find(x => x.Id == id);
            if (item == null)
                BadRequest("Sucursal no encontrada");
        }

        [HttpDelete("{id}")]
        public object Delete(int id)
        {
            String token = Request.Headers.Where(x => x.Key == "Authorization").FirstOrDefault().Value;

            return new
            {
                success = 400
            };
        }
    }
}

