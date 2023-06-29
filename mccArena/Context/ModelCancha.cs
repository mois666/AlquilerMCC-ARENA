﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace mccArena.Context
{
    public class ModelCancha
    {
        MySqlConnection conn = new MySqlConnection();
        string connectionString = ConfigurationManager.ConnectionStrings["MyDatabaseCS"].ConnectionString;
        public MySqlConnection establecerConexion()
        {
            try
            {
                conn.ConnectionString = connectionString;
                conn.Open();
                MessageBox.Show("Conexion");
            }
            catch (MySqlException e)
            {
                MessageBox.Show("No hay conexion con la bd "+e.ToString());

            }
          return conn;
        }
    }
}
