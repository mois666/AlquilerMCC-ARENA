using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mccArena.Views.UserControls
{
    public partial class ReporteUserControl : UserControl
    {
        public ReporteUserControl()
        {
            InitializeComponent();
        }
        Bitmap bmp;
        private void btnImprimir_Click(object sender, EventArgs e)
        {
            Graphics myGraphics = this.CreateGraphics();
            Size s = this.Size;
            bmp = new Bitmap(s.Width, s.Height, myGraphics);
            Graphics memoryGraphics = Graphics.FromImage(bmp);
            memoryGraphics.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, s);

            //printDocument1.Print();



            /*Graphics g = this.CreateGraphics();
            bmp = new Bitmap(this.Size.Width, this.Size.Height, g);
            Graphics mg = Graphics.FromImage(bmp);
            mg.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, this.Size);*/
            printPreviewDialog1.ShowDialog(this);
        }
        
        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
        }

        private void ReporteUserControl_Load(object sender, EventArgs e)
        {
            dgvReporte.Rows.Add("1", "08:00 - 10:00", "Juan Maraza", "67239563");
            dgvReporte.Rows.Add("2", "12:00 - 13:00", "Familia Choque", "60054555");
            dgvReporte.Rows.Add("3", "14:00 - 16:00", "Leo Mendez", "S/N");
            dgvReporte.Rows.Add("4", "16:00 - 19:00", "Willy Mamani", "70054011");
            dgvReporte.Rows.Add("5", "19:00 - 21:00", "Sebastian", "61234122");

        }
    }
}
