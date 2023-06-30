using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gimnasio_IronStrong_Fitness.Models
{
    public class Asistencia
    {
        [Key]
        public int IdAsistencia { get; set; }
        [Required]
        public bool EstadoAsistencia { get; set; }
        [Required]
        public DateTime FechaAsistencia { get; set; }
        [Required]
        public string TipoAsistencia { get; set; }

        //Muchas asistencias tiene un usuario
        public Usuario Usuario { get; set; }

        //Muchas asistencias tiene un empleado
        public Empleado Empleado { get; set; }

        //Muchas asistencias se registran en una suscripcion
        public Suscripcion Suscripcion { get; set; }
    }
}
