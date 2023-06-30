namespace mccArena.UserControls
{
    partial class RegistroUserControl
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnReservar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Red;
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnCancelar.Location = new System.Drawing.Point(381, 420);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(198, 46);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnReservar
            // 
            this.btnReservar.BackColor = System.Drawing.Color.SeaGreen;
            this.btnReservar.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnReservar.Location = new System.Drawing.Point(648, 420);
            this.btnReservar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnReservar.Name = "btnReservar";
            this.btnReservar.Size = new System.Drawing.Size(198, 46);
            this.btnReservar.TabIndex = 7;
            this.btnReservar.Text = "Reservar";
            this.btnReservar.UseVisualStyleBackColor = false;
            // 
            // RegistroUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnReservar);
            this.Controls.Add(this.btnCancelar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "RegistroUserControl";
            this.Size = new System.Drawing.Size(992, 630);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnReservar;
    }
}
