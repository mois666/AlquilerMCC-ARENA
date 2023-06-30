using mccArena.Controllers;
using mccArena.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mccArena.Views.UserControls
{
    public partial class UsuarioUserControl : UserControl
    {
        UsuarioController _usuarioController = new UsuarioController();
        public UsuarioUserControl()
        {
            InitializeComponent();
            usuarioBindingSource.DataSource = _usuarioController.GetUsuarios();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string par = txtBuscar.Text.Trim();
            //usuarioBindingSource.DataSource = _usuarioController.Search(par);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            pnlFormulario.Enabled = true;
            usuarioBindingSource.AddNew();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            pnlFormulario.Enabled = false;
            usuarioBindingSource.CancelEdit();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var usuario = (Usuario)usuarioBindingSource.Current;
            _usuarioController.Create(usuario);
            pnlFormulario.Enabled = false;_usuarioController.GetUsuarios();
           
        }
    }
}
