using Gimnasio_IronStrong_Fitness.Models;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Gimnasio_IronStrong_Fitness.Context
{
    public partial class ModelGimnasio : DbContext
    {
        public ModelGimnasio()
            : base("name=ModelGimnasio")
        {
        }
        //mapear a la base de datos
        public virtual DbSet<Usuario> Usuario { get; set; }
        public virtual DbSet<Cliente> Cliente { get; set; }
        public virtual DbSet<Empleado> Empleado { get; set; }
        public virtual DbSet<Asistencia> Asistencia { get; set; }
        public virtual DbSet<Material> Material { get; set; }
        public virtual DbSet<Suscripcion> Suscripcion { get; set; }
        public virtual DbSet<Compra> Compra { get; set; }
    }
}
