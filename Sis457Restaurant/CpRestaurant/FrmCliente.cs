using CadRestaurant;
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
	public partial class FrmCliente : Form
	{
		private bool esNuevo = false;

		public FrmCliente()
		{
			InitializeComponent();
		}

		private void listar()
		{
			var lista = ClienteCln.listarPa(txtParametro.Text.Trim());
			dgvLista.DataSource = lista;
			dgvLista.Columns["id"].Visible = false;
			dgvLista.Columns["estado"].Visible = false;
			dgvLista.Columns["ci"].HeaderText = "CI";
			dgvLista.Columns["nombreCompleto"].HeaderText = "Nombre Completo";
			dgvLista.Columns["celular"].HeaderText = "Celular";
			dgvLista.Columns["usuarioRegistro"].HeaderText = "Usuario Registro";
			dgvLista.Columns["fechaRegistro"].HeaderText = "Fecha Registro";
			if (lista.Count > 0) dgvLista.CurrentCell = dgvLista.Rows[0].Cells["ci"];
			btnEditar.Enabled = lista.Count > 0;
			btnEliminar.Enabled = lista.Count > 0;
		}

		private void FrmCliente_Load(object sender, EventArgs e)
		{
			Size = new Size(816, 362);
			listar();
		}

		private void btnBuscar_Click(object sender, EventArgs e)
		{
			listar();
		}

		private void btnNuevo_Click(object sender, EventArgs e)
		{
			esNuevo = true;
			Size = new Size(816, 489);
			txtCi.Focus();
		}

		private void btnEditar_Click(object sender, EventArgs e)
		{
			esNuevo = false;
			Size = new Size(816, 489);

			int index = dgvLista.CurrentCell.RowIndex;
			int id = Convert.ToInt32(dgvLista.Rows[index].Cells["id"].Value);
			var cliente = ClienteCln.obtenerId(id);
			txtCi.Text = cliente.ci;
			txtNombreCompleto.Text = cliente.nombreCompleto;
			txtCelular.Text = cliente.celular.ToString();
			txtCi.Focus();
		}

		private void btnEliminar_Click(object sender, EventArgs e)
		{
			int index = dgvLista.CurrentCell.RowIndex;
			int id = Convert.ToInt32(dgvLista.Rows[index].Cells["id"].Value);
			string ci = dgvLista.Rows[index].Cells["ci"].Value.ToString();
			DialogResult dialog = MessageBox.Show($"¿Está seguro de eliminar el cliente {ci}?",
				"::: Restaurant - Mensaje :::", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (dialog == DialogResult.Yes)
			{
				ClienteCln.eliminar(id, Util.usuario.usuario1);
				listar();
				MessageBox.Show("Cliente dado de baja correctamente", "::: Restaurant - Mensaje :::",
					MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}

		private void btnCerrar_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void limpiar()
		{
			txtCi.Clear();
			txtNombreCompleto.Clear();
			txtCelular.Clear();
		}

		private void btnCancelar_Click(object sender, EventArgs e)
		{
			Size = new Size(816, 362);
			limpiar();
		}

		private void txtParametro_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == (char)Keys.Enter) listar();
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

				if (esNuevo)
				{
					cliente.fechaRegistro = DateTime.Now;
					cliente.estado = 1;
					ClienteCln.insertar(cliente);
				}
				else
				{
					int index = dgvLista.CurrentCell.RowIndex;
					cliente.id = Convert.ToInt32(dgvLista.Rows[index].Cells["id"].Value);
					ClienteCln.actualizar(cliente);
				}
				listar();
				btnCancelar.PerformClick();
				MessageBox.Show("Cliente guardado correctamente", "::: Restaurant - Mensaje :::",
					MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}
	}
}
