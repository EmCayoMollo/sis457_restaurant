using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebRestaurant.Models;
using WebRestaurant.Models.ViewModels;

namespace WebRestaurant.Controllers
{
	public class VentasCompletaController : Controller
	{
		private readonly FinalRestaurantContext _context;

		public VentasCompletaController(FinalRestaurantContext context)
		{
			_context = context;
		}

		// GET: VentasCompleta/CrearVentaCompleta
		public async Task<IActionResult> CrearVentaCompleta()
		{
			var clientes = await _context.Clientes.Select(c => new SelectListItem
			{
				Value = c.Id.ToString(),
				Text = c.NombreCompleto
			}).ToListAsync();

			var platillos = await _context.Platillos.Select(p => new SelectListItem
			{
				Value = p.Id.ToString(),
				Text = p.Nombre
			}).ToListAsync();

			var refrescos = await _context.Refrescos.Select(r => new SelectListItem
			{
				Value = r.Id.ToString(),
				Text = r.Nombre
			}).ToListAsync();

			var preciosPlatillos = await _context.Platillos
				.ToDictionaryAsync(p => p.Id.ToString(), p => p.Precio);

			var preciosRefrescos = await _context.Refrescos
				.ToDictionaryAsync(r => r.Id.ToString(), r => r.Precio);

			var viewModel = new VentaCreateViewModel
			{
				Clientes = clientes,
				Platillos = platillos,
				Refrescos = refrescos,
				PreciosPlatillos = preciosPlatillos,
				PreciosRefrescos = preciosRefrescos,
				Detalles = new List<DetalleVentumViewModel>()
			};

			// ¡CAMBIO AQUÍ! Especifica la ruta completa a la vista.
			return View("~/Views/Ventas/CrearVentaCompleta.cshtml", viewModel);
		}

		// POST: VentasCompleta/Create
		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Create(VentaCreateViewModel model)
		{

			if (ModelState.IsValid)
			{
				var nuevaVenta = new Ventum
				{
					IdCliente = model.IdCliente,
					TipoServicio = model.TipoServicio,
					Total = model.Total,
					Efectivo = model.Efectivo,
					Cambio = model.Cambio,
					UsuarioRegistro = User.Identity.Name,
					FechaRegistro = DateTime.Now,
					Estado = 1
				};

				_context.Venta.Add(nuevaVenta);
				await _context.SaveChangesAsync();

				foreach (var detalleModel in model.Detalles)
				{
					if ((detalleModel.IdPlatillo.HasValue || detalleModel.IdRefresco.HasValue) && detalleModel.Cantidad > 0)
					{
						var nuevoDetalle = new VentaDetalle
						{
							IdVenta = nuevaVenta.Id,
							IdPlatillo = detalleModel.IdPlatillo,
							IdRefresco = detalleModel.IdRefresco,
							Cantidad = detalleModel.Cantidad,
							TotalVentaDetalle = detalleModel.Total,
							UsuarioRegistro = User.Identity.Name,
							FechaRegistro = DateTime.Now,
							Estado = 1
						};
						_context.VentaDetalles.Add(nuevoDetalle);
					}
				}
				await _context.SaveChangesAsync();

				return RedirectToAction("Index", "Ventas");
			}

			// Si el modelo no es válido, recarga los datos para los dropdowns
			model.Clientes = await _context.Clientes.Select(c => new SelectListItem
			{
				Value = c.Id.ToString(),
				Text = c.NombreCompleto
			}).ToListAsync();

			model.Platillos = await _context.Platillos.Select(p => new SelectListItem
			{
				Value = p.Id.ToString(),
				Text = p.Nombre
			}).ToListAsync();

			model.Refrescos = await _context.Refrescos.Select(r => new SelectListItem
			{
				Value = r.Id.ToString(),
				Text = r.Nombre
			}).ToListAsync();

			model.PreciosPlatillos = await _context.Platillos
				.ToDictionaryAsync(p => p.Id.ToString(), p => p.Precio);

			model.PreciosRefrescos = await _context.Refrescos
				.ToDictionaryAsync(r => r.Id.ToString(), r => r.Precio);

			// ¡CAMBIO AQUÍ! Vuelve a la vista especificando la ruta completa.
			return View("~/Views/Ventas/CrearVentaCompleta.cshtml", model);
		}
	}
}
