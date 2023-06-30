using mccArena.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using mccArena.Views;

namespace mccArena.UserControls
{
    public partial class IniciarSesionUserControl : UserControl
    {
        public IniciarSesionUserControl()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string cuenta = txtUsuario.Text;
            string clave = txtClave.Text;
            if (string.IsNullOrEmpty(cuenta)|| string.IsNullOrEmpty(clave))
            {
                MessageBox.Show("Los campos son requeridos.");
            }
            else
            {
                UsuarioController obj = new UsuarioController();
                if (obj.AutenticarUsuario(cuenta, clave))
                {
                    //principal obj1 = new principal();
                    //obj1.Visible = false;
                    //PrinciaplUserControl uch = new PrinciaplUserControl();
                    //obj1.addControlsToPanel(uch);
                  
                    //MessageBox.Show("correctos.");
                    principal fr = new principal();
                    fr.Show();
                    //this.Hide();
                }
                else
                {
                    MessageBox.Show("Los datos son incorrectos.");
                }
                
            }

            
        }
    }
}
