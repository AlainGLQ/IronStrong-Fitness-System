using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gimnasio_IronStrong_Fitness.Models
{
    public class Suscripcion
    {
        [Key]
        public int IdSuscripcion { get; set; }
        [Required]
        public DateTime FechaInicioSuscripcion { get; set; }
        [Required]
        public bool EstadoSuscripcion { get; set; }
        [Required]
        public string PlanSuscripcion { get; set; }
        
        //Clave foranea
        //Muchas suscripciones tienen un usuario
        public Usuario Usuario { get; set; }
        
        //Muchas suscripciones tienen un cliente
        public Cliente Cliente { get; set; }

        //Una suscripcion tiene muchos materiales
        public List<Material> Material { get; set; }

        //Una suscripcion tiene muchas asistencias
        public List<Asistencia> Asistencia { get; set; }  
            
    }
}
