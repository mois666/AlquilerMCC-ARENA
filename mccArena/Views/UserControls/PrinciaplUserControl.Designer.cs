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
            this.dgvHorasDisponibles = new System.Windows.Forms.DataGridView();
            this.no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horasDisponibles = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHorasDisponibles)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvHorasDisponibles
            // 
            this.dgvHorasDisponibles.AllowUserToDeleteRows = false;
            this.dgvHorasDisponibles.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvHorasDisponibles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHorasDisponibles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.no,
            this.horasDisponibles});
            this.dgvHorasDisponibles.Location = new System.Drawing.Point(17, 15);
            this.dgvHorasDisponibles.Margin = new System.Windows.Forms.Padding(4);
            this.dgvHorasDisponibles.Name = "dgvHorasDisponibles";
            this.dgvHorasDisponibles.ReadOnly = true;
            this.dgvHorasDisponibles.Size = new System.Drawing.Size(652, 536);
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(723, 84);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(222, 46);
            this.button1.TabIndex = 3;
            this.button1.Text = "HORARIOS DISPONIBLES";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(723, 147);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(222, 46);
            this.button2.TabIndex = 4;
            this.button2.Text = "MODIFICAR HORARIO";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(723, 218);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(222, 46);
            this.button3.TabIndex = 5;
            this.button3.Text = "ELIMINAR HORARIO";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // PrinciaplUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvHorasDisponibles);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PrinciaplUserControl";
            this.Size = new System.Drawing.Size(992, 630);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHorasDisponibles)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvHorasDisponibles;
        private System.Windows.Forms.DataGridViewTextBoxColumn no;
        private System.Windows.Forms.DataGridViewTextBoxColumn horasDisponibles;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}
