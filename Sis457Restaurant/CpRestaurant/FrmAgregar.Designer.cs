namespace CpRestaurant
{
	partial class FrmAgregar
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAgregar));
			this.gbxDatos = new System.Windows.Forms.GroupBox();
			this.txtCelular = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.btnCancelar = new System.Windows.Forms.Button();
			this.btnGuardar = new System.Windows.Forms.Button();
			this.txtNombreCompleto = new System.Windows.Forms.TextBox();
			this.lblNombres = new System.Windows.Forms.Label();
			this.txtCi = new System.Windows.Forms.TextBox();
			this.lblCodigo = new System.Windows.Forms.Label();
			this.lblTitulo = new System.Windows.Forms.Label();
			this.erpCi = new System.Windows.Forms.ErrorProvider(this.components);
			this.erpNombres = new System.Windows.Forms.ErrorProvider(this.components);
			this.erpApellidos = new System.Windows.Forms.ErrorProvider(this.components);
			this.erpCelular = new System.Windows.Forms.ErrorProvider(this.components);
			this.gbxDatos.SuspendLayout();
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
			this.gbxDatos.Location = new System.Drawing.Point(19, 93);
			this.gbxDatos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.gbxDatos.Name = "gbxDatos";
			this.gbxDatos.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.gbxDatos.Size = new System.Drawing.Size(1192, 313);
			this.gbxDatos.TabIndex = 21;
			this.gbxDatos.TabStop = false;
			this.gbxDatos.Text = "Datos";
			// 
			// txtCelular
			// 
			this.txtCelular.Location = new System.Drawing.Point(93, 146);
			this.txtCelular.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtCelular.MaxLength = 250;
			this.txtCelular.Name = "txtCelular";
			this.txtCelular.Size = new System.Drawing.Size(289, 26);
			this.txtCelular.TabIndex = 8;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(23, 151);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(62, 20);
			this.label2.TabIndex = 14;
			this.label2.Text = "Celular:";
			// 
			// btnCancelar
			// 
			this.btnCancelar.Image = global::CpRestaurant.Properties.Resources.cancel_40dp_000000_FILL1_wght400_GRAD0_opsz40;
			this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCancelar.Location = new System.Drawing.Point(886, 182);
			this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
			this.btnCancelar.Size = new System.Drawing.Size(166, 62);
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
			this.btnGuardar.Location = new System.Drawing.Point(648, 182);
			this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnGuardar.Name = "btnGuardar";
			this.btnGuardar.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
			this.btnGuardar.Size = new System.Drawing.Size(158, 62);
			this.btnGuardar.TabIndex = 10;
			this.btnGuardar.Text = "Guardar";
			this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnGuardar.UseVisualStyleBackColor = true;
			this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
			// 
			// txtNombreCompleto
			// 
			this.txtNombreCompleto.Location = new System.Drawing.Point(169, 94);
			this.txtNombreCompleto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtNombreCompleto.MaxLength = 250;
			this.txtNombreCompleto.Name = "txtNombreCompleto";
			this.txtNombreCompleto.Size = new System.Drawing.Size(451, 26);
			this.txtNombreCompleto.TabIndex = 3;
			// 
			// lblNombres
			// 
			this.lblNombres.AutoSize = true;
			this.lblNombres.Location = new System.Drawing.Point(20, 97);
			this.lblNombres.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblNombres.Name = "lblNombres";
			this.lblNombres.Size = new System.Drawing.Size(141, 20);
			this.lblNombres.TabIndex = 2;
			this.lblNombres.Text = "Nombre Completo:";
			// 
			// txtCi
			// 
			this.txtCi.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtCi.Location = new System.Drawing.Point(65, 46);
			this.txtCi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtCi.MaxLength = 20;
			this.txtCi.Name = "txtCi";
			this.txtCi.Size = new System.Drawing.Size(289, 26);
			this.txtCi.TabIndex = 1;
			// 
			// lblCodigo
			// 
			this.lblCodigo.AutoSize = true;
			this.lblCodigo.Location = new System.Drawing.Point(27, 51);
			this.lblCodigo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblCodigo.Name = "lblCodigo";
			this.lblCodigo.Size = new System.Drawing.Size(29, 20);
			this.lblCodigo.TabIndex = 0;
			this.lblCodigo.Text = "CI:";
			// 
			// lblTitulo
			// 
			this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitulo.Location = new System.Drawing.Point(11, 9);
			this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblTitulo.Name = "lblTitulo";
			this.lblTitulo.Size = new System.Drawing.Size(1200, 48);
			this.lblTitulo.TabIndex = 15;
			this.lblTitulo.Text = "Agregar Cliente Nuevo";
			this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
			// FrmAgregar
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1226, 486);
			this.Controls.Add(this.lblTitulo);
			this.Controls.Add(this.gbxDatos);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "FrmAgregar";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "::: Agregar - Cliente :::";
			this.gbxDatos.ResumeLayout(false);
			this.gbxDatos.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.erpCi)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.erpNombres)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.erpApellidos)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.erpCelular)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox gbxDatos;
		private System.Windows.Forms.TextBox txtCelular;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnCancelar;
		private System.Windows.Forms.Button btnGuardar;
		private System.Windows.Forms.TextBox txtNombreCompleto;
		private System.Windows.Forms.Label lblNombres;
		private System.Windows.Forms.TextBox txtCi;
		private System.Windows.Forms.Label lblCodigo;
		private System.Windows.Forms.Label lblTitulo;
		private System.Windows.Forms.ErrorProvider erpCi;
		private System.Windows.Forms.ErrorProvider erpNombres;
		private System.Windows.Forms.ErrorProvider erpApellidos;
		private System.Windows.Forms.ErrorProvider erpCelular;
	}
}