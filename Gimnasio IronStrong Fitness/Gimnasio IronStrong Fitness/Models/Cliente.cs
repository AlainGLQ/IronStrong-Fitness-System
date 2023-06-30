using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gimnasio_IronStrong_Fitness.Models
{
    public class Cliente
    {
        [Key]
        public int IdCliente { get; set; }
        [Required]
        public int CiCliente { get; set; }
        [Required]
        public string NombreCliente { get; set; }
        [Required]
        public int TelCliente { get; set; }

        //integridad referencial
        //un cliente tiene muchas suscripciones
        public List<Suscripcion> Suscripcion { get; set; }
    }
}
