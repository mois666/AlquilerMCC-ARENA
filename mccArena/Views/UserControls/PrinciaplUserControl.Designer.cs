namespace mccArena.UserControls
{
    partial class PrinciaplUserControl
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
            this.btnIniciarSesion = new System.Windows.Forms.Button();
            this.dgvHorasDisponibles = new System.Windows.Forms.DataGridView();
            this.no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horasDisponibles = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHorasDisponibles)).BeginInit();
            this.SuspendLayout();
            // 
            // btnIniciarSesion
            // 
            this.btnIniciarSesion.BackColor = System.Drawing.Color.ForestGreen;
            this.btnIniciarSesion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnIniciarSesion.Location = new System.Drawing.Point(640, 3);
            this.btnIniciarSesion.Name = "btnIniciarSesion";
            this.btnIniciarSesion.Size = new System.Drawing.Size(104, 33);
            this.btnIniciarSesion.TabIndex = 3;
            this.btnIniciarSesion.Text = "Iniciar Sesión";
            this.btnIniciarSesion.UseVisualStyleBackColor = false;
            // 
            // dgvHorasDisponibles
            // 
            this.dgvHorasDisponibles.AllowUserToDeleteRows = false;
            this.dgvHorasDisponibles.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvHorasDisponibles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHorasDisponibles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.no,
            this.horasDisponibles});
            this.dgvHorasDisponibles.Location = new System.Drawing.Point(23, 42);
            this.dgvHorasDisponibles.Name = "dgvHorasDisponibles";
            this.dgvHorasDisponibles.ReadOnly = true;
            this.dgvHorasDisponibles.Size = new System.Drawing.Size(721, 323);
            this.dgvHorasDisponibles.TabIndex = 2;
            // 
            // no
            // 
            this.no.HeaderText = "No.";
            this.no.Name = "no";
            this.no.ReadOnly = true;
            // 
            // horasDisponibles
            // 
            this.horasDisponibles.HeaderText = "Horas Disponibles";
            this.horasDisponibles.Name = "horasDisponibles";
            this.horasDisponibles.ReadOnly = true;
            this.horasDisponibles.Width = 500;
            // 
            // PrinciaplUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnIniciarSesion);
            this.Controls.Add(this.dgvHorasDisponibles);
            this.Name = "PrinciaplUserControl";
            this.Size = new System.Drawing.Size(767, 374);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHorasDisponibles)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnIniciarSesion;
        private System.Windows.Forms.DataGridView dgvHorasDisponibles;
        private System.Windows.Forms.DataGridViewTextBoxColumn no;
        private System.Windows.Forms.DataGridViewTextBoxColumn horasDisponibles;
    }
}
