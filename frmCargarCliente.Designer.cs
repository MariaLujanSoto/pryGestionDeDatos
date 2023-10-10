namespace pryGestionDeDatos
{
    partial class frmCargarCliente
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
            this.cmbProvincias = new System.Windows.Forms.ComboBox();
            this.lblProvCliente = new System.Windows.Forms.Label();
            this.txtDomicilioCli = new System.Windows.Forms.TextBox();
            this.lblDomicilioCliente = new System.Windows.Forms.Label();
            this.txtDniCli = new System.Windows.Forms.TextBox();
            this.txtNombreCli = new System.Windows.Forms.TextBox();
            this.txtEdadCli = new System.Windows.Forms.TextBox();
            this.txtApellidoCli = new System.Windows.Forms.TextBox();
            this.lblEdadCliente = new System.Windows.Forms.Label();
            this.lblDniCliente = new System.Windows.Forms.Label();
            this.lblNombreCliente = new System.Windows.Forms.Label();
            this.lblApellidoCliente = new System.Windows.Forms.Label();
            this.lblTituloRegCliente = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.cmbDepartamentos = new System.Windows.Forms.ComboBox();
            this.lblDepartamentoCliente = new System.Windows.Forms.Label();
            this.btnCargar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbProvincias
            // 
            this.cmbProvincias.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProvincias.FormattingEnabled = true;
            this.cmbProvincias.Location = new System.Drawing.Point(197, 237);
            this.cmbProvincias.Name = "cmbProvincias";
            this.cmbProvincias.Size = new System.Drawing.Size(121, 22);
            this.cmbProvincias.TabIndex = 42;
            this.cmbProvincias.SelectedIndexChanged += new System.EventHandler(this.cmbProvincias_SelectedIndexChanged);
            // 
            // lblProvCliente
            // 
            this.lblProvCliente.AutoSize = true;
            this.lblProvCliente.BackColor = System.Drawing.Color.Transparent;
            this.lblProvCliente.Font = new System.Drawing.Font("Cambria", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProvCliente.ForeColor = System.Drawing.Color.White;
            this.lblProvCliente.Location = new System.Drawing.Point(80, 237);
            this.lblProvCliente.Name = "lblProvCliente";
            this.lblProvCliente.Size = new System.Drawing.Size(93, 22);
            this.lblProvCliente.TabIndex = 39;
            this.lblProvCliente.Text = "Provincia";
            // 
            // txtDomicilioCli
            // 
            this.txtDomicilioCli.BackColor = System.Drawing.SystemColors.Window;
            this.txtDomicilioCli.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDomicilioCli.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDomicilioCli.Location = new System.Drawing.Point(197, 301);
            this.txtDomicilioCli.Name = "txtDomicilioCli";
            this.txtDomicilioCli.Size = new System.Drawing.Size(129, 22);
            this.txtDomicilioCli.TabIndex = 40;
            this.txtDomicilioCli.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblDomicilioCliente
            // 
            this.lblDomicilioCliente.AutoSize = true;
            this.lblDomicilioCliente.BackColor = System.Drawing.Color.Transparent;
            this.lblDomicilioCliente.Font = new System.Drawing.Font("Cambria", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDomicilioCliente.ForeColor = System.Drawing.Color.White;
            this.lblDomicilioCliente.Location = new System.Drawing.Point(77, 300);
            this.lblDomicilioCliente.Name = "lblDomicilioCliente";
            this.lblDomicilioCliente.Size = new System.Drawing.Size(92, 22);
            this.lblDomicilioCliente.TabIndex = 38;
            this.lblDomicilioCliente.Text = "Domicilio";
            // 
            // txtDniCli
            // 
            this.txtDniCli.BackColor = System.Drawing.SystemColors.Window;
            this.txtDniCli.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDniCli.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDniCli.Location = new System.Drawing.Point(197, 161);
            this.txtDniCli.Name = "txtDniCli";
            this.txtDniCli.Size = new System.Drawing.Size(129, 22);
            this.txtDniCli.TabIndex = 37;
            this.txtDniCli.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNombreCli
            // 
            this.txtNombreCli.BackColor = System.Drawing.SystemColors.Window;
            this.txtNombreCli.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombreCli.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreCli.Location = new System.Drawing.Point(197, 125);
            this.txtNombreCli.Name = "txtNombreCli";
            this.txtNombreCli.Size = new System.Drawing.Size(129, 22);
            this.txtNombreCli.TabIndex = 36;
            this.txtNombreCli.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtEdadCli
            // 
            this.txtEdadCli.BackColor = System.Drawing.SystemColors.Window;
            this.txtEdadCli.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEdadCli.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEdadCli.Location = new System.Drawing.Point(197, 198);
            this.txtEdadCli.Name = "txtEdadCli";
            this.txtEdadCli.Size = new System.Drawing.Size(100, 22);
            this.txtEdadCli.TabIndex = 35;
            this.txtEdadCli.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtApellidoCli
            // 
            this.txtApellidoCli.BackColor = System.Drawing.SystemColors.Window;
            this.txtApellidoCli.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtApellidoCli.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidoCli.Location = new System.Drawing.Point(197, 95);
            this.txtApellidoCli.Name = "txtApellidoCli";
            this.txtApellidoCli.Size = new System.Drawing.Size(129, 22);
            this.txtApellidoCli.TabIndex = 34;
            this.txtApellidoCli.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblEdadCliente
            // 
            this.lblEdadCliente.AutoSize = true;
            this.lblEdadCliente.BackColor = System.Drawing.Color.Transparent;
            this.lblEdadCliente.Font = new System.Drawing.Font("Cambria", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdadCliente.ForeColor = System.Drawing.Color.White;
            this.lblEdadCliente.Location = new System.Drawing.Point(87, 197);
            this.lblEdadCliente.Name = "lblEdadCliente";
            this.lblEdadCliente.Size = new System.Drawing.Size(54, 22);
            this.lblEdadCliente.TabIndex = 32;
            this.lblEdadCliente.Text = "Edad";
            // 
            // lblDniCliente
            // 
            this.lblDniCliente.AutoSize = true;
            this.lblDniCliente.BackColor = System.Drawing.Color.Transparent;
            this.lblDniCliente.Font = new System.Drawing.Font("Cambria", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDniCliente.ForeColor = System.Drawing.Color.White;
            this.lblDniCliente.Location = new System.Drawing.Point(87, 160);
            this.lblDniCliente.Name = "lblDniCliente";
            this.lblDniCliente.Size = new System.Drawing.Size(42, 22);
            this.lblDniCliente.TabIndex = 31;
            this.lblDniCliente.Text = "DNI";
            // 
            // lblNombreCliente
            // 
            this.lblNombreCliente.AutoSize = true;
            this.lblNombreCliente.BackColor = System.Drawing.Color.Transparent;
            this.lblNombreCliente.Font = new System.Drawing.Font("Cambria", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreCliente.ForeColor = System.Drawing.Color.White;
            this.lblNombreCliente.Location = new System.Drawing.Point(87, 125);
            this.lblNombreCliente.Name = "lblNombreCliente";
            this.lblNombreCliente.Size = new System.Drawing.Size(78, 22);
            this.lblNombreCliente.TabIndex = 30;
            this.lblNombreCliente.Text = "Nombre";
            // 
            // lblApellidoCliente
            // 
            this.lblApellidoCliente.AutoSize = true;
            this.lblApellidoCliente.BackColor = System.Drawing.Color.Transparent;
            this.lblApellidoCliente.Font = new System.Drawing.Font("Cambria", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidoCliente.ForeColor = System.Drawing.Color.White;
            this.lblApellidoCliente.Location = new System.Drawing.Point(87, 94);
            this.lblApellidoCliente.Name = "lblApellidoCliente";
            this.lblApellidoCliente.Size = new System.Drawing.Size(81, 22);
            this.lblApellidoCliente.TabIndex = 29;
            this.lblApellidoCliente.Text = "Apellido";
            // 
            // lblTituloRegCliente
            // 
            this.lblTituloRegCliente.AutoSize = true;
            this.lblTituloRegCliente.BackColor = System.Drawing.Color.Transparent;
            this.lblTituloRegCliente.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloRegCliente.ForeColor = System.Drawing.Color.White;
            this.lblTituloRegCliente.Location = new System.Drawing.Point(28, 34);
            this.lblTituloRegCliente.Name = "lblTituloRegCliente";
            this.lblTituloRegCliente.Size = new System.Drawing.Size(392, 25);
            this.lblTituloRegCliente.TabIndex = 28;
            this.lblTituloRegCliente.Text = "Ingrese los datos del cliente a registrar\r\n";
            // 
            // btnVolver
            // 
            this.btnVolver.BackgroundImage = global::pryGestionDeDatos.Properties.Resources.istockphoto_1186803754_170667a;
            this.btnVolver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVolver.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(140, 417);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(157, 33);
            this.btnVolver.TabIndex = 27;
            this.btnVolver.Text = "VOLVER ATRAS";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click_1);
            // 
            // cmbDepartamentos
            // 
            this.cmbDepartamentos.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDepartamentos.FormattingEnabled = true;
            this.cmbDepartamentos.Location = new System.Drawing.Point(197, 269);
            this.cmbDepartamentos.Name = "cmbDepartamentos";
            this.cmbDepartamentos.Size = new System.Drawing.Size(121, 22);
            this.cmbDepartamentos.TabIndex = 44;
            this.cmbDepartamentos.SelectedIndexChanged += new System.EventHandler(this.cmbDepartamentos_SelectedIndexChanged);
            // 
            // lblDepartamentoCliente
            // 
            this.lblDepartamentoCliente.AutoSize = true;
            this.lblDepartamentoCliente.BackColor = System.Drawing.Color.Transparent;
            this.lblDepartamentoCliente.Font = new System.Drawing.Font("Cambria", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartamentoCliente.ForeColor = System.Drawing.Color.White;
            this.lblDepartamentoCliente.Location = new System.Drawing.Point(57, 269);
            this.lblDepartamentoCliente.Name = "lblDepartamentoCliente";
            this.lblDepartamentoCliente.Size = new System.Drawing.Size(134, 22);
            this.lblDepartamentoCliente.TabIndex = 43;
            this.lblDepartamentoCliente.Text = "Departamento";
            // 
            // btnCargar
            // 
            this.btnCargar.BackgroundImage = global::pryGestionDeDatos.Properties.Resources.istockphoto_1186803754_170667a;
            this.btnCargar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCargar.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargar.Location = new System.Drawing.Point(140, 367);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(157, 34);
            this.btnCargar.TabIndex = 41;
            this.btnCargar.Text = "CARGAR";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // frmCargarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.BackgroundImage = global::pryGestionDeDatos.Properties.Resources.descarga__3_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(432, 503);
            this.Controls.Add(this.cmbDepartamentos);
            this.Controls.Add(this.lblDepartamentoCliente);
            this.Controls.Add(this.cmbProvincias);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.lblProvCliente);
            this.Controls.Add(this.txtDomicilioCli);
            this.Controls.Add(this.lblDomicilioCliente);
            this.Controls.Add(this.txtDniCli);
            this.Controls.Add(this.txtNombreCli);
            this.Controls.Add(this.txtEdadCli);
            this.Controls.Add(this.txtApellidoCli);
            this.Controls.Add(this.lblEdadCliente);
            this.Controls.Add(this.lblDniCliente);
            this.Controls.Add(this.lblNombreCliente);
            this.Controls.Add(this.lblApellidoCliente);
            this.Controls.Add(this.lblTituloRegCliente);
            this.Controls.Add(this.btnVolver);
            this.Name = "frmCargarCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cargar Cliente";
            this.Load += new System.EventHandler(this.frmCargarCliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbProvincias;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Label lblProvCliente;
        private System.Windows.Forms.TextBox txtDomicilioCli;
        private System.Windows.Forms.Label lblDomicilioCliente;
        private System.Windows.Forms.TextBox txtDniCli;
        private System.Windows.Forms.TextBox txtNombreCli;
        private System.Windows.Forms.TextBox txtEdadCli;
        private System.Windows.Forms.TextBox txtApellidoCli;
        private System.Windows.Forms.Label lblEdadCliente;
        private System.Windows.Forms.Label lblDniCliente;
        private System.Windows.Forms.Label lblNombreCliente;
        private System.Windows.Forms.Label lblApellidoCliente;
        private System.Windows.Forms.Label lblTituloRegCliente;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.ComboBox cmbDepartamentos;
        private System.Windows.Forms.Label lblDepartamentoCliente;
    }
}