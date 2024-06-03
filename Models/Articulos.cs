using System.ComponentModel.DataAnnotations;

namespace Ap1_P1_erick.Models
{
    public class Articulos
    {
        [Key]



        public  int ArticulosId { get; set; }
        [Required(ErrorMessage = "este campo es obligatorio")]
        public string Descripcion { get; set; }

        [Required  (ErrorMessage ="este campo es obligatorio")]
        public decimal? Costo { get; set; }
        [Required(ErrorMessage = "este campo es obligatorio")]
        public decimal ? ganacia { get; set; }
        [Required(ErrorMessage = "este campo es obligatorio")]
        public decimal? precio { get; set; }/// ganacia , precio

    }
}
