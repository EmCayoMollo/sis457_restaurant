﻿using System;
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
	public partial class FrmPrincipal : Form
	{
		public FrmPrincipal()
		{
			InitializeComponent();
		}

		private void btnPlatillos_Click(object sender, EventArgs e)
		{
			new FrmPlatillo().ShowDialog();
		}

		private void btnEmpleado_Click(object sender, EventArgs e)
		{
			new FrmEmpleado().ShowDialog();
		}

		private void btnClientes_Click(object sender, EventArgs e)
		{
			new FrmCliente().ShowDialog();
		}

		private void btnVenta_Click(object sender, EventArgs e)
		{
			new FrmVenta().ShowDialog();
		}
	}
}
