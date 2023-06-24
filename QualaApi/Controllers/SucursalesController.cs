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
        // GET: api/values
        [HttpGet]
        public List<Sucursal> Get()
        {
            List<Sucursal> sucursales = new List<Sucursal>
            {
                new Sucursal
                {
                    Codigo = 1,
                    Descripcion = "Prueba de sebas",
                    Direccion = "Cra 80 f # 54 a 77",
                    Identificacion = "1022399551",
                    FechaCreacion = DateTime.Now,
                    Moneda = 1,
                    Latitud = 51.505,
                    Longitud = -0.09,
                    Horario = "8:00am a 5:00pm",
                    Nombre = "Calle 80"
                },
                 new Sucursal
                {
                    Codigo = 2,
                    Descripcion = "Prueba de sebas",
                    Direccion = "Cra 80 f # 54 a 77",
                    Identificacion = "1022399551",
                    FechaCreacion = DateTime.Now,
                    Moneda = 1,
                    Latitud = 51.505,
                    Longitud = -0.08,
                    Horario = "8:00am a 5:00pm",
                    Nombre = "Calle 80"
                }
            };

            return sucursales;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public List<Sucursal> Get(int id)
        {
            List<Sucursal> sucursales = new List<Sucursal>
            {
                new Sucursal
                {
                Codigo = 5,
                Descripcion = "Prueba de sebas",
                Direccion = "Cra 80 f # 54 a 77",
                Identificacion = "1022399551",
                FechaCreacion = DateTime.Now,
                Moneda = 1,
                Latitud = 37.7749,
                Longitud = -122.4194,
                Horario = "8:00am a 5:00pm"
                }
            };

            return sucursales;
        }

        [HttpPost]
        public dynamic Post(Sucursal sucursal)
        {

            return null;
        }
        
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
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

