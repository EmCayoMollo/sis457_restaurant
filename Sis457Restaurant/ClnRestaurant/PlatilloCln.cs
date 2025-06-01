using CadRestaurant;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClnRestaurant
{
	public class PlatilloCln
	{
		public static int insertar(Platillo platillo)
		{
			using (var context = new LabRestaurantEntities())
			{
				context.Platillo.Add(platillo);
				context.SaveChanges();
				return platillo.id;
			}
		}

		public static int actualizar(Platillo platillo)
		{
			using (var context = new LabRestaurantEntities())
			{
				var existente = context.Platillo.Find(platillo.id);
				existente.codigo = platillo.codigo;
				existente.nombre = platillo.nombre;
				existente.precio=platillo.precio;
				existente.usuarioRegistro = platillo.usuarioRegistro;
				return context.SaveChanges();
			}
		}

		public static int eliminar(int id, string usuario)
		{
			using (var context = new LabRestaurantEntities())
			{
				var platillo = context.Platillo.Find(id);
				platillo.estado = -1;
				platillo.usuarioRegistro = usuario;
				return context.SaveChanges();
			}
		}

		public static Platillo obtenerUno(int id)
		{
			using (var context = new LabRestaurantEntities())
			{
				return context.Platillo.Find(id);
			}
		}

		public static List<Platillo> listar()
		{
			using (var context = new LabRestaurantEntities())
			{
				return context.Platillo.Where(x => x.estado != -1).ToList();
			}
		}

		public static List<paPlatilloListar_Result> listarPa(string parametro)
		{
			using (var context = new LabRestaurantEntities())
			{
				return context.paPlatilloListar(parametro).ToList();
			}
		}
	}
}
