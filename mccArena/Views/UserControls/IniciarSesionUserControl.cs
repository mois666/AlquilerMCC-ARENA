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
    public partial class IniciarSesionUserControl : UserControl
    {
        public IniciarSesionUserControl()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            principal obj = new principal();
            obj.Visible = true;
        }
    }
}
