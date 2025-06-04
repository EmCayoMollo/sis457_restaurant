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
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.gbxCliente = new System.Windows.Forms.GroupBox();
			this.lblTitulo = new System.Windows.Forms.Label();
			this.gbxHistorial = new System.Windows.Forms.GroupBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.button4 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.dgvHistorial = new System.Windows.Forms.DataGridView();
			this.gbxCliente.SuspendLayout();
			this.gbxHistorial.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvHistorial)).BeginInit();
			this.SuspendLayout();
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(63, 25);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(121, 21);
			this.comboBox1.TabIndex = 0;
			// 
			// gbxCliente
			// 
			this.gbxCliente.Controls.Add(this.button4);
			this.gbxCliente.Controls.Add(this.button1);
			this.gbxCliente.Controls.Add(this.label1);
			this.gbxCliente.Controls.Add(this.comboBox1);
			this.gbxCliente.Location = new System.Drawing.Point(12, 33);
			this.gbxCliente.Name = "gbxCliente";
			this.gbxCliente.Size = new System.Drawing.Size(371, 142);
			this.gbxCliente.TabIndex = 1;
			this.gbxCliente.TabStop = false;
			this.gbxCliente.Text = "Cliente";
			// 
			// lblTitulo
			// 
			this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitulo.Location = new System.Drawing.Point(0, -1);
			this.lblTitulo.Name = "lblTitulo";
			this.lblTitulo.Size = new System.Drawing.Size(800, 31);
			this.lblTitulo.TabIndex = 2;
			this.lblTitulo.Text = "Registro de Ventas";
			this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// gbxHistorial
			// 
			this.gbxHistorial.Controls.Add(this.dgvHistorial);
			this.gbxHistorial.Location = new System.Drawing.Point(12, 191);
			this.gbxHistorial.Name = "gbxHistorial";
			this.gbxHistorial.Size = new System.Drawing.Size(776, 220);
			this.gbxHistorial.TabIndex = 3;
			this.gbxHistorial.TabStop = false;
			this.gbxHistorial.Text = "Historial";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(20, 28);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(37, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Ci/Nit:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(440, 54);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(34, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Total:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(425, 81);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(49, 13);
			this.label3.TabIndex = 4;
			this.label3.Text = "Efectivo:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(429, 108);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(45, 13);
			this.label4.TabIndex = 5;
			this.label4.Text = "Cambio:";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(480, 51);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(100, 20);
			this.textBox1.TabIndex = 6;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(480, 78);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(100, 20);
			this.textBox2.TabIndex = 7;
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(480, 105);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(100, 20);
			this.textBox3.TabIndex = 8;
			// 
			// button4
			// 
			this.button4.Image = global::CpRestaurant.Properties.Resources.add_shopping_cart_40dp_000000_FILL1_wght400_GRAD0_opsz40;
			this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button4.Location = new System.Drawing.Point(34, 61);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(135, 75);
			this.button4.TabIndex = 11;
			this.button4.Text = "Agregar Platiilos";
			this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.button4.UseVisualStyleBackColor = true;
			// 
			// button3
			// 
			this.button3.Image = global::CpRestaurant.Properties.Resources.cancel_40dp_000000_FILL1_wght400_GRAD0_opsz40;
			this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button3.Location = new System.Drawing.Point(617, 94);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(133, 48);
			this.button3.TabIndex = 10;
			this.button3.Text = "Cancelar Venta";
			this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.button3.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			this.button2.Image = global::CpRestaurant.Properties.Resources.save_40dp_000000_FILL1_wght400_GRAD0_opsz40;
			this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button2.Location = new System.Drawing.Point(617, 40);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(134, 48);
			this.button2.TabIndex = 9;
			this.button2.Text = "Guardar Venta";
			this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.button2.UseVisualStyleBackColor = true;
			// 
			// button1
			// 
			this.button1.Image = global::CpRestaurant.Properties.Resources.person_add_40dp_000000_FILL1_wght400_GRAD0_opsz40;
			this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button1.Location = new System.Drawing.Point(193, 19);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(167, 46);
			this.button1.TabIndex = 2;
			this.button1.Text = "Agregar Cliente Nuevo";
			this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.button1.UseVisualStyleBackColor = true;
			// 
			// dgvHistorial
			// 
			this.dgvHistorial.AllowUserToAddRows = false;
			this.dgvHistorial.AllowUserToDeleteRows = false;
			this.dgvHistorial.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dgvHistorial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvHistorial.Location = new System.Drawing.Point(6, 19);
			this.dgvHistorial.Name = "dgvHistorial";
			this.dgvHistorial.ReadOnly = true;
			this.dgvHistorial.RowHeadersWidth = 62;
			this.dgvHistorial.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvHistorial.Size = new System.Drawing.Size(764, 195);
			this.dgvHistorial.TabIndex = 1;
			// 
			// FrmVenta
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.gbxHistorial);
			this.Controls.Add(this.lblTitulo);
			this.Controls.Add(this.gbxCliente);
			this.Name = "FrmVenta";
			this.Text = "FrmVenta";
			this.Load += new System.EventHandler(this.FrmVenta_Load);
			this.gbxCliente.ResumeLayout(false);
			this.gbxCliente.PerformLayout();
			this.gbxHistorial.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvHistorial)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.GroupBox gbxCliente;
		private System.Windows.Forms.Label lblTitulo;
		private System.Windows.Forms.GroupBox gbxHistorial;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.DataGridView dgvHistorial;
	}
}