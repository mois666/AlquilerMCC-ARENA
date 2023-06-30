using mccArena.Models;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace mccArena.Context
{
    public partial class ModelMCCArena : DbContext
    {
        public ModelMCCArena()
            : base("name=ModelMCCArena")
        {
        }
        public virtual DbSet<Usuario> Usuario { get; set; }
        public virtual DbSet<Cancha> Cancha { get; set; }
        public virtual DbSet<Cliente> Cliente { get; set; }
        public virtual DbSet<Reserva> Reserva { get; set; }

        /*protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }*/
    }
}
