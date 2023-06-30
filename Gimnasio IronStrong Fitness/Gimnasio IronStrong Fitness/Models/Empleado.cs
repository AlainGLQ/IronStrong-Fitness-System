using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gimnasio_IronStrong_Fitness.Models
{
    public class Empleado
    {
        [Key]
        public int IdEmpleado { get; set; }
        [Required]
        public string CargoEmpleado { get; set; }
        [Required]
        public double SueldoEmpleado { get; set;}
        [Required]
        public int CiEmpleado { get; set; }
        [Required]
        public string NombreEmpleado { get; set; }
        [Required]
        public int TelEmpleado { get; set; }

        //un empleado tiene muchas asistencias
        public List<Asistencia> Asistencia { get; set; }
    }
}
