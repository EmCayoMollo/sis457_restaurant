using CadRestaurant;
using System.Data.Entity;
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

		public static List<Venta> listar()
		{
			using (var context = new LabRestaurantEntities())
			{
				return context.Venta.Include(x => x.Cliente)
			.Include(x => x.Platillo).Where(x => x.estado != -1).ToList();
			}
		}

	}
}
