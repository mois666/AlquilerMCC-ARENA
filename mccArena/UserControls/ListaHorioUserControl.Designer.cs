namespace mccArena.UserControls
{
    partial class ListaHorioUserControl
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.hora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumeroCelular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnHorariosDispoibles = new System.Windows.Forms.Button();
            this.btnModificarHorario = new System.Windows.Forms.Button();
            this.btnEliminarHorario = new System.Windows.Forms.Button();
            this.btnReportes = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.hora,
            this.fecha,
            this.nombre,
            this.Apellidos,
            this.NumeroCelular});
            this.dataGridView1.Location = new System.Drawing.Point(24, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(543, 323);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // hora
            // 
            this.hora.HeaderText = "HORA";
            this.hora.Name = "hora";
            // 
            // fecha
            // 
            this.fecha.HeaderText = "FECHA";
            this.fecha.Name = "fecha";
            // 
            // nombre
            // 
            this.nombre.HeaderText = "NOMBRE";
            this.nombre.Name = "nombre";
            // 
            // Apellidos
            // 
            this.Apellidos.HeaderText = "APELLIDOS";
            this.Apellidos.Name = "Apellidos";
            // 
            // NumeroCelular
            // 
            this.NumeroCelular.HeaderText = "NUMERO DE CELULAR";
            this.NumeroCelular.Name = "NumeroCelular";
            // 
            // btnHorariosDispoibles
            // 
            this.btnHorariosDispoibles.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnHorariosDispoibles.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnHorariosDispoibles.Location = new System.Drawing.Point(603, 60);
            this.btnHorariosDispoibles.Name = "btnHorariosDispoibles";
            this.btnHorariosDispoibles.Size = new System.Drawing.Size(132, 33);
            this.btnHorariosDispoibles.TabIndex = 4;
            this.btnHorariosDispoibles.Text = "Horarios Disponibles";
            this.btnHorariosDispoibles.UseVisualStyleBackColor = false;
            // 
            // btnModificarHorario
            // 
            this.btnModificarHorario.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnModificarHorario.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnModificarHorario.Location = new System.Drawing.Point(603, 113);
            this.btnModificarHorario.Name = "btnModificarHorario";
            this.btnModificarHorario.Size = new System.Drawing.Size(132, 33);
            this.btnModificarHorario.TabIndex = 5;
            this.btnModificarHorario.Text = "Modificar Horario";
            this.btnModificarHorario.UseVisualStyleBackColor = false;
            // 
            // btnEliminarHorario
            // 
            this.btnEliminarHorario.BackColor = System.Drawing.Color.LightCoral;
            this.btnEliminarHorario.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnEliminarHorario.Location = new System.Drawing.Point(603, 166);
            this.btnEliminarHorario.Name = "btnEliminarHorario";
            this.btnEliminarHorario.Size = new System.Drawing.Size(132, 33);
            this.btnEliminarHorario.TabIndex = 6;
            this.btnEliminarHorario.Text = "Eliminar Horario";
            this.btnEliminarHorario.UseVisualStyleBackColor = false;
            this.btnEliminarHorario.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnReportes
            // 
            this.btnReportes.BackColor = System.Drawing.Color.Khaki;
            this.btnReportes.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnReportes.Location = new System.Drawing.Point(603, 316);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Size = new System.Drawing.Size(132, 33);
            this.btnReportes.TabIndex = 7;
            this.btnReportes.Text = "REPORTES";
            this.btnReportes.UseVisualStyleBackColor = false;
            this.btnReportes.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // ListaHorioUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnReportes);
            this.Controls.Add(this.btnEliminarHorario);
            this.Controls.Add(this.btnModificarHorario);
            this.Controls.Add(this.btnHorariosDispoibles);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ListaHorioUserControl";
            this.Size = new System.Drawing.Size(767, 374);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn hora;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroCelular;
        private System.Windows.Forms.Button btnHorariosDispoibles;
        private System.Windows.Forms.Button btnModificarHorario;
        private System.Windows.Forms.Button btnEliminarHorario;
        private System.Windows.Forms.Button btnReportes;
    }
}
