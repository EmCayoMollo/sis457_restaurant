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
			using (var context = new LabRestaurantEntities())
			{
				context.Cliente.Add(cliente);
				context.SaveChanges();
				return cliente.id;
			}
		}

		public static int actualizar(Cliente cliente)
		{
			using (var context = new LabRestaurantEntities())
			{
				var existente = context.Cliente.Find(cliente.id);
				existente.ci = cliente.ci;
				existente.nombres = cliente.nombres;
				existente.apellidos = cliente.apellidos;
				existente.celular= cliente.celular;
				existente.usuarioRegistro = cliente.usuarioRegistro;
				return context.SaveChanges();
			}
		}

		public static int eliminar(int id, string usuario)
		{
			using (var context = new LabRestaurantEntities())
			{
				var cliente = context.Cliente.Find(id);
				cliente.estado = -1;
				cliente.usuarioRegistro = usuario;
				return context.SaveChanges();
			}
		}

		public static Cliente obtenerUno(int id)
		{
			using (var context = new LabRestaurantEntities())
			{
				return context.Cliente.Find(id);
			}
		}

		public static List<Cliente> listar()
		{
			using (var context = new LabRestaurantEntities())
			{
				return context.Cliente.Where(x => x.estado != -1).ToList();
			}
		}

		public static List<paClienteListar_Result> listarPa(string parametro)
		{
			using (var context = new LabRestaurantEntities())
			{
				return context.paClienteListar(parametro).ToList();
			}
		}
	}
}
