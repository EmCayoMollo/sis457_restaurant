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
	public partial class FrmVenta : Form
	{
		public FrmVenta()
		{
			InitializeComponent();
		}

		private void listarVenta()
		{
			var lista = VentaCln.listar().Select(x => new {
				x.id,
				Cliente = x.Cliente != null ? x.Cliente.nombreCompleto : "", // o x.Cliente.nombres según tu modelo
				Platillo = x.Platillo != null ? x.Platillo.nombre : "",
				x.precioUnitario,
				x.cantidad,
				x.total,
				x.efectivo,
				x.cambio,
				x.usuarioRegistro,
				x.fechaRegistro
			}).ToList();
			dgvHistorial.DataSource = lista;
			dgvHistorial.Columns["Cliente"].HeaderText="Nombre del Cliente";
			dgvHistorial.Columns["Platillo"].HeaderText = "Nombre de Platillo";
			dgvHistorial.Columns["precioUnitario"].HeaderText = "Precio Unitario";
			dgvHistorial.Columns["cantidad"].HeaderText = "Cantidad";
			dgvHistorial.Columns["total"].HeaderText = "Total";
			dgvHistorial.Columns["efectivo"].HeaderText = "Efectivo";
			dgvHistorial.Columns["cambio"].HeaderText = "Cambio";
			dgvHistorial.Columns["usuarioRegistro"].HeaderText = "Usuario Registro";
			dgvHistorial.Columns["fechaRegistro"].HeaderText = "Fecha de Registro";
		}


		private void FrmVenta_Load(object sender, EventArgs e)
		{
			listarVenta();
			cargarCi();
			cargarPlatillos();
			nudTotal.Enabled = false;
			nudCambio.Enabled = false;
		}

		private void btnCerrar_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void limpiar() 
		{ 
			cbxCi.SelectedIndex=-1;
			cbxPlatillos.SelectedIndex=-1;
			nudCantidad.Value = 0;
			nudPrecioUnitario.Value = 0;
			nudTotal.Value = 0;
			nudEfectivo.Value = 0;
			nudCambio.Value = 0;
		}

		private void btnCancelarVenta_Click(object sender, EventArgs e)
		{
			limpiar();
		}

		private bool validar()
		{
			bool esValido = true;
			erpCi.SetError(cbxCi, "");
			erpPlatillos.SetError(cbxPlatillos, "");

			if (string.IsNullOrEmpty(cbxCi.Text))
			{ 
				erpCi.SetError(cbxCi, "Debe seleccionar un cliente");
				esValido = false;
			}
			if (string.IsNullOrEmpty(cbxPlatillos.Text))
			{
				erpPlatillos.SetError(cbxPlatillos, "Debe seleccionar un platillo");
				esValido = false;
			}

			return esValido;
		}

		private void cargarCi()
		{
			var ci = ClienteCln.listar();
			cbxCi.DataSource = ci;
			cbxCi.DisplayMember = "nombreCompleto";
			cbxCi.ValueMember = "id";
		}

		private void cargarPlatillos()
		{
			var platillos = PlatilloCln.listar();
			cbxPlatillos.DataSource = platillos;
			cbxPlatillos.DisplayMember = "nombre";
			cbxPlatillos.ValueMember = "id";
		}

		private void btnGuardarVenta_Click(object sender, EventArgs e)
		{
			if (validar()) {
				var venta = new Venta();
				venta.idPlatillo = Convert.ToInt32(cbxPlatillos.SelectedValue);
				venta.idCliente = Convert.ToInt32(cbxCi.SelectedValue);
				venta.precioUnitario = nudPrecioUnitario.Value;
				venta.cantidad = (int)nudCantidad.Value;
				venta.total = nudTotal.Value;
				venta.efectivo = nudEfectivo.Value;
				venta.cambio = nudCambio.Value;
				venta.usuarioRegistro = Util.usuario.usuario1;
				venta.fechaRegistro = DateTime.Now;
				venta.estado = 1;
				
				VentaCln.insertar(venta);
			}
			listarVenta();
			MessageBox.Show("Venta guardada correctamente", "::: Restaurant - Mensaje :::",
					MessageBoxButtons.OK, MessageBoxIcon.Information);
			limpiar();
		}


		private void nudCantidad_ValueChanged(object sender, EventArgs e)
		{
			if (nudCantidad.Value != 0 && nudPrecioUnitario.Value != 0)
			{
				nudTotal.Value=nudCantidad.Value * nudPrecioUnitario.Value;
			}
		}

		private void nudEfectivo_ValueChanged(object sender, EventArgs e)
		{
			if ( nudEfectivo.Value>nudTotal.Value)
			{
				nudCambio.Value = nudEfectivo.Value - nudTotal.Value;
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			new FrmAgregar().ShowDialog();
			cargarCi();
		}
	}
}
