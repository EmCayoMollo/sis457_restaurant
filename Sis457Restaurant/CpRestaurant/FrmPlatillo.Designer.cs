namespace CpRestaurant
{
	partial class FrmPlatillo
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
			this.gbxDatos = new System.Windows.Forms.GroupBox();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.lblDescripcion = new System.Windows.Forms.Label();
			this.txtCodigo = new System.Windows.Forms.TextBox();
			this.lblCodigo = new System.Windows.Forms.Label();
			this.pnlAcciones = new System.Windows.Forms.Panel();
			this.gbxLista = new System.Windows.Forms.GroupBox();
			this.dgvLista = new System.Windows.Forms.DataGridView();
			this.txtParametro = new System.Windows.Forms.TextBox();
			this.lblParametro = new System.Windows.Forms.Label();
			this.lblTitulo = new System.Windows.Forms.Label();
			this.btnCancelar = new System.Windows.Forms.Button();
			this.btnGuardar = new System.Windows.Forms.Button();
			this.btnCerrar = new System.Windows.Forms.Button();
			this.btnEliminar = new System.Windows.Forms.Button();
			this.btnEditar = new System.Windows.Forms.Button();
			this.btnNuevo = new System.Windows.Forms.Button();
			this.btnBuscar = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.nudPrecio = new System.Windows.Forms.NumericUpDown();
			this.erpCodigo = new System.Windows.Forms.ErrorProvider(this.components);
			this.erpNombre = new System.Windows.Forms.ErrorProvider(this.components);
			this.erpPrecio = new System.Windows.Forms.ErrorProvider(this.components);
			this.gbxDatos.SuspendLayout();
			this.pnlAcciones.SuspendLayout();
			this.gbxLista.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvLista)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudPrecio)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.erpCodigo)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.erpNombre)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.erpPrecio)).BeginInit();
			this.SuspendLayout();
			// 
			// gbxDatos
			// 
			this.gbxDatos.Controls.Add(this.nudPrecio);
			this.gbxDatos.Controls.Add(this.label1);
			this.gbxDatos.Controls.Add(this.btnCancelar);
			this.gbxDatos.Controls.Add(this.btnGuardar);
			this.gbxDatos.Controls.Add(this.txtNombre);
			this.gbxDatos.Controls.Add(this.lblDescripcion);
			this.gbxDatos.Controls.Add(this.txtCodigo);
			this.gbxDatos.Controls.Add(this.lblCodigo);
			this.gbxDatos.Location = new System.Drawing.Point(5, 324);
			this.gbxDatos.Name = "gbxDatos";
			this.gbxDatos.Size = new System.Drawing.Size(795, 115);
			this.gbxDatos.TabIndex = 13;
			this.gbxDatos.TabStop = false;
			this.gbxDatos.Text = "Datos";
			// 
			// txtNombre
			// 
			this.txtNombre.Location = new System.Drawing.Point(134, 43);
			this.txtNombre.MaxLength = 250;
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(194, 20);
			this.txtNombre.TabIndex = 3;
			// 
			// lblDescripcion
			// 
			this.lblDescripcion.AutoSize = true;
			this.lblDescripcion.Location = new System.Drawing.Point(70, 46);
			this.lblDescripcion.Name = "lblDescripcion";
			this.lblDescripcion.Size = new System.Drawing.Size(47, 13);
			this.lblDescripcion.TabIndex = 2;
			this.lblDescripcion.Text = "Nombre:";
			// 
			// txtCodigo
			// 
			this.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtCodigo.Location = new System.Drawing.Point(134, 15);
			this.txtCodigo.MaxLength = 20;
			this.txtCodigo.Name = "txtCodigo";
			this.txtCodigo.Size = new System.Drawing.Size(194, 20);
			this.txtCodigo.TabIndex = 1;
			// 
			// lblCodigo
			// 
			this.lblCodigo.AutoSize = true;
			this.lblCodigo.Location = new System.Drawing.Point(74, 15);
			this.lblCodigo.Name = "lblCodigo";
			this.lblCodigo.Size = new System.Drawing.Size(43, 13);
			this.lblCodigo.TabIndex = 0;
			this.lblCodigo.Text = "Código:";
			// 
			// pnlAcciones
			// 
			this.pnlAcciones.Controls.Add(this.btnCerrar);
			this.pnlAcciones.Controls.Add(this.btnEliminar);
			this.pnlAcciones.Controls.Add(this.btnEditar);
			this.pnlAcciones.Controls.Add(this.btnNuevo);
			this.pnlAcciones.Location = new System.Drawing.Point(5, 275);
			this.pnlAcciones.Name = "pnlAcciones";
			this.pnlAcciones.Size = new System.Drawing.Size(795, 47);
			this.pnlAcciones.TabIndex = 12;
			// 
			// gbxLista
			// 
			this.gbxLista.Controls.Add(this.dgvLista);
			this.gbxLista.Location = new System.Drawing.Point(5, 90);
			this.gbxLista.Name = "gbxLista";
			this.gbxLista.Size = new System.Drawing.Size(795, 179);
			this.gbxLista.TabIndex = 11;
			this.gbxLista.TabStop = false;
			this.gbxLista.Text = "Lista de Platillos";
			// 
			// dgvLista
			// 
			this.dgvLista.AllowUserToAddRows = false;
			this.dgvLista.AllowUserToDeleteRows = false;
			this.dgvLista.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvLista.Location = new System.Drawing.Point(6, 21);
			this.dgvLista.Name = "dgvLista";
			this.dgvLista.ReadOnly = true;
			this.dgvLista.RowHeadersWidth = 62;
			this.dgvLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvLista.Size = new System.Drawing.Size(783, 150);
			this.dgvLista.TabIndex = 0;
			// 
			// txtParametro
			// 
			this.txtParametro.Location = new System.Drawing.Point(5, 62);
			this.txtParametro.MaxLength = 100;
			this.txtParametro.Name = "txtParametro";
			this.txtParametro.Size = new System.Drawing.Size(680, 20);
			this.txtParametro.TabIndex = 9;
			this.txtParametro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtParametro_KeyPress);
			// 
			// lblParametro
			// 
			this.lblParametro.AutoSize = true;
			this.lblParametro.Location = new System.Drawing.Point(5, 43);
			this.lblParametro.Name = "lblParametro";
			this.lblParametro.Size = new System.Drawing.Size(162, 13);
			this.lblParametro.TabIndex = 8;
			this.lblParametro.Text = "Buscar por Código o Descripción";
			// 
			// lblTitulo
			// 
			this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitulo.Location = new System.Drawing.Point(0, 12);
			this.lblTitulo.Name = "lblTitulo";
			this.lblTitulo.Size = new System.Drawing.Size(800, 31);
			this.lblTitulo.TabIndex = 7;
			this.lblTitulo.Text = "Platillos";
			this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnCancelar
			// 
			this.btnCancelar.Image = global::CpRestaurant.Properties.Resources.cancel_40dp_000000_FILL1_wght400_GRAD0_opsz40;
			this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCancelar.Location = new System.Drawing.Point(652, 32);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.btnCancelar.Size = new System.Drawing.Size(111, 40);
			this.btnCancelar.TabIndex = 11;
			this.btnCancelar.Text = "Cancelar";
			this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnCancelar.UseVisualStyleBackColor = true;
			this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
			// 
			// btnGuardar
			// 
			this.btnGuardar.Image = global::CpRestaurant.Properties.Resources.save_40dp_000000_FILL1_wght400_GRAD0_opsz40;
			this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnGuardar.Location = new System.Drawing.Point(541, 32);
			this.btnGuardar.Name = "btnGuardar";
			this.btnGuardar.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.btnGuardar.Size = new System.Drawing.Size(105, 40);
			this.btnGuardar.TabIndex = 10;
			this.btnGuardar.Text = "Guardar";
			this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnGuardar.UseVisualStyleBackColor = true;
			this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
			// 
			// btnCerrar
			// 
			this.btnCerrar.Image = global::CpRestaurant.Properties.Resources.close_50dp_000000_FILL0_wght500_GRAD0_opsz481;
			this.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCerrar.Location = new System.Drawing.Point(495, 3);
			this.btnCerrar.Name = "btnCerrar";
			this.btnCerrar.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.btnCerrar.Size = new System.Drawing.Size(96, 40);
			this.btnCerrar.TabIndex = 9;
			this.btnCerrar.Text = "Cerrar";
			this.btnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnCerrar.UseVisualStyleBackColor = true;
			this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
			// 
			// btnEliminar
			// 
			this.btnEliminar.Image = global::CpRestaurant.Properties.Resources.delete_40dp_000000_FILL1_wght400_GRAD0_opsz40;
			this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnEliminar.Location = new System.Drawing.Point(387, 3);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.btnEliminar.Size = new System.Drawing.Size(102, 40);
			this.btnEliminar.TabIndex = 8;
			this.btnEliminar.Text = "Eliminar";
			this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnEliminar.UseVisualStyleBackColor = true;
			this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
			// 
			// btnEditar
			// 
			this.btnEditar.Image = global::CpRestaurant.Properties.Resources.edit_40dp_000000_FILL1_wght400_GRAD0_opsz40;
			this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnEditar.Location = new System.Drawing.Point(283, 3);
			this.btnEditar.Name = "btnEditar";
			this.btnEditar.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.btnEditar.Size = new System.Drawing.Size(98, 40);
			this.btnEditar.TabIndex = 7;
			this.btnEditar.Text = "Editar";
			this.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnEditar.UseVisualStyleBackColor = true;
			this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
			// 
			// btnNuevo
			// 
			this.btnNuevo.Image = global::CpRestaurant.Properties.Resources.add_circle_40dp_000000_FILL1_wght400_GRAD0_opsz40;
			this.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnNuevo.Location = new System.Drawing.Point(179, 3);
			this.btnNuevo.Name = "btnNuevo";
			this.btnNuevo.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.btnNuevo.Size = new System.Drawing.Size(98, 40);
			this.btnNuevo.TabIndex = 6;
			this.btnNuevo.Text = "Nuevo";
			this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnNuevo.UseVisualStyleBackColor = true;
			this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
			// 
			// btnBuscar
			// 
			this.btnBuscar.Image = global::CpRestaurant.Properties.Resources.search_40dp_000000_FILL1_wght400_GRAD0_opsz40;
			this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnBuscar.Location = new System.Drawing.Point(702, 53);
			this.btnBuscar.Name = "btnBuscar";
			this.btnBuscar.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.btnBuscar.Size = new System.Drawing.Size(98, 40);
			this.btnBuscar.TabIndex = 10;
			this.btnBuscar.Text = "Buscar";
			this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnBuscar.UseVisualStyleBackColor = true;
			this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(70, 80);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(40, 13);
			this.label1.TabIndex = 12;
			this.label1.Text = "Precio:";
			// 
			// nudPrecio
			// 
			this.nudPrecio.Location = new System.Drawing.Point(134, 73);
			this.nudPrecio.Name = "nudPrecio";
			this.nudPrecio.Size = new System.Drawing.Size(194, 20);
			this.nudPrecio.TabIndex = 13;
			// 
			// erpCodigo
			// 
			this.erpCodigo.ContainerControl = this;
			// 
			// erpNombre
			// 
			this.erpNombre.ContainerControl = this;
			// 
			// erpPrecio
			// 
			this.erpPrecio.ContainerControl = this;
			// 
			// FrmPlatillo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.gbxDatos);
			this.Controls.Add(this.pnlAcciones);
			this.Controls.Add(this.gbxLista);
			this.Controls.Add(this.btnBuscar);
			this.Controls.Add(this.txtParametro);
			this.Controls.Add(this.lblParametro);
			this.Controls.Add(this.lblTitulo);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "FrmPlatillo";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "::: Platillos :::";
			this.Load += new System.EventHandler(this.FrmPlatillo_Load);
			this.gbxDatos.ResumeLayout(false);
			this.gbxDatos.PerformLayout();
			this.pnlAcciones.ResumeLayout(false);
			this.gbxLista.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvLista)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudPrecio)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.erpCodigo)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.erpNombre)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.erpPrecio)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox gbxDatos;
		private System.Windows.Forms.Button btnCancelar;
		private System.Windows.Forms.Button btnGuardar;
		private System.Windows.Forms.TextBox txtNombre;
		private System.Windows.Forms.Label lblDescripcion;
		private System.Windows.Forms.TextBox txtCodigo;
		private System.Windows.Forms.Label lblCodigo;
		private System.Windows.Forms.Panel pnlAcciones;
		private System.Windows.Forms.Button btnCerrar;
		private System.Windows.Forms.Button btnEliminar;
		private System.Windows.Forms.Button btnEditar;
		private System.Windows.Forms.Button btnNuevo;
		private System.Windows.Forms.GroupBox gbxLista;
		private System.Windows.Forms.DataGridView dgvLista;
		private System.Windows.Forms.Button btnBuscar;
		private System.Windows.Forms.TextBox txtParametro;
		private System.Windows.Forms.Label lblParametro;
		private System.Windows.Forms.Label lblTitulo;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.NumericUpDown nudPrecio;
		private System.Windows.Forms.ErrorProvider erpCodigo;
		private System.Windows.Forms.ErrorProvider erpNombre;
		private System.Windows.Forms.ErrorProvider erpPrecio;
	}
}