using CadRestaurant;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClnRestaurant
{
	public class VentaCln
	{
		public static int insertar(Venta venta)
		{
			using (var context = new LabRestaurantEntities())
			{
				context.Venta.Add(venta);
				context.SaveChanges();
				return venta.id;
			}
		}

		public static int actualizar(Venta venta)
		{
			using (var context = new LabRestaurantEntities())
			{
				var existente = context.Venta.Find(venta.id);
				existente.idCliente = venta.idCliente;
				existente.idEmpleado = venta.idEmpleado;
				existente.razonSocial = venta.razonSocial;
				existente.fechaRegistro = venta.fechaRegistro;
				existente.usuarioRegistro = venta.usuarioRegistro;
				return context.SaveChanges();
			}
		}

		public static int eliminar(int id, string usuarioRegistro)
		{
			using (var context = new LabRestaurantEntities())
			{
				var venta = context.Venta.Find(id);
				venta.estado = -1;
				venta.usuarioRegistro = usuarioRegistro;
				return context.SaveChanges();
			}
		}

	}
}
