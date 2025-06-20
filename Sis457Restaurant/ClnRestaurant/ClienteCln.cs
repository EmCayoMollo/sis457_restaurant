using CadRestaurant;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClnRestaurant
{
	public class ClienteCln
	{
		public static int insertar(Cliente cliente)
		{
			using (var context = new FinalRestaurantEntities())
			{
				context.Cliente.Add(cliente);
				context.SaveChanges();
				return cliente.id;
			}
		}

		public static int actualizar(Cliente cliente)
		{
			using (var context = new FinalRestaurantEntities())
			{
				var existente = context.Cliente.Find(cliente.id);
				existente.nit = cliente.nit;
				existente.nombreCompleto = cliente.nombreCompleto;
				existente.celular= cliente.celular;
				existente.usuarioRegistro = cliente.usuarioRegistro;
				return context.SaveChanges();
			}
		}

		public static int eliminar(int id, string usuario)
		{
			using (var context = new FinalRestaurantEntities())
			{
				var cliente = context.Cliente.Find(id);
				cliente.estado = -1;
				cliente.usuarioRegistro = usuario;
				return context.SaveChanges();
			}
		}

		public static Cliente obtenerId(int id)
		{
			using (var context = new FinalRestaurantEntities())
			{
				return context.Cliente.Find(id);
			}
		}

		public static Cliente obtenerNombre(string nombreCompleto)
		{
			using (var context = new FinalRestaurantEntities())
			{
				return context.Cliente.FirstOrDefault(x => x.nombreCompleto == nombreCompleto && x.estado != -1);
			}
		}

		public static List<Cliente> listar()
		{
			using (var context = new FinalRestaurantEntities())
			{
				return context.Cliente.Where(x => x.estado != -1).ToList();
			}
		}

		//public static List<paClienteListar_Result> listarPa(string parametro)
		//{
		//	using (var context = new FinalRestaurantEntities())
		//	{
		//		return context.paClienteListar(parametro).ToList();
		//	}
		//}
	}
}
