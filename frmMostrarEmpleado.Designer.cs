namespace pryGestionDeDatos
{
    partial class frmMostrarEmpleado
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnVolver = new System.Windows.Forms.Button();
            this.dtvEmpleados = new System.Windows.Forms.DataGridView();
            this.DNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Domicilio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTituloME = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtvEmpleados)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVolver
            // 
            this.btnVolver.BackgroundImage = global::pryGestionDeDatos.Properties.Resources.istockphoto_1186803754_170667a;
            this.btnVolver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVolver.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(264, 238);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(157, 33);
            this.btnVolver.TabIndex = 31;
            this.btnVolver.Text = "VOLVER ATRAS";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // dtvEmpleados
            // 
            this.dtvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvEmpleados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DNI,
            this.Apellido,
            this.Nombre,
            this.Edad,
            this.Domicilio});
            this.dtvEmpleados.Location = new System.Drawing.Point(74, 66);
            this.dtvEmpleados.Name = "dtvEmpleados";
            this.dtvEmpleados.Size = new System.Drawing.Size(556, 150);
            this.dtvEmpleados.TabIndex = 30;
            this.dtvEmpleados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtvEmpleados_CellContentClick);
            // 
            // DNI
            // 
            this.DNI.HeaderText = "DNI";
            this.DNI.Name = "DNI";
            // 
            // Apellido
            // 
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.Name = "Apellido";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Edad
            // 
            this.Edad.HeaderText = "Edad";
            this.Edad.Name = "Edad";
            // 
            // Domicilio
            // 
            this.Domicilio.HeaderText = "Domicilio";
            this.Domicilio.Name = "Domicilio";
            // 
            // lblTituloME
            // 
            this.lblTituloME.AutoSize = true;
            this.lblTituloME.BackColor = System.Drawing.Color.Transparent;
            this.lblTituloME.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloME.ForeColor = System.Drawing.Color.White;
            this.lblTituloME.Location = new System.Drawing.Point(53, 28);
            this.lblTituloME.Name = "lblTituloME";
            this.lblTituloME.Size = new System.Drawing.Size(215, 22);
            this.lblTituloME.TabIndex = 29;
            this.lblTituloME.Text = "Empleados Registrados";
            this.lblTituloME.Click += new System.EventHandler(this.label1_Click);
            // 
            // frmMostrarEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.BackgroundImage = global::pryGestionDeDatos.Properties.Resources.Fondos_de_Pantalla_Verdes;
            this.ClientSize = new System.Drawing.Size(718, 302);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.dtvEmpleados);
            this.Controls.Add(this.lblTituloME);
            this.Name = "frmMostrarEmpleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Empleados Registrados";
            this.Load += new System.EventHandler(this.frmMostrarEmpleado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtvEmpleados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.DataGridView dtvEmpleados;
        private System.Windows.Forms.Label lblTituloME;
        private System.Windows.Forms.DataGridViewTextBoxColumn DNI;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Edad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Domicilio;
    }
}