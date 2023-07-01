using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mccArena.UserControls
{
    public partial class PrinciaplUserControl : UserControl
    {
        public PrinciaplUserControl()
        {
            InitializeComponent();

            dgvHorasDisponibles.Rows.Add("1", "08:00");
            dgvHorasDisponibles.Rows.Add("2", "09:00");
            dgvHorasDisponibles.Rows.Add("3", "10:00");
            dgvHorasDisponibles.Rows.Add("4", "12:00");
            dgvHorasDisponibles.Rows.Add("5", "14:00");
            dgvHorasDisponibles.Rows.Add("6", "15:00");
            dgvHorasDisponibles.Rows.Add("7", "16:00");
            dgvHorasDisponibles.Rows.Add("8", "17:00");
            dgvHorasDisponibles.Rows.Add("9", "18:00");
            dgvHorasDisponibles.Rows.Add("10", "23:00");
        }
    }
}
