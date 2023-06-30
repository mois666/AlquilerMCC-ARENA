namespace mccArena.UserControls
{
    partial class NuevoHorarioUserControl
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
            this.checkHorario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumeroCelular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPrincipal = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.checkHorario,
            this.hora,
            this.fecha,
            this.nombre,
            this.Apellidos,
            this.NumeroCelular});
            this.dataGridView1.Location = new System.Drawing.Point(32, 21);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1084, 393);
            this.dataGridView1.TabIndex = 1;
            // 
            // checkHorario
            // 
            this.checkHorario.HeaderText = "CHECK HORARIO";
            this.checkHorario.Name = "checkHorario";
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
            // btnPrincipal
            // 
            this.btnPrincipal.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnPrincipal.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnPrincipal.Location = new System.Drawing.Point(639, 438);
            this.btnPrincipal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPrincipal.Name = "btnPrincipal";
            this.btnPrincipal.Size = new System.Drawing.Size(198, 46);
            this.btnPrincipal.TabIndex = 5;
            this.btnPrincipal.Text = "Principal";
            this.btnPrincipal.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightGreen;
            this.button1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button1.Location = new System.Drawing.Point(888, 438);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(198, 46);
            this.button1.TabIndex = 6;
            this.button1.Text = "Reservar Horario";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // NuevoHorarioUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnPrincipal);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "NuevoHorarioUserControl";
            this.Size = new System.Drawing.Size(992, 630);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn checkHorario;
        private System.Windows.Forms.DataGridViewTextBoxColumn hora;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroCelular;
        private System.Windows.Forms.Button btnPrincipal;
        private System.Windows.Forms.Button button1;
    }
}
