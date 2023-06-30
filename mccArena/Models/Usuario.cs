using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mccArena.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Cuenta { get; set; }
        public string Clave { get; set;}

        public List<Cancha> canchas { get; set; }
    }
}
