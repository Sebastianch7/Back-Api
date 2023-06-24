using System.ComponentModel.DataAnnotations;

namespace QualaApi.Models
{
    public class ListMonedasClass
    {
        [Key]
        public int Id { get; set; }

        public string Nombre { get; set; }

        public string Simbolo { get; set; }
    }
}
