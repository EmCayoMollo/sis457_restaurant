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
		public static int insertar(VentaDetalle ventaDetalle, Usuario usuario)
		{
			using (var context = new LabRestaurantEntities())
			{
				context.VentaDetalle.Add(ventaDetalle);
				context.SaveChanges();

				//if (usuario != null && UsuarioCln.obtenerUnoPorEmpleado(empleado.id) == null)
				//{
				//	usuario.idEmpleado = empleado.id;
				//	usuario.usuarioRegistro = empleado.usuarioRegistro;
				//	usuario.fechaRegistro = empleado.fechaRegistro;
				//	usuario.estado = empleado.estado;
				//	UsuarioCln.insertar(usuario);
				//}

				return ventaDetalle.id;
			}
		}

		public static int actualizar(VentaDetalle ventaDetalle, string nombreUsuario, string clave)
		{
			using (var context = new LabRestaurantEntities())
			{
				var existente = context.VentaDetalle.Find(ventaDetalle.id);
				existente.idVenta = ventaDetalle.idVenta;
				existente.idPlatillo = ventaDetalle.idPlatillo;
				existente.cantidad = ventaDetalle.cantidad;
				existente.precioUnitario = ventaDetalle.precioUnitario;
				existente.total = ventaDetalle.total;

				existente.usuarioRegistro = ventaDetalle.usuarioRegistro;
				existente.fechaRegistro = ventaDetalle.fechaRegistro;

				if (!string.IsNullOrEmpty(nombreUsuario))
				{
					var usuario = UsuarioCln.obtenerUnoPorEmpleado(existente.id);
					if (usuario != null)
					{
						usuario.usuario1 = nombreUsuario;
						usuario.usuarioRegistro = ventaDetalle.usuarioRegistro;
						UsuarioCln.actualizar(usuario);
					}
					else
					{
						usuario = new Usuario
						{
							idEmpleado = existente.id,
							usuario1 = nombreUsuario,
							clave = clave,
							estado = 1,
							fechaRegistro = DateTime.Now,
							usuarioRegistro = ventaDetalle.usuarioRegistro
						};
						UsuarioCln.insertar(usuario);
					}
				}

				return context.SaveChanges();
			}
		}

		public static int eliminar(int id, string usuario)
		{
			using (var context = new LabRestaurantEntities())
			{
				var ventaDetalle = context.VentaDetalle.Find(id);
				ventaDetalle.estado = -1;
				ventaDetalle.usuarioRegistro = usuario;

				//var usuarioEmpleado = UsuarioCln.obtenerUnoPorEmpleado(empleado.id);
				//if (usuarioEmpleado != null)
				//{
				//	UsuarioCln.eliminar(usuarioEmpleado.id, usuario);
				//}

				return context.SaveChanges();
			}
		}

		public static Empleado obtenerUno(int id)
		{
			using (var context = new LabRestaurantEntities())
			{
				return context.Empleado.Include("Usuario").Where(x => x.id == id).FirstOrDefault();
			}
		}
		public static List<VentaDetalle> listar()
		{
			using (var context = new LabRestaurantEntities())
			{
				return context.VentaDetalle.Where(x => x.estado != -1).ToList();
			}
		}
		public static List<paVentaDetalleListar_Result> listarPa(string parametro)
		{
			using (var context = new LabRestaurantEntities())
			{
				return context.paVentaDetalleListar(parametro).ToList();
			}
		}
	}
}
