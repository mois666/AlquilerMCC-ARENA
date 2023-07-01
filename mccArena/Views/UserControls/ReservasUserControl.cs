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
    public partial class ReservasUserControl : UserControl
    {

        ReservaController _reservaController = new ReservaController();
        bool _isNew = true;
        public ReservasUserControl()
        {
            InitializeComponent();
            reservaBindingSource.DataSource = _reservaController.GetReservas();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string par = txtBuscar.Text.Trim();
            reservaBindingSource.DataSource = _reservaController.Search(par);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            pnlFormulario.Enabled = true;
            reservaBindingSource.AddNew();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            pnlFormulario.Enabled = false;
            reservaBindingSource.CancelEdit();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Guardar();

        }

        private void Guardar()
        {

            var reserva = (Reserva)reservaBindingSource.Current;
            if (_isNew)
                _reservaController.Create(reserva);
            else
                _reservaController.Update(reserva);
            pnlFormulario.Enabled = false;
            reservaBindingSource.DataSource = _reservaController.GetReservas();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            _isNew = false;
            pnlFormulario.Enabled = true;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var reserva = (Reserva)reservaBindingSource.Current;
            DialogResult dlr = MessageBox.Show("Seguro que quiere eliminar?", "MCCARENA", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dlr == DialogResult.OK)
            {
                MessageBox.Show("Neta me lo juras...!!?");
                _reservaController.Delete(reserva);
                reservaBindingSource.DataSource = _reservaController.GetReservas();
            }

        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            var reserva = (Reserva)reservaBindingSource.Current;
            if (_isNew)
                _reservaController.Create(reserva);
            else
                _reservaController.Update(reserva);
            pnlFormulario.Enabled = false;
            reservaBindingSource.DataSource = _reservaController.GetReservas();
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            pnlFormulario.Enabled = false;
            reservaBindingSource.CancelEdit();
        }
    }
}
