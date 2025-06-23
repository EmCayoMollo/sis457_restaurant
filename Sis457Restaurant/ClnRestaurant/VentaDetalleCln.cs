using CadRestaurant;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClnRestaurant
{
	public class VentaDetalleCln
	{
		public static int insertar(VentaDetalle ventaDetalle)
		{
			using (var context = new FinalRestaurantEntities())
			{
				context.VentaDetalle.Add(ventaDetalle);
				context.SaveChanges();
				return ventaDetalle.id;
			}
		}


		public static int eliminar(int id, string usuarioRegistro)
		{
			using (var context = new FinalRestaurantEntities())
			{
				var ventaDetalle = context.VentaDetalle.Find(id);
				ventaDetalle.estado = -1;
				ventaDetalle.usuarioRegistro = usuarioRegistro;
				return context.SaveChanges();
			}
		}
	}
}
