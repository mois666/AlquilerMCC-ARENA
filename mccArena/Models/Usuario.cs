using System.Data;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel.DataAnnotations;

namespace mccArena.Models
{
    public class Usuario : ConnectionToMySql
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        public string Cuenta { get; set; }
        [Required]
        public string Clave { get; set;}

        public List<Cancha> canchas { get; set; }

        
        /*public MySqlConnection GetUsuarios()
        {
           
        }*/
    }
}
