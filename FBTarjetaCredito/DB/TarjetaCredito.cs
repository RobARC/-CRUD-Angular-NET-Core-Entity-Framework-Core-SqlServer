using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DB
{
    public class TarjetaCredito
    {
        [Required]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public String Titular { get; set; }
        [Required]
        public String NumeroTarjeta { get; set; }
        [Required]
        public String FechaExpiracion { get; set; }
        [Required]
        public String CVV { get; set; }

    }
}
