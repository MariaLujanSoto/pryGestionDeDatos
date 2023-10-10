namespace pryGestionDeDatos
{
    partial class frmMostrarVentas
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
            this.dtvVentas = new System.Windows.Forms.DataGridView();
            this.Empleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montoVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtvVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVolver
            // 
            this.btnVolver.BackgroundImage = global::pryGestionDeDatos.Properties.Resources.istockphoto_1186803754_170667a;
            this.btnVolver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVolver.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(276, 244);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(157, 33);
            this.btnVolver.TabIndex = 34;
            this.btnVolver.Text = "VOLVER ATRAS";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // dtvVentas
            // 
            this.dtvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvVentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Empleado,
            this.Cliente,
            this.CodVenta,
            this.montoVenta});
            this.dtvVentas.Location = new System.Drawing.Point(86, 72);
            this.dtvVentas.Name = "dtvVentas";
            this.dtvVentas.Size = new System.Drawing.Size(556, 150);
            this.dtvVentas.TabIndex = 33;
            this.dtvVentas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtvVentas_CellContentClick);
            // 
            // Empleado
            // 
            this.Empleado.HeaderText = "Empleado";
            this.Empleado.Name = "Empleado";
            // 
            // Cliente
            // 
            this.Cliente.HeaderText = "Cliente";
            this.Cliente.Name = "Cliente";
            // 
            // CodVenta
            // 
            this.CodVenta.HeaderText = "Cód. Venta";
            this.CodVenta.Name = "CodVenta";
            // 
            // montoVenta
            // 
            this.montoVenta.HeaderText = "Monto Venta";
            this.montoVenta.Name = "montoVenta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(65, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 22);
            this.label1.TabIndex = 32;
            this.label1.Text = "Últimas Ventas Registradas";
            // 
            // frmMostrarVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::pryGestionDeDatos.Properties.Resources.descarga__7_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(738, 318);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.dtvVentas);
            this.Controls.Add(this.label1);
            this.Name = "frmMostrarVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de Ventas";
            this.Load += new System.EventHandler(this.frmMostrarVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtvVentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.DataGridView dtvVentas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Empleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn montoVenta;
    }
}