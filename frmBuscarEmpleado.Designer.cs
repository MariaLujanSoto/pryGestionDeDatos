namespace pryGestionDeDatos
{
    partial class frmBuscarEmpleado
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
            this.lblApellidoEmp = new System.Windows.Forms.Label();
            this.lblApellidoEnc = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.lblDomicilioEmp = new System.Windows.Forms.Label();
            this.lblEdadEmp = new System.Windows.Forms.Label();
            this.lblNombreEmp = new System.Windows.Forms.Label();
            this.lblDomicilioEnc = new System.Windows.Forms.Label();
            this.lblEdadEnc = new System.Windows.Forms.Label();
            this.lblDniBusc = new System.Windows.Forms.Label();
            this.lblNombreEnc = new System.Windows.Forms.Label();
            this.lblDatosEnc = new System.Windows.Forms.Label();
            this.lblTituloBE = new System.Windows.Forms.Label();
            this.txtDniBuscadoEmp = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblApellidoEmp
            // 
            this.lblApellidoEmp.BackColor = System.Drawing.Color.LightGray;
            this.lblApellidoEmp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblApellidoEmp.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidoEmp.Location = new System.Drawing.Point(199, 204);
            this.lblApellidoEmp.Name = "lblApellidoEmp";
            this.lblApellidoEmp.Size = new System.Drawing.Size(119, 20);
            this.lblApellidoEmp.TabIndex = 56;
            this.lblApellidoEmp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblApellidoEnc
            // 
            this.lblApellidoEnc.AutoSize = true;
            this.lblApellidoEnc.BackColor = System.Drawing.Color.Transparent;
            this.lblApellidoEnc.Font = new System.Drawing.Font("Cambria", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidoEnc.Location = new System.Drawing.Point(93, 204);
            this.lblApellidoEnc.Name = "lblApellidoEnc";
            this.lblApellidoEnc.Size = new System.Drawing.Size(81, 22);
            this.lblApellidoEnc.TabIndex = 53;
            this.lblApellidoEnc.Text = "Apellido";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscar.BackgroundImage = global::pryGestionDeDatos.Properties.Resources.istockphoto_1186803754_170667a;
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscar.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(136, 106);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(157, 34);
            this.btnBuscar.TabIndex = 50;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.Transparent;
            this.btnVolver.BackgroundImage = global::pryGestionDeDatos.Properties.Resources.istockphoto_1186803754_170667a;
            this.btnVolver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVolver.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(136, 359);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(157, 34);
            this.btnVolver.TabIndex = 49;
            this.btnVolver.Text = "VOLVER ATRAS";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // lblDomicilioEmp
            // 
            this.lblDomicilioEmp.BackColor = System.Drawing.Color.LightGray;
            this.lblDomicilioEmp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDomicilioEmp.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDomicilioEmp.Location = new System.Drawing.Point(199, 305);
            this.lblDomicilioEmp.Name = "lblDomicilioEmp";
            this.lblDomicilioEmp.Size = new System.Drawing.Size(119, 20);
            this.lblDomicilioEmp.TabIndex = 48;
            this.lblDomicilioEmp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEdadEmp
            // 
            this.lblEdadEmp.BackColor = System.Drawing.Color.LightGray;
            this.lblEdadEmp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEdadEmp.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdadEmp.Location = new System.Drawing.Point(199, 272);
            this.lblEdadEmp.Name = "lblEdadEmp";
            this.lblEdadEmp.Size = new System.Drawing.Size(119, 19);
            this.lblEdadEmp.TabIndex = 47;
            this.lblEdadEmp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblEdadEmp.Click += new System.EventHandler(this.lblEdadEmp_Click);
            // 
            // lblNombreEmp
            // 
            this.lblNombreEmp.BackColor = System.Drawing.Color.LightGray;
            this.lblNombreEmp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNombreEmp.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreEmp.Location = new System.Drawing.Point(199, 235);
            this.lblNombreEmp.Name = "lblNombreEmp";
            this.lblNombreEmp.Size = new System.Drawing.Size(119, 20);
            this.lblNombreEmp.TabIndex = 45;
            this.lblNombreEmp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDomicilioEnc
            // 
            this.lblDomicilioEnc.AutoSize = true;
            this.lblDomicilioEnc.BackColor = System.Drawing.Color.Transparent;
            this.lblDomicilioEnc.Font = new System.Drawing.Font("Cambria", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDomicilioEnc.Location = new System.Drawing.Point(86, 305);
            this.lblDomicilioEnc.Name = "lblDomicilioEnc";
            this.lblDomicilioEnc.Size = new System.Drawing.Size(92, 22);
            this.lblDomicilioEnc.TabIndex = 44;
            this.lblDomicilioEnc.Text = "Domicilio";
            // 
            // lblEdadEnc
            // 
            this.lblEdadEnc.AutoSize = true;
            this.lblEdadEnc.BackColor = System.Drawing.Color.Transparent;
            this.lblEdadEnc.Font = new System.Drawing.Font("Cambria", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdadEnc.Location = new System.Drawing.Point(108, 272);
            this.lblEdadEnc.Name = "lblEdadEnc";
            this.lblEdadEnc.Size = new System.Drawing.Size(54, 22);
            this.lblEdadEnc.TabIndex = 43;
            this.lblEdadEnc.Text = "Edad";
            // 
            // lblDniBusc
            // 
            this.lblDniBusc.AutoSize = true;
            this.lblDniBusc.BackColor = System.Drawing.Color.Transparent;
            this.lblDniBusc.Font = new System.Drawing.Font("Cambria", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDniBusc.Location = new System.Drawing.Point(120, 68);
            this.lblDniBusc.Name = "lblDniBusc";
            this.lblDniBusc.Size = new System.Drawing.Size(42, 22);
            this.lblDniBusc.TabIndex = 42;
            this.lblDniBusc.Text = "DNI";
            // 
            // lblNombreEnc
            // 
            this.lblNombreEnc.AutoSize = true;
            this.lblNombreEnc.BackColor = System.Drawing.Color.Transparent;
            this.lblNombreEnc.Font = new System.Drawing.Font("Cambria", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreEnc.Location = new System.Drawing.Point(96, 235);
            this.lblNombreEnc.Name = "lblNombreEnc";
            this.lblNombreEnc.Size = new System.Drawing.Size(78, 22);
            this.lblNombreEnc.TabIndex = 41;
            this.lblNombreEnc.Text = "Nombre";
            // 
            // lblDatosEnc
            // 
            this.lblDatosEnc.AutoSize = true;
            this.lblDatosEnc.BackColor = System.Drawing.Color.Transparent;
            this.lblDatosEnc.Font = new System.Drawing.Font("Cambria", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatosEnc.Location = new System.Drawing.Point(171, 162);
            this.lblDatosEnc.Name = "lblDatosEnc";
            this.lblDatosEnc.Size = new System.Drawing.Size(64, 22);
            this.lblDatosEnc.TabIndex = 40;
            this.lblDatosEnc.Text = "Datos:\r\n";
            // 
            // lblTituloBE
            // 
            this.lblTituloBE.AutoSize = true;
            this.lblTituloBE.BackColor = System.Drawing.Color.Transparent;
            this.lblTituloBE.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloBE.Location = new System.Drawing.Point(34, 28);
            this.lblTituloBE.Name = "lblTituloBE";
            this.lblTituloBE.Size = new System.Drawing.Size(388, 25);
            this.lblTituloBE.TabIndex = 39;
            this.lblTituloBE.Text = "Ingrese el DNI de el Empleado a buscar";
            // 
            // txtDniBuscadoEmp
            // 
            this.txtDniBuscadoEmp.BackColor = System.Drawing.SystemColors.Window;
            this.txtDniBuscadoEmp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDniBuscadoEmp.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDniBuscadoEmp.Location = new System.Drawing.Point(175, 68);
            this.txtDniBuscadoEmp.Name = "txtDniBuscadoEmp";
            this.txtDniBuscadoEmp.Size = new System.Drawing.Size(129, 22);
            this.txtDniBuscadoEmp.TabIndex = 57;
            this.txtDniBuscadoEmp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmBuscarEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.BackgroundImage = global::pryGestionDeDatos.Properties.Resources.descarga__5_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(440, 451);
            this.Controls.Add(this.txtDniBuscadoEmp);
            this.Controls.Add(this.lblApellidoEmp);
            this.Controls.Add(this.lblApellidoEnc);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.lblDomicilioEmp);
            this.Controls.Add(this.lblEdadEmp);
            this.Controls.Add(this.lblNombreEmp);
            this.Controls.Add(this.lblDomicilioEnc);
            this.Controls.Add(this.lblEdadEnc);
            this.Controls.Add(this.lblDniBusc);
            this.Controls.Add(this.lblNombreEnc);
            this.Controls.Add(this.lblDatosEnc);
            this.Controls.Add(this.lblTituloBE);
            this.Name = "frmBuscarEmpleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Empleado";
            this.Load += new System.EventHandler(this.frmBuscarEmpleado_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblApellidoEmp;
        private System.Windows.Forms.Label lblApellidoEnc;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label lblDomicilioEmp;
        private System.Windows.Forms.Label lblEdadEmp;
        private System.Windows.Forms.Label lblNombreEmp;
        private System.Windows.Forms.Label lblDomicilioEnc;
        private System.Windows.Forms.Label lblEdadEnc;
        private System.Windows.Forms.Label lblDniBusc;
        private System.Windows.Forms.Label lblNombreEnc;
        private System.Windows.Forms.Label lblDatosEnc;
        private System.Windows.Forms.Label lblTituloBE;
        private System.Windows.Forms.TextBox txtDniBuscadoEmp;
    }
}