using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gimnasio_IronStrong_Fitness.Models
{
    public class Material
    {
        [Key]
        public int IdMaterial { get; set; }
        [Required]
        public string NombreMaterial { get; set; }
        [Required]
        public double PrecioMaterial { get; set; }
        [Required]
        public string DescripcionMaterial { get; set; }
        [Required]
        public string TipoMaterial { get; set; }
        //Muchos materiales tienen una suscripcion
        public Suscripcion Suscripcion { get; set; }
    }
}
