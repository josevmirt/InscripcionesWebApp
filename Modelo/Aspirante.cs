using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace InscripcionesWebApp.Modelo
{
    [Table("Aspirantes")]
    public class Aspirante
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        [StringLength(20)]
        public String Nombre { get; set; }

        [Required]
        [StringLength(20)]
        public String Apellido { get; set; }

        [Required]
        public int Edad { get; set; }

        [Required]
        [StringLength(20)]
        public String Casa { get; set; }
    }
}
