using System;
namespace QualaApi.Models
{
	public class Sucursal
	{
		public int Codigo { get; set; }

        public string? Nombre { get; set; }
        public string? Descripcion { get; set; }

        public string? Direccion { get; set; }

        public string? Identificacion { get; set; }

        public DateTime FechaCreacion { get; set; }

        public int Moneda { get; set; }

        public double Latitud { get; set; }

        public double Longitud { get; set; }

        public string? Horario { get; set; }
    }
}

