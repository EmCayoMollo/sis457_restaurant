namespace CpRestaurant
{
	partial class FrmEmpleado
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
			this.label1 = new System.Windows.Forms.Label();
			this.txtNombres = new System.Windows.Forms.TextBox();
			this.lblNombres = new System.Windows.Forms.Label();
			this.txtCedulaIdentidad = new System.Windows.Forms.TextBox();
			this.lblCedulaIdentidad = new System.Windows.Forms.Label();
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
			this.txtPrimerApellido = new System.Windows.Forms.TextBox();
			this.txtSegundoApellido = new System.Windows.Forms.TextBox();
			this.lblSegundoApellido = new System.Windows.Forms.Label();
			this.txtDireccion = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtCelular = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.cbxCargo = new System.Windows.Forms.ComboBox();
			this.txtUsuario = new System.Windows.Forms.TextBox();
			this.lblUsuario = new System.Windows.Forms.Label();
			this.erpCedulaIdentidad = new System.Windows.Forms.ErrorProvider(this.components);
			this.erpNombres = new System.Windows.Forms.ErrorProvider(this.components);
			this.erpApellidos = new System.Windows.Forms.ErrorProvider(this.components);
			this.erpDireccion = new System.Windows.Forms.ErrorProvider(this.components);
			this.erpCelular = new System.Windows.Forms.ErrorProvider(this.components);
			this.erpCargo = new System.Windows.Forms.ErrorProvider(this.components);
			this.gbxDatos.SuspendLayout();
			this.pnlAcciones.SuspendLayout();
			this.gbxLista.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvLista)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.erpCedulaIdentidad)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.erpNombres)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.erpApellidos)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.erpDireccion)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.erpCelular)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.erpCargo)).BeginInit();
			this.SuspendLayout();
			// 
			// gbxDatos
			// 
			this.gbxDatos.Controls.Add(this.txtUsuario);
			this.gbxDatos.Controls.Add(this.lblUsuario);
			this.gbxDatos.Controls.Add(this.cbxCargo);
			this.gbxDatos.Controls.Add(this.label4);
			this.gbxDatos.Controls.Add(this.txtCelular);
			this.gbxDatos.Controls.Add(this.label3);
			this.gbxDatos.Controls.Add(this.txtDireccion);
			this.gbxDatos.Controls.Add(this.label2);
			this.gbxDatos.Controls.Add(this.txtSegundoApellido);
			this.gbxDatos.Controls.Add(this.lblSegundoApellido);
			this.gbxDatos.Controls.Add(this.txtPrimerApellido);
			this.gbxDatos.Controls.Add(this.label1);
			this.gbxDatos.Controls.Add(this.btnCancelar);
			this.gbxDatos.Controls.Add(this.btnGuardar);
			this.gbxDatos.Controls.Add(this.txtNombres);
			this.gbxDatos.Controls.Add(this.lblNombres);
			this.gbxDatos.Controls.Add(this.txtCedulaIdentidad);
			this.gbxDatos.Controls.Add(this.lblCedulaIdentidad);
			this.gbxDatos.Location = new System.Drawing.Point(5, 324);
			this.gbxDatos.Name = "gbxDatos";
			this.gbxDatos.Size = new System.Drawing.Size(795, 115);
			this.gbxDatos.TabIndex = 20;
			this.gbxDatos.TabStop = false;
			this.gbxDatos.Text = "Datos";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(3, 92);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(79, 13);
			this.label1.TabIndex = 12;
			this.label1.Text = "Primer Apellido:";
			// 
			// txtNombres
			// 
			this.txtNombres.Location = new System.Drawing.Point(82, 55);
			this.txtNombres.MaxLength = 250;
			this.txtNombres.Name = "txtNombres";
			this.txtNombres.Size = new System.Drawing.Size(194, 20);
			this.txtNombres.TabIndex = 3;
			// 
			// lblNombres
			// 
			this.lblNombres.AutoSize = true;
			this.lblNombres.Location = new System.Drawing.Point(18, 58);
			this.lblNombres.Name = "lblNombres";
			this.lblNombres.Size = new System.Drawing.Size(52, 13);
			this.lblNombres.TabIndex = 2;
			this.lblNombres.Text = "Nombres:";
			// 
			// txtCedulaIdentidad
			// 
			this.txtCedulaIdentidad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtCedulaIdentidad.Location = new System.Drawing.Point(82, 27);
			this.txtCedulaIdentidad.MaxLength = 20;
			this.txtCedulaIdentidad.Name = "txtCedulaIdentidad";
			this.txtCedulaIdentidad.Size = new System.Drawing.Size(194, 20);
			this.txtCedulaIdentidad.TabIndex = 1;
			// 
			// lblCedulaIdentidad
			// 
			this.lblCedulaIdentidad.AutoSize = true;
			this.lblCedulaIdentidad.Location = new System.Drawing.Point(22, 27);
			this.lblCedulaIdentidad.Name = "lblCedulaIdentidad";
			this.lblCedulaIdentidad.Size = new System.Drawing.Size(20, 13);
			this.lblCedulaIdentidad.TabIndex = 0;
			this.lblCedulaIdentidad.Text = "CI:";
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
			this.pnlAcciones.TabIndex = 19;
			// 
			// gbxLista
			// 
			this.gbxLista.Controls.Add(this.dgvLista);
			this.gbxLista.Location = new System.Drawing.Point(5, 90);
			this.gbxLista.Name = "gbxLista";
			this.gbxLista.Size = new System.Drawing.Size(795, 179);
			this.gbxLista.TabIndex = 18;
			this.gbxLista.TabStop = false;
			this.gbxLista.Text = "Lista de Empleados";
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
			this.txtParametro.TabIndex = 16;
			this.txtParametro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtParametro_KeyPress);
			// 
			// lblParametro
			// 
			this.lblParametro.AutoSize = true;
			this.lblParametro.Location = new System.Drawing.Point(5, 43);
			this.lblParametro.Name = "lblParametro";
			this.lblParametro.Size = new System.Drawing.Size(168, 13);
			this.lblParametro.TabIndex = 15;
			this.lblParametro.Text = "Buscar por CI, Nombre o Apellidos";
			// 
			// lblTitulo
			// 
			this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitulo.Location = new System.Drawing.Point(0, 12);
			this.lblTitulo.Name = "lblTitulo";
			this.lblTitulo.Size = new System.Drawing.Size(800, 31);
			this.lblTitulo.TabIndex = 14;
			this.lblTitulo.Text = "Empleados";
			this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnCancelar
			// 
			this.btnCancelar.Image = global::CpRestaurant.Properties.Resources.cancel_40dp_000000_FILL1_wght400_GRAD0_opsz40;
			this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCancelar.Location = new System.Drawing.Point(672, 69);
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
			this.btnGuardar.Location = new System.Drawing.Point(561, 70);
			this.btnGuardar.Name = "btnGuardar";
			this.btnGuardar.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.btnGuardar.Size = new System.Drawing.Size(102, 40);
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
			this.btnBuscar.TabIndex = 17;
			this.btnBuscar.Text = "Buscar";
			this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnBuscar.UseVisualStyleBackColor = true;
			this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
			// 
			// txtPrimerApellido
			// 
			this.txtPrimerApellido.Location = new System.Drawing.Point(82, 89);
			this.txtPrimerApellido.MaxLength = 250;
			this.txtPrimerApellido.Name = "txtPrimerApellido";
			this.txtPrimerApellido.Size = new System.Drawing.Size(194, 20);
			this.txtPrimerApellido.TabIndex = 13;
			// 
			// txtSegundoApellido
			// 
			this.txtSegundoApellido.Location = new System.Drawing.Point(378, 20);
			this.txtSegundoApellido.MaxLength = 250;
			this.txtSegundoApellido.Name = "txtSegundoApellido";
			this.txtSegundoApellido.Size = new System.Drawing.Size(194, 20);
			this.txtSegundoApellido.TabIndex = 15;
			// 
			// lblSegundoApellido
			// 
			this.lblSegundoApellido.AutoSize = true;
			this.lblSegundoApellido.Location = new System.Drawing.Point(282, 23);
			this.lblSegundoApellido.Name = "lblSegundoApellido";
			this.lblSegundoApellido.Size = new System.Drawing.Size(93, 13);
			this.lblSegundoApellido.TabIndex = 14;
			this.lblSegundoApellido.Text = "Segundo Apellido:";
			// 
			// txtDireccion
			// 
			this.txtDireccion.Location = new System.Drawing.Point(352, 52);
			this.txtDireccion.MaxLength = 250;
			this.txtDireccion.Name = "txtDireccion";
			this.txtDireccion.Size = new System.Drawing.Size(194, 20);
			this.txtDireccion.TabIndex = 17;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(291, 55);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(55, 13);
			this.label2.TabIndex = 16;
			this.label2.Text = "Direccion:";
			// 
			// txtCelular
			// 
			this.txtCelular.Location = new System.Drawing.Point(352, 81);
			this.txtCelular.MaxLength = 250;
			this.txtCelular.Name = "txtCelular";
			this.txtCelular.Size = new System.Drawing.Size(194, 20);
			this.txtCelular.TabIndex = 19;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(305, 84);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(41, 13);
			this.label3.TabIndex = 18;
			this.label3.Text = "celular:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(598, 19);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(38, 13);
			this.label4.TabIndex = 20;
			this.label4.Text = "Cargo:";
			// 
			// cbxCargo
			// 
			this.cbxCargo.FormattingEnabled = true;
			this.cbxCargo.Items.AddRange(new object[] {
            "cajero",
            "cocina",
            "mesero"});
			this.cbxCargo.Location = new System.Drawing.Point(642, 16);
			this.cbxCargo.Name = "cbxCargo";
			this.cbxCargo.Size = new System.Drawing.Size(121, 21);
			this.cbxCargo.TabIndex = 21;
			// 
			// txtUsuario
			// 
			this.txtUsuario.Location = new System.Drawing.Point(642, 43);
			this.txtUsuario.MaxLength = 250;
			this.txtUsuario.Name = "txtUsuario";
			this.txtUsuario.Size = new System.Drawing.Size(137, 20);
			this.txtUsuario.TabIndex = 23;
			// 
			// lblUsuario
			// 
			this.lblUsuario.AutoSize = true;
			this.lblUsuario.Location = new System.Drawing.Point(581, 46);
			this.lblUsuario.Name = "lblUsuario";
			this.lblUsuario.Size = new System.Drawing.Size(46, 13);
			this.lblUsuario.TabIndex = 22;
			this.lblUsuario.Text = "Usuario:";
			// 
			// erpCedulaIdentidad
			// 
			this.erpCedulaIdentidad.ContainerControl = this;
			// 
			// erpNombres
			// 
			this.erpNombres.ContainerControl = this;
			// 
			// erpApellidos
			// 
			this.erpApellidos.ContainerControl = this;
			// 
			// erpDireccion
			// 
			this.erpDireccion.ContainerControl = this;
			// 
			// erpCelular
			// 
			this.erpCelular.ContainerControl = this;
			// 
			// erpCargo
			// 
			this.erpCargo.ContainerControl = this;
			// 
			// FrmEmpleado
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
			this.Name = "FrmEmpleado";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "::: Restaurant - Empleado :::";
			this.Load += new System.EventHandler(this.FrmEmpleado_Load);
			this.gbxDatos.ResumeLayout(false);
			this.gbxDatos.PerformLayout();
			this.pnlAcciones.ResumeLayout(false);
			this.gbxLista.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvLista)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.erpCedulaIdentidad)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.erpNombres)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.erpApellidos)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.erpDireccion)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.erpCelular)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.erpCargo)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox gbxDatos;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnCancelar;
		private System.Windows.Forms.Button btnGuardar;
		private System.Windows.Forms.TextBox txtNombres;
		private System.Windows.Forms.Label lblNombres;
		private System.Windows.Forms.TextBox txtCedulaIdentidad;
		private System.Windows.Forms.Label lblCedulaIdentidad;
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
		private System.Windows.Forms.TextBox txtPrimerApellido;
		private System.Windows.Forms.TextBox txtSegundoApellido;
		private System.Windows.Forms.Label lblSegundoApellido;
		private System.Windows.Forms.TextBox txtCelular;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtDireccion;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox cbxCargo;
		private System.Windows.Forms.TextBox txtUsuario;
		private System.Windows.Forms.Label lblUsuario;
		private System.Windows.Forms.ErrorProvider erpCedulaIdentidad;
		private System.Windows.Forms.ErrorProvider erpNombres;
		private System.Windows.Forms.ErrorProvider erpApellidos;
		private System.Windows.Forms.ErrorProvider erpDireccion;
		private System.Windows.Forms.ErrorProvider erpCelular;
		private System.Windows.Forms.ErrorProvider erpCargo;
	}
}