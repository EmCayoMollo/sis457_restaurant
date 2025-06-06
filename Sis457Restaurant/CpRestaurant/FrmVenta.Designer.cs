namespace CpRestaurant
{
	partial class FrmVenta
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
			this.components = new System.ComponentModel.Container();
			this.cbxCi = new System.Windows.Forms.ComboBox();
			this.gbxCliente = new System.Windows.Forms.GroupBox();
			this.label8 = new System.Windows.Forms.Label();
			this.nudPrecioUnitario = new System.Windows.Forms.NumericUpDown();
			this.nudCantidad = new System.Windows.Forms.NumericUpDown();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.cbxPlatillos = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.lblTitulo = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.btnCancelarVenta = new System.Windows.Forms.Button();
			this.btnGuardarVenta = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.dgvHistorial = new System.Windows.Forms.DataGridView();
			this.btnCerrar = new System.Windows.Forms.Button();
			this.erpCi = new System.Windows.Forms.ErrorProvider(this.components);
			this.erpPlatillos = new System.Windows.Forms.ErrorProvider(this.components);
			this.nudEfectivo = new System.Windows.Forms.NumericUpDown();
			this.nudTotal = new System.Windows.Forms.NumericUpDown();
			this.nudCambio = new System.Windows.Forms.NumericUpDown();
			this.gbxCliente.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudPrecioUnitario)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvHistorial)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.erpCi)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.erpPlatillos)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudEfectivo)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudTotal)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudCambio)).BeginInit();
			this.SuspendLayout();
			// 
			// cbxCi
			// 
			this.cbxCi.FormattingEnabled = true;
			this.cbxCi.Location = new System.Drawing.Point(94, 38);
			this.cbxCi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.cbxCi.Name = "cbxCi";
			this.cbxCi.Size = new System.Drawing.Size(180, 28);
			this.cbxCi.TabIndex = 0;
			// 
			// gbxCliente
			// 
			this.gbxCliente.Controls.Add(this.label8);
			this.gbxCliente.Controls.Add(this.nudPrecioUnitario);
			this.gbxCliente.Controls.Add(this.nudCantidad);
			this.gbxCliente.Controls.Add(this.label7);
			this.gbxCliente.Controls.Add(this.label6);
			this.gbxCliente.Controls.Add(this.cbxPlatillos);
			this.gbxCliente.Controls.Add(this.label5);
			this.gbxCliente.Controls.Add(this.button1);
			this.gbxCliente.Controls.Add(this.cbxCi);
			this.gbxCliente.Location = new System.Drawing.Point(18, 51);
			this.gbxCliente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.gbxCliente.Name = "gbxCliente";
			this.gbxCliente.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.gbxCliente.Size = new System.Drawing.Size(556, 218);
			this.gbxCliente.TabIndex = 1;
			this.gbxCliente.TabStop = false;
			this.gbxCliente.Text = "Cliente";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(285, 94);
			this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(57, 20);
			this.label8.TabIndex = 10;
			this.label8.Text = "Precio:";
			// 
			// nudPrecioUnitario
			// 
			this.nudPrecioUnitario.Location = new System.Drawing.Point(354, 89);
			this.nudPrecioUnitario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.nudPrecioUnitario.Name = "nudPrecioUnitario";
			this.nudPrecioUnitario.Size = new System.Drawing.Size(180, 26);
			this.nudPrecioUnitario.TabIndex = 9;
			// 
			// nudCantidad
			// 
			this.nudCantidad.Location = new System.Drawing.Point(94, 178);
			this.nudCantidad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.nudCantidad.Name = "nudCantidad";
			this.nudCantidad.Size = new System.Drawing.Size(180, 26);
			this.nudCantidad.TabIndex = 8;
			this.nudCantidad.ValueChanged += new System.EventHandler(this.nudCantidad_ValueChanged);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(8, 182);
			this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(77, 20);
			this.label7.TabIndex = 7;
			this.label7.Text = "Cantidad:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(12, 43);
			this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(62, 20);
			this.label6.TabIndex = 5;
			this.label6.Text = "Cliente:";
			// 
			// cbxPlatillos
			// 
			this.cbxPlatillos.FormattingEnabled = true;
			this.cbxPlatillos.Location = new System.Drawing.Point(94, 89);
			this.cbxPlatillos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.cbxPlatillos.Name = "cbxPlatillos";
			this.cbxPlatillos.Size = new System.Drawing.Size(180, 28);
			this.cbxPlatillos.TabIndex = 4;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(12, 94);
			this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(72, 20);
			this.label5.TabIndex = 3;
			this.label5.Text = "PLatillos:";
			// 
			// button1
			// 
			this.button1.Image = global::CpRestaurant.Properties.Resources.person_add_40dp_000000_FILL1_wght400_GRAD0_opsz40;
			this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button1.Location = new System.Drawing.Point(285, 20);
			this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(250, 65);
			this.button1.TabIndex = 2;
			this.button1.Text = "Agregar Cliente Nuevo";
			this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// lblTitulo
			// 
			this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitulo.Location = new System.Drawing.Point(0, -2);
			this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblTitulo.Name = "lblTitulo";
			this.lblTitulo.Size = new System.Drawing.Size(1200, 48);
			this.lblTitulo.TabIndex = 2;
			this.lblTitulo.Text = "Registro de Ventas";
			this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(660, 83);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(48, 20);
			this.label2.TabIndex = 3;
			this.label2.Text = "Total:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(638, 125);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(70, 20);
			this.label3.TabIndex = 4;
			this.label3.Text = "Efectivo:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(644, 166);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(67, 20);
			this.label4.TabIndex = 5;
			this.label4.Text = "Cambio:";
			// 
			// btnCancelarVenta
			// 
			this.btnCancelarVenta.BackColor = System.Drawing.Color.OrangeRed;
			this.btnCancelarVenta.Image = global::CpRestaurant.Properties.Resources.cancel_40dp_000000_FILL1_wght400_GRAD0_opsz40;
			this.btnCancelarVenta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCancelarVenta.Location = new System.Drawing.Point(926, 145);
			this.btnCancelarVenta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnCancelarVenta.Name = "btnCancelarVenta";
			this.btnCancelarVenta.Size = new System.Drawing.Size(200, 74);
			this.btnCancelarVenta.TabIndex = 10;
			this.btnCancelarVenta.Text = "Cancelar Venta";
			this.btnCancelarVenta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnCancelarVenta.UseVisualStyleBackColor = false;
			this.btnCancelarVenta.Click += new System.EventHandler(this.btnCancelarVenta_Click);
			// 
			// btnGuardarVenta
			// 
			this.btnGuardarVenta.BackColor = System.Drawing.Color.LimeGreen;
			this.btnGuardarVenta.Image = global::CpRestaurant.Properties.Resources.save_40dp_000000_FILL1_wght400_GRAD0_opsz40;
			this.btnGuardarVenta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnGuardarVenta.Location = new System.Drawing.Point(926, 62);
			this.btnGuardarVenta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnGuardarVenta.Name = "btnGuardarVenta";
			this.btnGuardarVenta.Size = new System.Drawing.Size(201, 74);
			this.btnGuardarVenta.TabIndex = 9;
			this.btnGuardarVenta.Text = "Guardar Venta";
			this.btnGuardarVenta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnGuardarVenta.UseVisualStyleBackColor = false;
			this.btnGuardarVenta.Click += new System.EventHandler(this.btnGuardarVenta_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.dgvHistorial);
			this.groupBox1.Location = new System.Drawing.Point(18, 292);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.groupBox1.Size = new System.Drawing.Size(1164, 382);
			this.groupBox1.TabIndex = 11;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Historial de Ventas";
			// 
			// dgvHistorial
			// 
			this.dgvHistorial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvHistorial.Location = new System.Drawing.Point(9, 29);
			this.dgvHistorial.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.dgvHistorial.Name = "dgvHistorial";
			this.dgvHistorial.RowHeadersWidth = 62;
			this.dgvHistorial.Size = new System.Drawing.Size(1146, 343);
			this.dgvHistorial.TabIndex = 0;
			// 
			// btnCerrar
			// 
			this.btnCerrar.Location = new System.Drawing.Point(926, 228);
			this.btnCerrar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnCerrar.Name = "btnCerrar";
			this.btnCerrar.Size = new System.Drawing.Size(200, 55);
			this.btnCerrar.TabIndex = 12;
			this.btnCerrar.Text = "Cerrar";
			this.btnCerrar.UseVisualStyleBackColor = true;
			this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
			// 
			// erpCi
			// 
			this.erpCi.ContainerControl = this;
			// 
			// erpPlatillos
			// 
			this.erpPlatillos.ContainerControl = this;
			// 
			// nudEfectivo
			// 
			this.nudEfectivo.Location = new System.Drawing.Point(720, 123);
			this.nudEfectivo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.nudEfectivo.Name = "nudEfectivo";
			this.nudEfectivo.Size = new System.Drawing.Size(148, 26);
			this.nudEfectivo.TabIndex = 11;
			this.nudEfectivo.ValueChanged += new System.EventHandler(this.nudEfectivo_ValueChanged);
			// 
			// nudTotal
			// 
			this.nudTotal.Location = new System.Drawing.Point(720, 81);
			this.nudTotal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.nudTotal.Name = "nudTotal";
			this.nudTotal.Size = new System.Drawing.Size(148, 26);
			this.nudTotal.TabIndex = 13;
			// 
			// nudCambio
			// 
			this.nudCambio.Location = new System.Drawing.Point(719, 164);
			this.nudCambio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.nudCambio.Name = "nudCambio";
			this.nudCambio.Size = new System.Drawing.Size(148, 26);
			this.nudCambio.TabIndex = 14;
			// 
			// FrmVenta
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1200, 692);
			this.Controls.Add(this.nudCambio);
			this.Controls.Add(this.nudTotal);
			this.Controls.Add(this.nudEfectivo);
			this.Controls.Add(this.btnCerrar);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.btnCancelarVenta);
			this.Controls.Add(this.btnGuardarVenta);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.lblTitulo);
			this.Controls.Add(this.gbxCliente);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "FrmVenta";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FrmVenta";
			this.Load += new System.EventHandler(this.FrmVenta_Load);
			this.gbxCliente.ResumeLayout(false);
			this.gbxCliente.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudPrecioUnitario)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvHistorial)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.erpCi)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.erpPlatillos)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudEfectivo)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudTotal)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudCambio)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox cbxCi;
		private System.Windows.Forms.GroupBox gbxCliente;
		private System.Windows.Forms.Label lblTitulo;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button btnGuardarVenta;
		private System.Windows.Forms.Button btnCancelarVenta;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.DataGridView dgvHistorial;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ComboBox cbxPlatillos;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button btnCerrar;
		private System.Windows.Forms.ErrorProvider erpCi;
		private System.Windows.Forms.ErrorProvider erpPlatillos;
		private System.Windows.Forms.NumericUpDown nudCantidad;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.NumericUpDown nudPrecioUnitario;
		private System.Windows.Forms.NumericUpDown nudEfectivo;
		private System.Windows.Forms.NumericUpDown nudCambio;
		private System.Windows.Forms.NumericUpDown nudTotal;
	}
}