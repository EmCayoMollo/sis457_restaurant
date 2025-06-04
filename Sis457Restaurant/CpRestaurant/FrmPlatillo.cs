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
	public partial class FrmPlatillo : Form
	{
		private bool esNuevo = false;
		public FrmPlatillo()
		{
			InitializeComponent();
		}

		private void listar()
		{
			var lista = PlatilloCln.listarPa(txtParametro.Text.Trim());
			dgvLista.DataSource = lista;
			dgvLista.Columns["id"].Visible = false;
			dgvLista.Columns["estado"].Visible = false;
			dgvLista.Columns["codigo"].HeaderText = "Código";
			dgvLista.Columns["nombre"].HeaderText = "Nombre";
			dgvLista.Columns["precio"].HeaderText = "Precio de Venta";
			dgvLista.Columns["usuarioRegistro"].HeaderText = "Usuario Registro";
			dgvLista.Columns["fechaRegistro"].HeaderText = "Fecha Registro";
			if (lista.Count > 0) dgvLista.CurrentCell = dgvLista.Rows[0].Cells["codigo"];
			btnEditar.Enabled = lista.Count > 0;
			btnEliminar.Enabled = lista.Count > 0;
		}

		private void FrmPlatillo_Load(object sender, EventArgs e)
		{
			Size = new Size(816, 362);
			listar();
		}

		private void limpiar() 
		{
			txtCodigo.Clear();
			txtNombre.Clear();
			nudPrecio.Value = 0;
		}

		private void btnCancelar_Click(object sender, EventArgs e)
		{
			Size = new Size(816, 362);
			limpiar();
		}

		private void btnNuevo_Click(object sender, EventArgs e)
		{
			esNuevo = true;
			Size = new Size(816, 489);
			txtCodigo.Focus();
		}

		private void btnEditar_Click(object sender, EventArgs e)
		{
			esNuevo = false;
			Size = new Size(816, 489);

			int index = dgvLista.CurrentCell.RowIndex;
			int id = Convert.ToInt32(dgvLista.Rows[index].Cells["id"].Value);
			var platillo = PlatilloCln.obtenerUno(id);
			txtCodigo.Text = platillo.codigo;
			txtNombre.Text=platillo.nombre;
			nudPrecio.Value=platillo.precio;
			txtCodigo.Focus();
		}

		private void btnCerrar_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void btnBuscar_Click(object sender, EventArgs e)
		{
			listar();
		}

		private void txtParametro_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == (char)Keys.Enter) listar();
		}

		private bool validar() 
		{
			bool esValido = true;
			erpCodigo.SetError(txtCodigo, "");
			erpNombre.SetError(txtNombre, "");
			erpPrecio.SetError(nudPrecio, "");

			if (string.IsNullOrEmpty(txtCodigo.Text))
			{
				erpCodigo.SetError(txtCodigo, "El campo Código es obligatorio");
				esValido = false;
			}
			if (string.IsNullOrEmpty(txtNombre.Text)) 
			{
				erpNombre.SetError(txtNombre,"el campo Nombre es obligatorio");
				esValido=false;
			}
			if (nudPrecio.Value < 0) 
			{
				erpPrecio.SetError(nudPrecio, "el precio no debe ser menor a 0");
				esValido=false;
			}

			return esValido;
		}

		private void btnGuardar_Click(object sender, EventArgs e)
		{
			if (validar())
			{
				var platillo = new Platillo();
				platillo.codigo = txtCodigo.Text.Trim();
				platillo.nombre=txtNombre.Text.Trim();
				platillo.precio = nudPrecio.Value;
				platillo.usuarioRegistro = Util.usuario.usuario1;

				if (esNuevo)
				{
					platillo.fechaRegistro = DateTime.Now;
					platillo.estado = 1;
					PlatilloCln.insertar(platillo);
				}
				else
				{
					int index = dgvLista.CurrentCell.RowIndex;
					platillo.id = Convert.ToInt32(dgvLista.Rows[index].Cells["id"].Value);
					PlatilloCln.actualizar(platillo);
				}
				listar();
				btnCancelar.PerformClick();
				MessageBox.Show("Platillo guardado correctamente", "::: Restaurant - Mensaje :::",
					MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}

		private void btnEliminar_Click(object sender, EventArgs e)
		{
			int index = dgvLista.CurrentCell.RowIndex;
			int id = Convert.ToInt32(dgvLista.Rows[index].Cells["id"].Value);
			string codigo = dgvLista.Rows[index].Cells["codigo"].Value.ToString();
			DialogResult dialog = MessageBox.Show($"¿Está seguro de eliminar el Platillo {codigo}?",
				"::: Restaurant - Mensaje :::", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (dialog == DialogResult.Yes)
			{
				PlatilloCln.eliminar(id, Util.usuario.usuario1);
				listar();
				MessageBox.Show("Platillo dado de baja correctamente", "::: Restaurant - Mensaje :::",
					MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}
	}
}
