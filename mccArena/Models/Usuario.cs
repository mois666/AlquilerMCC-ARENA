using System.Data;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel.DataAnnotations;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Data.SqlClient;
using mccArena.Context;
using System.Configuration;

namespace mccArena.Models
{
    public class Usuario
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
        public bool VerificarUsuario(string cuenta, string clave)
        {
            //ModelMCCArena connectionString = new ModelMCCArena();
            string connectionString = ConfigurationManager.ConnectionStrings["ModelMCCArena"].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "SELECT COUNT(*) FROM Usuarios WHERE Cuenta = @Username AND Clave = @Password";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Username", cuenta);
            command.Parameters.AddWithValue("@Password", clave);

            connection.Open();
            int count = (int)command.ExecuteScalar();
            if (count > 0) return true;
            connection.Close();
            return false;
        }
    }
}
