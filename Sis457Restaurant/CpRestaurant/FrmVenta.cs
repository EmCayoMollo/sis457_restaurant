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
	public partial class FrmVenta : Form
	{
		public FrmVenta()
		{
			InitializeComponent();
		}

		private void listar()
		{
			var lista = VentaDetalleCln.listar();
			dgvHistorial.DataSource = lista;
			//dgvHistorial.Columns["id"].Visible = false;
			//dgvHistorial.Columns["estado"].Visible = false;
			//dgvHistorial.Columns["idventa"].HeaderText="Id Venta";
			//dgvHistorial.Columns["idPlatillo"].HeaderText = "Id Platillo";
			dgvHistorial.Columns["total"].HeaderText= "Total";
			dgvHistorial.Columns["cantidad"].HeaderText = "Cantidad";
			dgvHistorial.Columns["precioUnitario"].HeaderText = "Precio Unitario";
			dgvHistorial.Columns["usuarioRegistro"].HeaderText = "Usuario Registro";
			dgvHistorial.Columns["fechaRegistro"].HeaderText = "Fecha Registro";
			//if (lista.Count > 0) dgvHistorial.CurrentCell = dgvHistorial.Rows[0].Cells["id"];
			//btnEditar.Enabled = lista.Count > 0;
			//btnEliminar.Enabled = lista.Count > 0;
		}

		private void FrmVenta_Load(object sender, EventArgs e)
		{
			listar();
		}


	}
}
