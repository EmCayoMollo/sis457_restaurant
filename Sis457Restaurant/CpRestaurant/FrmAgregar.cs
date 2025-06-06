using CadRestaurant;
using ClnRestaurant;
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
	public partial class FrmAgregar : Form
	{
		public FrmAgregar()
		{
			InitializeComponent();
		}

		private bool validar()
		{
			bool esValido = true;
			erpCi.SetError(txtCi, "");
			erpNombres.SetError(txtNombreCompleto, "");

			if (string.IsNullOrEmpty(txtCi.Text))
			{
				erpCi.SetError(txtCi, "El campo Cedula de identidad es obligatorio");
				esValido = false;
			}
			if (string.IsNullOrEmpty(txtNombreCompleto.Text))
			{
				erpNombres.SetError(txtNombreCompleto, "el campo Nombres es obligatorio");
				esValido = false;
			}
			if (string.IsNullOrEmpty(txtCelular.Text))
			{
				erpCelular.SetError(txtCelular, "El campo Celular es obligatorio");
				esValido = false;
			}

			return esValido;
		}
		private void btnGuardar_Click(object sender, EventArgs e)
		{
			if (validar())
			{
				var cliente = new Cliente();
				cliente.ci = txtCi.Text.Trim();
				cliente.nombreCompleto = txtNombreCompleto.Text.Trim();
				cliente.celular = long.Parse(txtCelular.Text.Trim());
				cliente.usuarioRegistro = Util.usuario.usuario1;

				
					cliente.fechaRegistro = DateTime.Now;
					cliente.estado = 1;
					ClienteCln.insertar(cliente);
				
				MessageBox.Show("Cliente guardado correctamente", "::: Restaurant - Mensaje :::",
					MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			ClienteCln.listar();
			Close();
		}

		private void btnCancelar_Click(object sender, EventArgs e)
		{
			
			Close();
		}
	}
}
