using ClnRestaurant;
using CpRestaurant;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CpRestaurant
{
	public partial class Autenticacion : Form
	{
		public Autenticacion()
		{
			InitializeComponent();
		}

		private bool validar()
		{
			bool esValido = true;
			erpUsuario.SetError(txtUsuario, "");
			erpClave.SetError(txtClave, "");
			if (string.IsNullOrEmpty(txtUsuario.Text))
			{
				erpUsuario.SetError(txtUsuario, "usuario obligatorio");
				esValido = false;
			}
			if (string.IsNullOrEmpty(txtClave.Text))
			{
				erpClave.SetError(txtClave, "la clve onbligatorio");
				esValido = false;
			}
			return esValido;
		}
		private void btnIngresar_Click(object sender, EventArgs e)
		{
			if (validar())
			{
				var usuario = UsuarioCln.validar(txtUsuario.Text, Util.Encrypt(txtClave.Text));
				if (usuario != null)
				{
					Util.usuario = usuario;
					txtClave.Clear();
					txtUsuario.SelectAll();
					new FrmPrincipal().ShowDialog();

				}
				else
				{
					MessageBox.Show("usuario y/o contraseña incorrecta", ":::Minerva-mensaje:::",
						MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		private void btnSalir_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void txtClave_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == (char)Keys.Enter) btnIngresar.PerformClick();
		}
	}
}
