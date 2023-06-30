using System.Data;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mccArena.Models
{
    public class Usuario : ConnectionToMySql
    {
        public int Id { get; set; }
        public string Cuenta { get; set; }
        public string Clave { get; set;}

        public List<Cancha> canchas { get; set; }

        
        /*public MySqlConnection GetUsuarios()
        {
           
        }*/
    }
}
