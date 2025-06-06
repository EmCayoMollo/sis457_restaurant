namespace CpRestaurant
{
	partial class Autenticacion
	{
		/// <summary>
		/// Variable del diseñador necesaria.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpiar los recursos que se estén usando.
		/// </summary>
		/// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código generado por el Diseñador de Windows Forms

		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido de este método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Autenticacion));
			this.txtClave = new System.Windows.Forms.TextBox();
			this.lblClave = new System.Windows.Forms.Label();
			this.txtUsuario = new System.Windows.Forms.TextBox();
			this.lblUsuario = new System.Windows.Forms.Label();
			this.lblTitulo = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.btnIngresar = new System.Windows.Forms.Button();
			this.btnSalir = new System.Windows.Forms.Button();
			this.erpUsuario = new System.Windows.Forms.ErrorProvider(this.components);
			this.erpClave = new System.Windows.Forms.ErrorProvider(this.components);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.erpUsuario)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.erpClave)).BeginInit();
			this.SuspendLayout();
			// 
			// txtClave
			// 
			this.txtClave.Location = new System.Drawing.Point(163, 108);
			this.txtClave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txtClave.MaxLength = 30;
			this.txtClave.Name = "txtClave";
			this.txtClave.PasswordChar = '*';
			this.txtClave.Size = new System.Drawing.Size(207, 22);
			this.txtClave.TabIndex = 17;
			this.txtClave.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtClave_KeyPress);
			// 
			// lblClave
			// 
			this.lblClave.AutoSize = true;
			this.lblClave.Location = new System.Drawing.Point(49, 112);
			this.lblClave.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblClave.Name = "lblClave";
			this.lblClave.Size = new System.Drawing.Size(79, 16);
			this.lblClave.TabIndex = 16;
			this.lblClave.Text = "Contraseña:";
			// 
			// txtUsuario
			// 
			this.txtUsuario.Location = new System.Drawing.Point(163, 74);
			this.txtUsuario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txtUsuario.MaxLength = 20;
			this.txtUsuario.Name = "txtUsuario";
			this.txtUsuario.Size = new System.Drawing.Size(207, 22);
			this.txtUsuario.TabIndex = 15;
			// 
			// lblUsuario
			// 
			this.lblUsuario.AutoSize = true;
			this.lblUsuario.Location = new System.Drawing.Point(79, 78);
			this.lblUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblUsuario.Name = "lblUsuario";
			this.lblUsuario.Size = new System.Drawing.Size(57, 16);
			this.lblUsuario.TabIndex = 14;
			this.lblUsuario.Text = "Usuario:";
			// 
			// lblTitulo
			// 
			this.lblTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitulo.Location = new System.Drawing.Point(45, 21);
			this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblTitulo.Name = "lblTitulo";
			this.lblTitulo.Size = new System.Drawing.Size(491, 38);
			this.lblTitulo.TabIndex = 13;
			this.lblTitulo.Text = "Iniciar Sesión";
			this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::CpRestaurant.Properties.Resources.account_circle_100dp_000000_FILL0_wght700_GRAD0_opsz48;
			this.pictureBox1.Location = new System.Drawing.Point(389, 59);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(149, 143);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 20;
			this.pictureBox1.TabStop = false;
			// 
			// btnIngresar
			// 
			this.btnIngresar.Image = global::CpRestaurant.Properties.Resources.login_50dp_000000_FILL0_wght500_GRAD0_opsz48;
			this.btnIngresar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnIngresar.Location = new System.Drawing.Point(115, 153);
			this.btnIngresar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnIngresar.Name = "btnIngresar";
			this.btnIngresar.Padding = new System.Windows.Forms.Padding(7, 0, 7, 0);
			this.btnIngresar.Size = new System.Drawing.Size(141, 63);
			this.btnIngresar.TabIndex = 19;
			this.btnIngresar.Text = "Ingresar";
			this.btnIngresar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnIngresar.UseVisualStyleBackColor = true;
			this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
			// 
			// btnSalir
			// 
			this.btnSalir.Image = global::CpRestaurant.Properties.Resources.close_50dp_000000_FILL0_wght500_GRAD0_opsz48;
			this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnSalir.Location = new System.Drawing.Point(264, 153);
			this.btnSalir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnSalir.Name = "btnSalir";
			this.btnSalir.Padding = new System.Windows.Forms.Padding(7, 0, 7, 0);
			this.btnSalir.Size = new System.Drawing.Size(117, 63);
			this.btnSalir.TabIndex = 18;
			this.btnSalir.Text = "Salir";
			this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnSalir.UseVisualStyleBackColor = true;
			this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
			// 
			// erpUsuario
			// 
			this.erpUsuario.ContainerControl = this;
			// 
			// erpClave
			// 
			this.erpClave.ContainerControl = this;
			// 
			// Autenticacion
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.ClientSize = new System.Drawing.Size(592, 268);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.btnIngresar);
			this.Controls.Add(this.btnSalir);
			this.Controls.Add(this.txtClave);
			this.Controls.Add(this.lblClave);
			this.Controls.Add(this.txtUsuario);
			this.Controls.Add(this.lblUsuario);
			this.Controls.Add(this.lblTitulo);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "Autenticacion";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "::: Autenticacion :::";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.erpUsuario)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.erpClave)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button btnIngresar;
		private System.Windows.Forms.Button btnSalir;
		private System.Windows.Forms.TextBox txtClave;
		private System.Windows.Forms.Label lblClave;
		private System.Windows.Forms.TextBox txtUsuario;
		private System.Windows.Forms.Label lblUsuario;
		private System.Windows.Forms.Label lblTitulo;
		private System.Windows.Forms.ErrorProvider erpUsuario;
		private System.Windows.Forms.ErrorProvider erpClave;
	}
}

