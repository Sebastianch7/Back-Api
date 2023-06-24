using System;
using System.ComponentModel.DataAnnotations;

namespace QualaApi.Models
{
	public class Sucursal
    {
        [Key]
        public int Codigo { get; set; }

        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        public string Direccion { get; set; }

        public string Identificacion { get; set; }

        public int IdMoneda { get; set; }

        public double? Latitud { get; set; }

        public double? Longitud { get; set; }

        public string? Horario { get; set; }

        public string? Telefono { get; set; }

        public DateTime fechaCreacion { get; set; }
    }
}

