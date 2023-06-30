using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gimnasio_IronStrong_Fitness.Models
{
    //la clase tiene que ser public
    public class Usuario
    {
        [Key]
        public string CuentaUsuario { get; set; }
        [Required]
        public string NombreUsuario { get; set; }
        [Required]
        public string PasswordUsuario { get; set; }
        [Required]
        public string RolUsuario { get; set; }

        //integridad referencial
        //un usuario registra muchas suscripciones
        public List<Suscripcion> Suscripcion { get; set; }

        //un usuario registra muchas asistencias
        public List<Asistencia> Asistencia { get; set; }

        //un usuario registra muchas compras
        public List<Compra> Compras { get; set; }
    }
}
