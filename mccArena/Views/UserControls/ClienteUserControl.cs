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
    public partial class ClienteUserControl : UserControl
    {

        ClienteController _clienteController = new ClienteController();
        bool _isNew = true;
        public ClienteUserControl()
        {
            InitializeComponent();
            clienteBindingSource.DataSource = _clienteController.GetClientes();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            pnlFormulario.Enabled = true;
            clienteBindingSource.AddNew();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string par = txtBuscar.Text.Trim();
            clienteBindingSource.DataSource = _clienteController.Search(par);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            _isNew = false;
            pnlFormulario.Enabled = true;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var cliente = (Cliente)clienteBindingSource.Current;
            DialogResult dlr = MessageBox.Show("Seguro que quiere eliminar?", "MCCARENA", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dlr == DialogResult.OK)
            {
                MessageBox.Show("Neta me lo juras...!!?");
                _clienteController.Delete(cliente);
                clienteBindingSource.DataSource = _clienteController.GetClientes();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Guardar();

        }

        private void Guardar()
        {

            var cliente = (Cliente)clienteBindingSource.Current;
            if (_isNew)
                _clienteController.Create(cliente);
            else
                _clienteController.Update(cliente);
            pnlFormulario.Enabled = false;
            clienteBindingSource.DataSource = _clienteController.GetClientes();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            pnlFormulario.Enabled = false;
            clienteBindingSource.CancelEdit();
        }
    }
}
