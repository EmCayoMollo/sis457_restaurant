namespace CpRestaurant
{
	partial class FrmCliente
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCliente));
			this.gbxDatos = new System.Windows.Forms.GroupBox();
			this.txtCelular = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.btnCancelar = new System.Windows.Forms.Button();
			this.btnGuardar = new System.Windows.Forms.Button();
			this.txtNombreCompleto = new System.Windows.Forms.TextBox();
			this.lblNombres = new System.Windows.Forms.Label();
			this.txtCi = new System.Windows.Forms.TextBox();
			this.lblCodigo = new System.Windows.Forms.Label();
			this.pnlAcciones = new System.Windows.Forms.Panel();
			this.btnCerrar = new System.Windows.Forms.Button();
			this.btnEliminar = new System.Windows.Forms.Button();
			this.btnEditar = new System.Windows.Forms.Button();
			this.btnNuevo = new System.Windows.Forms.Button();
			this.gbxLista = new System.Windows.Forms.GroupBox();
			this.dgvLista = new System.Windows.Forms.DataGridView();
			this.txtParametro = new System.Windows.Forms.TextBox();
			this.lblParametro = new System.Windows.Forms.Label();
			this.lblTitulo = new System.Windows.Forms.Label();
			this.btnBuscar = new System.Windows.Forms.Button();
			this.erpCi = new System.Windows.Forms.ErrorProvider(this.components);
			this.erpNombres = new System.Windows.Forms.ErrorProvider(this.components);
			this.erpApellidos = new System.Windows.Forms.ErrorProvider(this.components);
			this.erpCelular = new System.Windows.Forms.ErrorProvider(this.components);
			this.gbxDatos.SuspendLayout();
			this.pnlAcciones.SuspendLayout();
			this.gbxLista.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvLista)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.erpCi)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.erpNombres)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.erpApellidos)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.erpCelular)).BeginInit();
			this.SuspendLayout();
			// 
			// gbxDatos
			// 
			this.gbxDatos.Controls.Add(this.txtCelular);
			this.gbxDatos.Controls.Add(this.label2);
			this.gbxDatos.Controls.Add(this.btnCancelar);
			this.gbxDatos.Controls.Add(this.btnGuardar);
			this.gbxDatos.Controls.Add(this.txtNombreCompleto);
			this.gbxDatos.Controls.Add(this.lblNombres);
			this.gbxDatos.Controls.Add(this.txtCi);
			this.gbxDatos.Controls.Add(this.lblCodigo);
			this.gbxDatos.Location = new System.Drawing.Point(5, 324);
			this.gbxDatos.Name = "gbxDatos";
			this.gbxDatos.Size = new System.Drawing.Size(795, 115);
			this.gbxDatos.TabIndex = 20;
			this.gbxDatos.TabStop = false;
			this.gbxDatos.Text = "Datos";
			// 
			// txtCelular
			// 
			this.txtCelular.Location = new System.Drawing.Point(293, 32);
			this.txtCelular.MaxLength = 250;
			this.txtCelular.Name = "txtCelular";
			this.txtCelular.Size = new System.Drawing.Size(194, 20);
			this.txtCelular.TabIndex = 8;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(247, 36);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(42, 13);
			this.label2.TabIndex = 14;
			this.label2.Text = "Celular:";
			// 
			// btnCancelar
			// 
			this.btnCancelar.Image = global::CpRestaurant.Properties.Resources.cancel_40dp_000000_FILL1_wght400_GRAD0_opsz40;
			this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCancelar.Location = new System.Drawing.Point(615, 61);
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
			this.btnGuardar.Location = new System.Drawing.Point(495, 61);
			this.btnGuardar.Name = "btnGuardar";
			this.btnGuardar.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.btnGuardar.Size = new System.Drawing.Size(105, 40);
			this.btnGuardar.TabIndex = 10;
			this.btnGuardar.Text = "Guardar";
			this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnGuardar.UseVisualStyleBackColor = true;
			this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
			// 
			// txtNombreCompleto
			// 
			this.txtNombreCompleto.Location = new System.Drawing.Point(164, 73);
			this.txtNombreCompleto.MaxLength = 250;
			this.txtNombreCompleto.Name = "txtNombreCompleto";
			this.txtNombreCompleto.Size = new System.Drawing.Size(302, 20);
			this.txtNombreCompleto.TabIndex = 3;
			// 
			// lblNombres
			// 
			this.lblNombres.AutoSize = true;
			this.lblNombres.Location = new System.Drawing.Point(65, 75);
			this.lblNombres.Name = "lblNombres";
			this.lblNombres.Size = new System.Drawing.Size(94, 13);
			this.lblNombres.TabIndex = 2;
			this.lblNombres.Text = "Nombre Completo:";
			// 
			// txtCi
			// 
			this.txtCi.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtCi.Location = new System.Drawing.Point(35, 32);
			this.txtCi.MaxLength = 20;
			this.txtCi.Name = "txtCi";
			this.txtCi.Size = new System.Drawing.Size(194, 20);
			this.txtCi.TabIndex = 1;
			// 
			// lblCodigo
			// 
			this.lblCodigo.AutoSize = true;
			this.lblCodigo.Location = new System.Drawing.Point(9, 36);
			this.lblCodigo.Name = "lblCodigo";
			this.lblCodigo.Size = new System.Drawing.Size(20, 13);
			this.lblCodigo.TabIndex = 0;
			this.lblCodigo.Text = "CI:";
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
			// gbxLista
			// 
			this.gbxLista.Controls.Add(this.dgvLista);
			this.gbxLista.Location = new System.Drawing.Point(5, 90);
			this.gbxLista.Name = "gbxLista";
			this.gbxLista.Size = new System.Drawing.Size(795, 179);
			this.gbxLista.TabIndex = 18;
			this.gbxLista.TabStop = false;
			this.gbxLista.Text = "Lista de Clientes";
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
			this.lblParametro.Size = new System.Drawing.Size(120, 13);
			this.lblParametro.TabIndex = 15;
			this.lblParametro.Text = "Buscar por CI o Nombre";
			// 
			// lblTitulo
			// 
			this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitulo.Location = new System.Drawing.Point(0, 12);
			this.lblTitulo.Name = "lblTitulo";
			this.lblTitulo.Size = new System.Drawing.Size(800, 31);
			this.lblTitulo.TabIndex = 14;
			this.lblTitulo.Text = "Clientes";
			this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
			// erpCi
			// 
			this.erpCi.ContainerControl = this;
			// 
			// erpNombres
			// 
			this.erpNombres.ContainerControl = this;
			// 
			// erpApellidos
			// 
			this.erpApellidos.ContainerControl = this;
			// 
			// erpCelular
			// 
			this.erpCelular.ContainerControl = this;
			this.erpCelular.Icon = ((System.Drawing.Icon)(resources.GetObject("erpCelular.Icon")));
			// 
			// FrmCliente
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
			this.Name = "FrmCliente";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "::: Restaurant - Clientes :::";
			this.Load += new System.EventHandler(this.FrmCliente_Load);
			this.gbxDatos.ResumeLayout(false);
			this.gbxDatos.PerformLayout();
			this.pnlAcciones.ResumeLayout(false);
			this.gbxLista.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvLista)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.erpCi)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.erpNombres)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.erpApellidos)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.erpCelular)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox gbxDatos;
		private System.Windows.Forms.Button btnCancelar;
		private System.Windows.Forms.Button btnGuardar;
		private System.Windows.Forms.TextBox txtNombreCompleto;
		private System.Windows.Forms.Label lblNombres;
		private System.Windows.Forms.TextBox txtCi;
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
		private System.Windows.Forms.TextBox txtCelular;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ErrorProvider erpCi;
		private System.Windows.Forms.ErrorProvider erpNombres;
		private System.Windows.Forms.ErrorProvider erpApellidos;
		private System.Windows.Forms.ErrorProvider erpCelular;
	}
}