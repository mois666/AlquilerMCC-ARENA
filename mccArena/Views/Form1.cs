using mccArena.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//refe
using mccArena.UserControls;
using mccArena.Views.UserControls;
using mccArena.Controllers;

namespace mccArena
{
    public partial class principal : Form
    {
        public principal()
        {
            InitializeComponent();
            string sesion = UsuarioController._sesionUsuario;
            //pnlSideBar.Visible = true;
            
            if(sesion == "")
            {
                IniciarSesionUserControl uch = new IniciarSesionUserControl();
                addControlsToPanel(uch);
            }
            else
            {
                lblNombreUsuario.Text = sesion.ToUpper();
                lblNombreUsuario.Visible = true;
                btnAbrirIniciarSesion.Visible = false;
                pnlSideBar.Visible = true;
                moveSidePanel(btnPrincipal);
                PrinciaplUserControl uch = new PrinciaplUserControl();
                addControlsToPanel(uch);
            }

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            ModelCancha modelCancha = new ModelCancha();
            //modelCancha.establecerConexion();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
        private void moveSidePanel(Control btn)
        {
            pnlActive.Top = btn.Top;
            pnlActive.Height = btn.Height;
        }
        public void addControlsToPanel(Control c)
        {
            c.Dock = DockStyle.Fill;
            pnlBody.Controls.Clear();
            pnlBody.Controls.Add(c);
        }
        private void btnPrincipal_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnPrincipal);
            PrinciaplUserControl uch = new PrinciaplUserControl();
            addControlsToPanel(uch);

        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnUsuario);
            UsuarioUserControl uch = new UsuarioUserControl();
            addControlsToPanel(uch);
        }

        private void btnAbrirIniciarSesion_Click(object sender, EventArgs e)
        {
            IniciarSesionUserControl uch = new IniciarSesionUserControl();
            addControlsToPanel(uch);
        }

        private void button2_Click(object sender, EventArgs e)// Cliente
        {
            moveSidePanel(button2);
            ClienteUserControl uch = new ClienteUserControl();
            addControlsToPanel(uch);
        }

        private void button3_Click(object sender, EventArgs e) //Cancha
        {
            moveSidePanel(button3);
            CanchaUserControl uch = new CanchaUserControl();
            addControlsToPanel(uch);
        }

        private void btnReserva_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnReserva);
            ReservasUserControl uch = new ReservasUserControl();
            addControlsToPanel(uch);
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnReporte);
            ReporteUserControl uch = new ReporteUserControl();
            addControlsToPanel(uch);
        }

        private void btnSincronizar_Click(object sender, EventArgs e)
        {
            ModelMCCArena db = new ModelMCCArena();
            var usuarios = db.Usuario.ToList();
            var canchas = db.Cancha.ToList();
            var clientes = db.Cliente.ToList();
            var reservas = db.Reserva.ToList();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            UsuarioController._sesionUsuario = "";
            this.Dispose();
            
        }
    }
}
