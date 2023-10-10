namespace pryGestionDeDatos
{
    partial class frmBuscarCliente
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
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblDepartamento = new System.Windows.Forms.Label();
            this.lblProvincia = new System.Windows.Forms.Label();
            this.lblApellidoEnc = new System.Windows.Forms.Label();
            this.lblDepartamentoEnc = new System.Windows.Forms.Label();
            this.lblProvEnc = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.lblDomicilio = new System.Windows.Forms.Label();
            this.lblEdad = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDomicilioEnc = new System.Windows.Forms.Label();
            this.lblEdadEnc = new System.Windows.Forms.Label();
            this.lblDniBuscado = new System.Windows.Forms.Label();
            this.lblNombreEnc = new System.Windows.Forms.Label();
            this.lblDatosEnc = new System.Windows.Forms.Label();
            this.lblTituloBC = new System.Windows.Forms.Label();
            this.txtDniBuscado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblApellido
            // 
            this.lblApellido.BackColor = System.Drawing.Color.PeachPuff;
            this.lblApellido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblApellido.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.Location = new System.Drawing.Point(199, 209);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(136, 20);
            this.lblApellido.TabIndex = 38;
            this.lblApellido.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblApellido.Click += new System.EventHandler(this.lblApellido_Click);
            // 
            // lblDepartamento
            // 
            this.lblDepartamento.BackColor = System.Drawing.Color.PeachPuff;
            this.lblDepartamento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDepartamento.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartamento.Location = new System.Drawing.Point(199, 350);
            this.lblDepartamento.Name = "lblDepartamento";
            this.lblDepartamento.Size = new System.Drawing.Size(136, 19);
            this.lblDepartamento.TabIndex = 37;
            this.lblDepartamento.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDepartamento.Click += new System.EventHandler(this.lblPais_Click);
            // 
            // lblProvincia
            // 
            this.lblProvincia.BackColor = System.Drawing.Color.PeachPuff;
            this.lblProvincia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblProvincia.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProvincia.Location = new System.Drawing.Point(199, 311);
            this.lblProvincia.Name = "lblProvincia";
            this.lblProvincia.Size = new System.Drawing.Size(136, 20);
            this.lblProvincia.TabIndex = 36;
            this.lblProvincia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblProvincia.Click += new System.EventHandler(this.lblProvincia_Click);
            // 
            // lblApellidoEnc
            // 
            this.lblApellidoEnc.AutoSize = true;
            this.lblApellidoEnc.BackColor = System.Drawing.Color.Transparent;
            this.lblApellidoEnc.Font = new System.Drawing.Font("Cambria", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidoEnc.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblApellidoEnc.Location = new System.Drawing.Point(93, 209);
            this.lblApellidoEnc.Name = "lblApellidoEnc";
            this.lblApellidoEnc.Size = new System.Drawing.Size(81, 22);
            this.lblApellidoEnc.TabIndex = 35;
            this.lblApellidoEnc.Text = "Apellido";
            this.lblApellidoEnc.Click += new System.EventHandler(this.label12_Click);
            // 
            // lblDepartamentoEnc
            // 
            this.lblDepartamentoEnc.AutoSize = true;
            this.lblDepartamentoEnc.BackColor = System.Drawing.Color.Transparent;
            this.lblDepartamentoEnc.Font = new System.Drawing.Font("Cambria", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartamentoEnc.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblDepartamentoEnc.Location = new System.Drawing.Point(59, 344);
            this.lblDepartamentoEnc.Name = "lblDepartamentoEnc";
            this.lblDepartamentoEnc.Size = new System.Drawing.Size(134, 22);
            this.lblDepartamentoEnc.TabIndex = 34;
            this.lblDepartamentoEnc.Text = "Departamento";
            this.lblDepartamentoEnc.Click += new System.EventHandler(this.label13_Click);
            // 
            // lblProvEnc
            // 
            this.lblProvEnc.AutoSize = true;
            this.lblProvEnc.BackColor = System.Drawing.Color.Transparent;
            this.lblProvEnc.Font = new System.Drawing.Font("Cambria", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProvEnc.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblProvEnc.Location = new System.Drawing.Point(86, 311);
            this.lblProvEnc.Name = "lblProvEnc";
            this.lblProvEnc.Size = new System.Drawing.Size(93, 22);
            this.lblProvEnc.TabIndex = 33;
            this.lblProvEnc.Text = "Provincia";
            this.lblProvEnc.Click += new System.EventHandler(this.label14_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackgroundImage = global::pryGestionDeDatos.Properties.Resources.istockphoto_1186803754_170667a;
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscar.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(136, 109);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(157, 34);
            this.btnBuscar.TabIndex = 32;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.BackgroundImage = global::pryGestionDeDatos.Properties.Resources.istockphoto_1186803754_170667a;
            this.btnVolver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVolver.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(136, 434);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(157, 34);
            this.btnVolver.TabIndex = 31;
            this.btnVolver.Text = "VOLVER ATRAS";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // lblDomicilio
            // 
            this.lblDomicilio.BackColor = System.Drawing.Color.PeachPuff;
            this.lblDomicilio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDomicilio.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDomicilio.Location = new System.Drawing.Point(199, 382);
            this.lblDomicilio.Name = "lblDomicilio";
            this.lblDomicilio.Size = new System.Drawing.Size(136, 20);
            this.lblDomicilio.TabIndex = 30;
            this.lblDomicilio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDomicilio.Click += new System.EventHandler(this.lblDomicilio_Click);
            // 
            // lblEdad
            // 
            this.lblEdad.BackColor = System.Drawing.Color.PeachPuff;
            this.lblEdad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEdad.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdad.Location = new System.Drawing.Point(199, 277);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(119, 19);
            this.lblEdad.TabIndex = 29;
            this.lblEdad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblEdad.Click += new System.EventHandler(this.lblEdad_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.BackColor = System.Drawing.Color.PeachPuff;
            this.lblNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNombre.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(199, 240);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(136, 20);
            this.lblNombre.TabIndex = 27;
            this.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNombre.Click += new System.EventHandler(this.lblNombre_Click);
            // 
            // lblDomicilioEnc
            // 
            this.lblDomicilioEnc.AutoSize = true;
            this.lblDomicilioEnc.BackColor = System.Drawing.Color.Transparent;
            this.lblDomicilioEnc.Font = new System.Drawing.Font("Cambria", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDomicilioEnc.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblDomicilioEnc.Location = new System.Drawing.Point(86, 382);
            this.lblDomicilioEnc.Name = "lblDomicilioEnc";
            this.lblDomicilioEnc.Size = new System.Drawing.Size(92, 22);
            this.lblDomicilioEnc.TabIndex = 26;
            this.lblDomicilioEnc.Text = "Domicilio";
            this.lblDomicilioEnc.Click += new System.EventHandler(this.Domicilio_Click);
            // 
            // lblEdadEnc
            // 
            this.lblEdadEnc.AutoSize = true;
            this.lblEdadEnc.BackColor = System.Drawing.Color.Transparent;
            this.lblEdadEnc.Font = new System.Drawing.Font("Cambria", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdadEnc.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblEdadEnc.Location = new System.Drawing.Point(103, 277);
            this.lblEdadEnc.Name = "lblEdadEnc";
            this.lblEdadEnc.Size = new System.Drawing.Size(54, 22);
            this.lblEdadEnc.TabIndex = 25;
            this.lblEdadEnc.Text = "Edad";
            this.lblEdadEnc.Click += new System.EventHandler(this.label5_Click);
            // 
            // lblDniBuscado
            // 
            this.lblDniBuscado.AutoSize = true;
            this.lblDniBuscado.BackColor = System.Drawing.Color.Transparent;
            this.lblDniBuscado.Font = new System.Drawing.Font("Cambria", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDniBuscado.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblDniBuscado.Location = new System.Drawing.Point(113, 69);
            this.lblDniBuscado.Name = "lblDniBuscado";
            this.lblDniBuscado.Size = new System.Drawing.Size(42, 22);
            this.lblDniBuscado.TabIndex = 24;
            this.lblDniBuscado.Text = "DNI";
            this.lblDniBuscado.Click += new System.EventHandler(this.label4_Click_1);
            // 
            // lblNombreEnc
            // 
            this.lblNombreEnc.AutoSize = true;
            this.lblNombreEnc.BackColor = System.Drawing.Color.Transparent;
            this.lblNombreEnc.Font = new System.Drawing.Font("Cambria", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreEnc.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblNombreEnc.Location = new System.Drawing.Point(93, 240);
            this.lblNombreEnc.Name = "lblNombreEnc";
            this.lblNombreEnc.Size = new System.Drawing.Size(78, 22);
            this.lblNombreEnc.TabIndex = 23;
            this.lblNombreEnc.Text = "Nombre";
            this.lblNombreEnc.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblDatosEnc
            // 
            this.lblDatosEnc.AutoSize = true;
            this.lblDatosEnc.BackColor = System.Drawing.Color.Transparent;
            this.lblDatosEnc.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatosEnc.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblDatosEnc.Location = new System.Drawing.Point(173, 165);
            this.lblDatosEnc.Name = "lblDatosEnc";
            this.lblDatosEnc.Size = new System.Drawing.Size(65, 22);
            this.lblDatosEnc.TabIndex = 22;
            this.lblDatosEnc.Text = "Datos:\r\n";
            this.lblDatosEnc.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblTituloBC
            // 
            this.lblTituloBC.AutoSize = true;
            this.lblTituloBC.BackColor = System.Drawing.Color.Transparent;
            this.lblTituloBC.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloBC.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblTituloBC.Location = new System.Drawing.Point(44, 22);
            this.lblTituloBC.Name = "lblTituloBC";
            this.lblTituloBC.Size = new System.Drawing.Size(357, 25);
            this.lblTituloBC.TabIndex = 21;
            this.lblTituloBC.Text = "Ingrese el DNI de el cliente a buscar";
            this.lblTituloBC.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtDniBuscado
            // 
            this.txtDniBuscado.BackColor = System.Drawing.SystemColors.Window;
            this.txtDniBuscado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDniBuscado.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDniBuscado.Location = new System.Drawing.Point(177, 71);
            this.txtDniBuscado.Name = "txtDniBuscado";
            this.txtDniBuscado.Size = new System.Drawing.Size(129, 22);
            this.txtDniBuscado.TabIndex = 52;
            this.txtDniBuscado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmBuscarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.BackgroundImage = global::pryGestionDeDatos.Properties.Resources.descarga__4_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(430, 492);
            this.Controls.Add(this.txtDniBuscado);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblDepartamento);
            this.Controls.Add(this.lblProvincia);
            this.Controls.Add(this.lblApellidoEnc);
            this.Controls.Add(this.lblDepartamentoEnc);
            this.Controls.Add(this.lblProvEnc);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.lblDomicilio);
            this.Controls.Add(this.lblEdad);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblDomicilioEnc);
            this.Controls.Add(this.lblEdadEnc);
            this.Controls.Add(this.lblDniBuscado);
            this.Controls.Add(this.lblNombreEnc);
            this.Controls.Add(this.lblDatosEnc);
            this.Controls.Add(this.lblTituloBC);
            this.Name = "frmBuscarCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Cliente";
            this.Load += new System.EventHandler(this.frmBuscarCliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblDepartamento;
        private System.Windows.Forms.Label lblProvincia;
        private System.Windows.Forms.Label lblApellidoEnc;
        private System.Windows.Forms.Label lblDepartamentoEnc;
        private System.Windows.Forms.Label lblProvEnc;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label lblDomicilio;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDomicilioEnc;
        private System.Windows.Forms.Label lblEdadEnc;
        private System.Windows.Forms.Label lblDniBuscado;
        private System.Windows.Forms.Label lblNombreEnc;
        private System.Windows.Forms.Label lblDatosEnc;
        private System.Windows.Forms.Label lblTituloBC;
        private System.Windows.Forms.TextBox txtDniBuscado;
    }
}