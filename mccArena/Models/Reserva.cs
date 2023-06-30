using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mccArena.Models
{
    public class Reserva
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public DateTime Fecha { get; set; }
        public DateTime HoraInicio { get; set; }
        public DateTime HoraFinal { get; set; }

        public Cancha Cancha { get; set; } // id cancha
        public Cliente Cliente { get; set; }// id cliente
    }
}
