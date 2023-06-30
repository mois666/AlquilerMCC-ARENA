using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mccArena.Models
{
    public class Cancha
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Ubicacion { get; set; }
        public Usuario Usuario { get; set; }

    }
}
