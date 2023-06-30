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
    public partial class CanchaUserControl : UserControl
    {
        CanchaController _canchaController = new CanchaController();
        bool _isNew = true;
        public CanchaUserControl()
        {
            InitializeComponent();
            canchaBindingSource.DataSource = _canchaController.GetCanchas();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            pnlFormulario.Enabled = true;
            canchaBindingSource.AddNew();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string par = txtBuscar.Text.Trim();
            canchaBindingSource.DataSource = _canchaController.Search(par);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            _isNew = false;
            pnlFormulario.Enabled = true;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var cancha = (Cancha)canchaBindingSource.Current;
            DialogResult dlr = MessageBox.Show("Seguro que quiere eliminar?", "MCCARENA", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dlr == DialogResult.OK)
            {
                MessageBox.Show("Neta me lo juras...!!?");
                _canchaController.Delete(cancha);
                canchaBindingSource.DataSource = _canchaController.GetCanchas();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Guardar();

        }

        private void Guardar()
        {

            var cancha = (Cancha)canchaBindingSource.Current;
            if (_isNew)
                _canchaController.Create(cancha);
            else
                _canchaController.Update(cancha);
            pnlFormulario.Enabled = false;
            canchaBindingSource.DataSource = _canchaController.GetCanchas();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            pnlFormulario.Enabled = false;
            canchaBindingSource.CancelEdit();
        }
    }
}
