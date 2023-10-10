namespace pryGestionDeDatos
{
    partial class frmCargarVentas
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
            this.lblTituloVR = new System.Windows.Forms.Label();
            this.lblDatos = new System.Windows.Forms.Label();
            this.lblDatosSO = new System.Windows.Forms.Label();
            this.lblDniCli = new System.Windows.Forms.Label();
            this.lblDniEmp = new System.Windows.Forms.Label();
            this.txtDniClienteB = new System.Windows.Forms.TextBox();
            this.txtDniEmpB = new System.Windows.Forms.TextBox();
            this.lblMP = new System.Windows.Forms.Label();
            this.chkManicura = new System.Windows.Forms.CheckBox();
            this.mrcServicios = new System.Windows.Forms.GroupBox();
            this.chkDepilacion = new System.Windows.Forms.CheckBox();
            this.chkMascarillas = new System.Windows.Forms.CheckBox();
            this.chkMasajes = new System.Windows.Forms.CheckBox();
            this.chkPestañas = new System.Windows.Forms.CheckBox();
            this.chkPedicura = new System.Windows.Forms.CheckBox();
            this.lblMontoAbonar = new System.Windows.Forms.Label();
            this.mrcMetodosDePago = new System.Windows.Forms.GroupBox();
            this.optTransf = new System.Windows.Forms.RadioButton();
            this.optEfvo = new System.Windows.Forms.RadioButton();
            this.optCredito = new System.Windows.Forms.RadioButton();
            this.optDebito = new System.Windows.Forms.RadioButton();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblNomCli = new System.Windows.Forms.Label();
            this.lblApCli = new System.Windows.Forms.Label();
            this.lblApEmp = new System.Windows.Forms.Label();
            this.lblNomEmp = new System.Windows.Forms.Label();
            this.lblCombos = new System.Windows.Forms.Label();
            this.lblPagos = new System.Windows.Forms.Label();
            this.lblCodVenta = new System.Windows.Forms.Label();
            this.txtCodVenta = new System.Windows.Forms.TextBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.lblNombCliEnc = new System.Windows.Forms.Label();
            this.lblNombEmpEnc = new System.Windows.Forms.Label();
            this.lblApCliEnc = new System.Windows.Forms.Label();
            this.lblApEmpEnc = new System.Windows.Forms.Label();
            this.lblHabilitado = new System.Windows.Forms.Label();
            this.mrcServicios.SuspendLayout();
            this.mrcMetodosDePago.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTituloVR
            // 
            this.lblTituloVR.AutoSize = true;
            this.lblTituloVR.BackColor = System.Drawing.Color.Transparent;
            this.lblTituloVR.Font = new System.Drawing.Font("Cambria", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloVR.Location = new System.Drawing.Point(122, 22);
            this.lblTituloVR.Name = "lblTituloVR";
            this.lblTituloVR.Size = new System.Drawing.Size(272, 25);
            this.lblTituloVR.TabIndex = 0;
            this.lblTituloVR.Text = "Carga de Ventas Realizadas";
            // 
            // lblDatos
            // 
            this.lblDatos.AutoSize = true;
            this.lblDatos.BackColor = System.Drawing.Color.Transparent;
            this.lblDatos.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatos.Location = new System.Drawing.Point(26, 99);
            this.lblDatos.Name = "lblDatos";
            this.lblDatos.Size = new System.Drawing.Size(258, 22);
            this.lblDatos.TabIndex = 1;
            this.lblDatos.Text = "Datos del Cliente y Vendedor";
            // 
            // lblDatosSO
            // 
            this.lblDatosSO.AutoSize = true;
            this.lblDatosSO.BackColor = System.Drawing.Color.Transparent;
            this.lblDatosSO.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatosSO.Location = new System.Drawing.Point(26, 255);
            this.lblDatosSO.Name = "lblDatosSO";
            this.lblDatosSO.Size = new System.Drawing.Size(245, 22);
            this.lblDatosSO.TabIndex = 2;
            this.lblDatosSO.Text = "Datos del Servicio Ofrecido";
            // 
            // lblDniCli
            // 
            this.lblDniCli.AutoSize = true;
            this.lblDniCli.BackColor = System.Drawing.Color.Transparent;
            this.lblDniCli.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDniCli.Location = new System.Drawing.Point(26, 142);
            this.lblDniCli.Name = "lblDniCli";
            this.lblDniCli.Size = new System.Drawing.Size(101, 17);
            this.lblDniCli.TabIndex = 3;
            this.lblDniCli.Text = "DNI del Cliente";
            // 
            // lblDniEmp
            // 
            this.lblDniEmp.AutoSize = true;
            this.lblDniEmp.BackColor = System.Drawing.Color.Transparent;
            this.lblDniEmp.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDniEmp.Location = new System.Drawing.Point(249, 139);
            this.lblDniEmp.Name = "lblDniEmp";
            this.lblDniEmp.Size = new System.Drawing.Size(121, 17);
            this.lblDniEmp.TabIndex = 4;
            this.lblDniEmp.Text = "DNI del Empleado";
            // 
            // txtDniClienteB
            // 
            this.txtDniClienteB.BackColor = System.Drawing.Color.White;
            this.txtDniClienteB.Location = new System.Drawing.Point(137, 139);
            this.txtDniClienteB.Name = "txtDniClienteB";
            this.txtDniClienteB.Size = new System.Drawing.Size(100, 20);
            this.txtDniClienteB.TabIndex = 5;
            this.txtDniClienteB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDniEmpB
            // 
            this.txtDniEmpB.BackColor = System.Drawing.Color.White;
            this.txtDniEmpB.Location = new System.Drawing.Point(397, 136);
            this.txtDniEmpB.Name = "txtDniEmpB";
            this.txtDniEmpB.Size = new System.Drawing.Size(100, 20);
            this.txtDniEmpB.TabIndex = 6;
            this.txtDniEmpB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblMP
            // 
            this.lblMP.AutoSize = true;
            this.lblMP.BackColor = System.Drawing.Color.Transparent;
            this.lblMP.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMP.Location = new System.Drawing.Point(196, 409);
            this.lblMP.Name = "lblMP";
            this.lblMP.Size = new System.Drawing.Size(119, 17);
            this.lblMP.TabIndex = 7;
            this.lblMP.Text = "Monto a Abonar";
            // 
            // chkManicura
            // 
            this.chkManicura.AutoSize = true;
            this.chkManicura.Location = new System.Drawing.Point(16, 19);
            this.chkManicura.Name = "chkManicura";
            this.chkManicura.Size = new System.Drawing.Size(78, 19);
            this.chkManicura.TabIndex = 8;
            this.chkManicura.Text = "Manicura";
            this.chkManicura.UseVisualStyleBackColor = true;
            // 
            // mrcServicios
            // 
            this.mrcServicios.BackColor = System.Drawing.Color.MistyRose;
            this.mrcServicios.Controls.Add(this.chkDepilacion);
            this.mrcServicios.Controls.Add(this.chkMascarillas);
            this.mrcServicios.Controls.Add(this.chkMasajes);
            this.mrcServicios.Controls.Add(this.chkPestañas);
            this.mrcServicios.Controls.Add(this.chkPedicura);
            this.mrcServicios.Controls.Add(this.chkManicura);
            this.mrcServicios.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mrcServicios.ForeColor = System.Drawing.Color.Black;
            this.mrcServicios.Location = new System.Drawing.Point(35, 292);
            this.mrcServicios.Name = "mrcServicios";
            this.mrcServicios.Size = new System.Drawing.Size(213, 92);
            this.mrcServicios.TabIndex = 9;
            this.mrcServicios.TabStop = false;
            this.mrcServicios.Text = "Servicio Seleccionado";
            // 
            // chkDepilacion
            // 
            this.chkDepilacion.AutoSize = true;
            this.chkDepilacion.Location = new System.Drawing.Point(116, 65);
            this.chkDepilacion.Name = "chkDepilacion";
            this.chkDepilacion.Size = new System.Drawing.Size(86, 19);
            this.chkDepilacion.TabIndex = 13;
            this.chkDepilacion.Text = "Depilacion";
            this.chkDepilacion.UseVisualStyleBackColor = true;
            this.chkDepilacion.CheckedChanged += new System.EventHandler(this.checkBox6_CheckedChanged);
            // 
            // chkMascarillas
            // 
            this.chkMascarillas.AutoSize = true;
            this.chkMascarillas.Location = new System.Drawing.Point(116, 42);
            this.chkMascarillas.Name = "chkMascarillas";
            this.chkMascarillas.Size = new System.Drawing.Size(84, 19);
            this.chkMascarillas.TabIndex = 12;
            this.chkMascarillas.Text = "Mascarilla";
            this.chkMascarillas.UseVisualStyleBackColor = true;
            // 
            // chkMasajes
            // 
            this.chkMasajes.AutoSize = true;
            this.chkMasajes.Location = new System.Drawing.Point(116, 19);
            this.chkMasajes.Name = "chkMasajes";
            this.chkMasajes.Size = new System.Drawing.Size(64, 19);
            this.chkMasajes.TabIndex = 11;
            this.chkMasajes.Text = "Masaje";
            this.chkMasajes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkMasajes.UseVisualStyleBackColor = true;
            // 
            // chkPestañas
            // 
            this.chkPestañas.AutoSize = true;
            this.chkPestañas.Location = new System.Drawing.Point(16, 65);
            this.chkPestañas.Name = "chkPestañas";
            this.chkPestañas.Size = new System.Drawing.Size(74, 19);
            this.chkPestañas.TabIndex = 10;
            this.chkPestañas.Text = "Pestañas";
            this.chkPestañas.UseVisualStyleBackColor = true;
            // 
            // chkPedicura
            // 
            this.chkPedicura.AutoSize = true;
            this.chkPedicura.Location = new System.Drawing.Point(16, 42);
            this.chkPedicura.Name = "chkPedicura";
            this.chkPedicura.Size = new System.Drawing.Size(74, 19);
            this.chkPedicura.TabIndex = 9;
            this.chkPedicura.Text = "Pedicura";
            this.chkPedicura.UseVisualStyleBackColor = true;
            // 
            // lblMontoAbonar
            // 
            this.lblMontoAbonar.BackColor = System.Drawing.Color.MistyRose;
            this.lblMontoAbonar.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontoAbonar.Location = new System.Drawing.Point(196, 430);
            this.lblMontoAbonar.Name = "lblMontoAbonar";
            this.lblMontoAbonar.Size = new System.Drawing.Size(119, 23);
            this.lblMontoAbonar.TabIndex = 12;
            this.lblMontoAbonar.Text = "$";
            this.lblMontoAbonar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mrcMetodosDePago
            // 
            this.mrcMetodosDePago.BackColor = System.Drawing.Color.MistyRose;
            this.mrcMetodosDePago.Controls.Add(this.optTransf);
            this.mrcMetodosDePago.Controls.Add(this.optEfvo);
            this.mrcMetodosDePago.Controls.Add(this.optCredito);
            this.mrcMetodosDePago.Controls.Add(this.optDebito);
            this.mrcMetodosDePago.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mrcMetodosDePago.Location = new System.Drawing.Point(282, 292);
            this.mrcMetodosDePago.Name = "mrcMetodosDePago";
            this.mrcMetodosDePago.Size = new System.Drawing.Size(207, 73);
            this.mrcMetodosDePago.TabIndex = 16;
            this.mrcMetodosDePago.TabStop = false;
            this.mrcMetodosDePago.Text = "Método de Pago";
            // 
            // optTransf
            // 
            this.optTransf.AutoSize = true;
            this.optTransf.Location = new System.Drawing.Point(100, 40);
            this.optTransf.Name = "optTransf";
            this.optTransf.Size = new System.Drawing.Size(97, 18);
            this.optTransf.TabIndex = 3;
            this.optTransf.Text = "Transferencia";
            this.optTransf.UseVisualStyleBackColor = true;
            // 
            // optEfvo
            // 
            this.optEfvo.AutoSize = true;
            this.optEfvo.Location = new System.Drawing.Point(16, 42);
            this.optEfvo.Name = "optEfvo";
            this.optEfvo.Size = new System.Drawing.Size(66, 18);
            this.optEfvo.TabIndex = 2;
            this.optEfvo.Text = "Efectivo";
            this.optEfvo.UseVisualStyleBackColor = true;
            // 
            // optCredito
            // 
            this.optCredito.AutoSize = true;
            this.optCredito.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optCredito.Location = new System.Drawing.Point(100, 19);
            this.optCredito.Name = "optCredito";
            this.optCredito.Size = new System.Drawing.Size(63, 18);
            this.optCredito.TabIndex = 1;
            this.optCredito.Text = "Crédito";
            this.optCredito.UseVisualStyleBackColor = true;
            // 
            // optDebito
            // 
            this.optDebito.AutoSize = true;
            this.optDebito.Location = new System.Drawing.Point(15, 19);
            this.optDebito.Name = "optDebito";
            this.optDebito.Size = new System.Drawing.Size(59, 18);
            this.optDebito.TabIndex = 0;
            this.optDebito.Text = "Débito";
            this.optDebito.UseVisualStyleBackColor = true;
            // 
            // btnVolver
            // 
            this.btnVolver.BackgroundImage = global::pryGestionDeDatos.Properties.Resources.istockphoto_1186803754_170667a;
            this.btnVolver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVolver.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(38, 528);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(137, 35);
            this.btnVolver.TabIndex = 17;
            this.btnVolver.Text = "VOLVER ATRAS";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.BackgroundImage = global::pryGestionDeDatos.Properties.Resources.istockphoto_1186803754_170667a;
            this.btnFinalizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFinalizar.Enabled = false;
            this.btnFinalizar.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizar.ForeColor = System.Drawing.Color.Black;
            this.btnFinalizar.Location = new System.Drawing.Point(329, 528);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(137, 33);
            this.btnFinalizar.TabIndex = 18;
            this.btnFinalizar.Text = "FINALIZAR";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            this.btnFinalizar.Click += new System.EventHandler(this.bntFinalizar_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackgroundImage = global::pryGestionDeDatos.Properties.Resources.istockphoto_1186803754_170667a;
            this.btnCalcular.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCalcular.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(183, 478);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(137, 35);
            this.btnCalcular.TabIndex = 19;
            this.btnCalcular.Text = "CALCULAR";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblNomCli
            // 
            this.lblNomCli.AutoSize = true;
            this.lblNomCli.BackColor = System.Drawing.Color.Transparent;
            this.lblNomCli.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomCli.Location = new System.Drawing.Point(2, 216);
            this.lblNomCli.Name = "lblNomCli";
            this.lblNomCli.Size = new System.Drawing.Size(127, 17);
            this.lblNomCli.TabIndex = 22;
            this.lblNomCli.Text = "Nombre del Cliente";
            // 
            // lblApCli
            // 
            this.lblApCli.AutoSize = true;
            this.lblApCli.BackColor = System.Drawing.Color.Transparent;
            this.lblApCli.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApCli.Location = new System.Drawing.Point(3, 180);
            this.lblApCli.Name = "lblApCli";
            this.lblApCli.Size = new System.Drawing.Size(128, 17);
            this.lblApCli.TabIndex = 24;
            this.lblApCli.Text = "Apellido del Cliente";
            // 
            // lblApEmp
            // 
            this.lblApEmp.AutoSize = true;
            this.lblApEmp.BackColor = System.Drawing.Color.Transparent;
            this.lblApEmp.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApEmp.Location = new System.Drawing.Point(244, 180);
            this.lblApEmp.Name = "lblApEmp";
            this.lblApEmp.Size = new System.Drawing.Size(148, 17);
            this.lblApEmp.TabIndex = 26;
            this.lblApEmp.Text = "Apellido del Empleado";
            // 
            // lblNomEmp
            // 
            this.lblNomEmp.AutoSize = true;
            this.lblNomEmp.BackColor = System.Drawing.Color.Transparent;
            this.lblNomEmp.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomEmp.Location = new System.Drawing.Point(243, 219);
            this.lblNomEmp.Name = "lblNomEmp";
            this.lblNomEmp.Size = new System.Drawing.Size(147, 17);
            this.lblNomEmp.TabIndex = 27;
            this.lblNomEmp.Text = "Nombre del Empleado";
            // 
            // lblCombos
            // 
            this.lblCombos.BackColor = System.Drawing.Color.Transparent;
            this.lblCombos.Location = new System.Drawing.Point(32, 387);
            this.lblCombos.Name = "lblCombos";
            this.lblCombos.Size = new System.Drawing.Size(216, 23);
            this.lblCombos.TabIndex = 29;
            this.lblCombos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPagos
            // 
            this.lblPagos.BackColor = System.Drawing.Color.Transparent;
            this.lblPagos.Location = new System.Drawing.Point(267, 368);
            this.lblPagos.Name = "lblPagos";
            this.lblPagos.Size = new System.Drawing.Size(239, 23);
            this.lblPagos.TabIndex = 30;
            this.lblPagos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCodVenta
            // 
            this.lblCodVenta.AutoSize = true;
            this.lblCodVenta.BackColor = System.Drawing.Color.Transparent;
            this.lblCodVenta.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodVenta.Location = new System.Drawing.Point(135, 65);
            this.lblCodVenta.Name = "lblCodVenta";
            this.lblCodVenta.Size = new System.Drawing.Size(119, 17);
            this.lblCodVenta.TabIndex = 31;
            this.lblCodVenta.Text = "Código de Venta";
            // 
            // txtCodVenta
            // 
            this.txtCodVenta.Location = new System.Drawing.Point(270, 65);
            this.txtCodVenta.Name = "txtCodVenta";
            this.txtCodVenta.Size = new System.Drawing.Size(100, 20);
            this.txtCodVenta.TabIndex = 32;
            this.txtCodVenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackgroundImage = global::pryGestionDeDatos.Properties.Resources.istockphoto_1186803754_170667a;
            this.btnLimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLimpiar.Enabled = false;
            this.btnLimpiar.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(348, 425);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(78, 28);
            this.btnLimpiar.TabIndex = 33;
            this.btnLimpiar.Text = "LIMPIAR";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // lblNombCliEnc
            // 
            this.lblNombCliEnc.BackColor = System.Drawing.Color.MistyRose;
            this.lblNombCliEnc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNombCliEnc.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblNombCliEnc.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombCliEnc.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblNombCliEnc.Location = new System.Drawing.Point(135, 216);
            this.lblNombCliEnc.Name = "lblNombCliEnc";
            this.lblNombCliEnc.Size = new System.Drawing.Size(100, 19);
            this.lblNombCliEnc.TabIndex = 35;
            this.lblNombCliEnc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNombEmpEnc
            // 
            this.lblNombEmpEnc.BackColor = System.Drawing.Color.MistyRose;
            this.lblNombEmpEnc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNombEmpEnc.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblNombEmpEnc.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombEmpEnc.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblNombEmpEnc.Location = new System.Drawing.Point(396, 218);
            this.lblNombEmpEnc.Name = "lblNombEmpEnc";
            this.lblNombEmpEnc.Size = new System.Drawing.Size(100, 19);
            this.lblNombEmpEnc.TabIndex = 36;
            this.lblNombEmpEnc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblApCliEnc
            // 
            this.lblApCliEnc.BackColor = System.Drawing.Color.MistyRose;
            this.lblApCliEnc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblApCliEnc.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblApCliEnc.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApCliEnc.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblApCliEnc.Location = new System.Drawing.Point(135, 182);
            this.lblApCliEnc.Name = "lblApCliEnc";
            this.lblApCliEnc.Size = new System.Drawing.Size(100, 19);
            this.lblApCliEnc.TabIndex = 37;
            this.lblApCliEnc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblApEmpEnc
            // 
            this.lblApEmpEnc.BackColor = System.Drawing.Color.MistyRose;
            this.lblApEmpEnc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblApEmpEnc.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblApEmpEnc.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApEmpEnc.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblApEmpEnc.Location = new System.Drawing.Point(397, 180);
            this.lblApEmpEnc.Name = "lblApEmpEnc";
            this.lblApEmpEnc.Size = new System.Drawing.Size(100, 19);
            this.lblApEmpEnc.TabIndex = 38;
            this.lblApEmpEnc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHabilitado
            // 
            this.lblHabilitado.BackColor = System.Drawing.Color.Transparent;
            this.lblHabilitado.Location = new System.Drawing.Point(326, 489);
            this.lblHabilitado.Name = "lblHabilitado";
            this.lblHabilitado.Size = new System.Drawing.Size(160, 36);
            this.lblHabilitado.TabIndex = 39;
            this.lblHabilitado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmCargarVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::pryGestionDeDatos.Properties.Resources.Bloom_Plum_Wallpaper;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(511, 598);
            this.Controls.Add(this.lblHabilitado);
            this.Controls.Add(this.lblApEmpEnc);
            this.Controls.Add(this.lblApCliEnc);
            this.Controls.Add(this.lblNombEmpEnc);
            this.Controls.Add(this.lblNombCliEnc);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.txtCodVenta);
            this.Controls.Add(this.lblCodVenta);
            this.Controls.Add(this.lblPagos);
            this.Controls.Add(this.lblCombos);
            this.Controls.Add(this.lblNomEmp);
            this.Controls.Add(this.lblApEmp);
            this.Controls.Add(this.lblApCli);
            this.Controls.Add(this.lblNomCli);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.mrcMetodosDePago);
            this.Controls.Add(this.lblMontoAbonar);
            this.Controls.Add(this.mrcServicios);
            this.Controls.Add(this.lblMP);
            this.Controls.Add(this.txtDniEmpB);
            this.Controls.Add(this.txtDniClienteB);
            this.Controls.Add(this.lblDniEmp);
            this.Controls.Add(this.lblDniCli);
            this.Controls.Add(this.lblDatosSO);
            this.Controls.Add(this.lblDatos);
            this.Controls.Add(this.lblTituloVR);
            this.DoubleBuffered = true;
            this.Name = "frmCargarVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cargar Ventas";
            this.Load += new System.EventHandler(this.frmCargarVentas_Load);
            this.mrcServicios.ResumeLayout(false);
            this.mrcServicios.PerformLayout();
            this.mrcMetodosDePago.ResumeLayout(false);
            this.mrcMetodosDePago.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTituloVR;
        private System.Windows.Forms.Label lblDatos;
        private System.Windows.Forms.Label lblDatosSO;
        private System.Windows.Forms.Label lblDniCli;
        private System.Windows.Forms.Label lblDniEmp;
        private System.Windows.Forms.TextBox txtDniClienteB;
        private System.Windows.Forms.TextBox txtDniEmpB;
        private System.Windows.Forms.Label lblMP;
        private System.Windows.Forms.CheckBox chkManicura;
        private System.Windows.Forms.GroupBox mrcServicios;
        private System.Windows.Forms.CheckBox chkDepilacion;
        private System.Windows.Forms.CheckBox chkMascarillas;
        private System.Windows.Forms.CheckBox chkMasajes;
        private System.Windows.Forms.CheckBox chkPestañas;
        private System.Windows.Forms.CheckBox chkPedicura;
        private System.Windows.Forms.Label lblMontoAbonar;
        private System.Windows.Forms.GroupBox mrcMetodosDePago;
        private System.Windows.Forms.RadioButton optTransf;
        private System.Windows.Forms.RadioButton optEfvo;
        private System.Windows.Forms.RadioButton optCredito;
        private System.Windows.Forms.RadioButton optDebito;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblNomCli;
        private System.Windows.Forms.Label lblApCli;
        private System.Windows.Forms.Label lblApEmp;
        private System.Windows.Forms.Label lblNomEmp;
        private System.Windows.Forms.Label lblCombos;
        private System.Windows.Forms.Label lblPagos;
        private System.Windows.Forms.Label lblCodVenta;
        private System.Windows.Forms.TextBox txtCodVenta;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label lblNombCliEnc;
        private System.Windows.Forms.Label lblNombEmpEnc;
        private System.Windows.Forms.Label lblApCliEnc;
        private System.Windows.Forms.Label lblApEmpEnc;
        private System.Windows.Forms.Label lblHabilitado;
    }
}