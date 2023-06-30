using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gimnasio_IronStrong_Fitness.Models
{
    public class Compra
    {
        [Key]
        public int IdCompra { set; get; }
        [Required]
        public int CantidadCompra { set; get; }
        [Required]
        public string DetalleCompra { set; get; }
        [Required]
        public DateTime FechaCompra { set; get;}
        [Required]
        public double PrecioCompra { set; get; }

        //Muchas compras tienen un usuario
        public Usuario Usuario { get; set; }
    }
}
