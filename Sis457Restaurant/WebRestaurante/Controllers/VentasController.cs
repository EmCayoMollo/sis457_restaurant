using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebRestaurante.Models;

namespace WebRestaurante.Controllers
{
	[Authorize]

	public class VentasController : Controller
    {
        private readonly FinalRestaurantContext _context;

        public VentasController(FinalRestaurantContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var ventas = _context.Venta
                .Include(v => v.IdClienteNavigation)
                .Include(v => v.IdPlatilloNavigation)
                .ToList();

            var platillos = _context.Platillos
                .Where(p => p.Estado == 1)
                .ToList();

            var clientes = _context.Clientes
                .Where(c => c.Estado == 1)
                .ToList();

            ViewBag.Platillos = platillos;
            ViewBag.Clientes = new SelectList(clientes, "Id", "NombreCompleto");

            return View(ventas);
        }

        // Modelo auxiliar para el detalle de la venta
        public class DetalleVentaViewModel
        {
            public int idPlatillo { get; set; }
            public string nombrePlatillo { get; set; }
            public int cantidad { get; set; }
            public decimal precioUnitario { get; set; }
            public decimal total { get; set; }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AgregarVentaMultiple(int IdCliente, decimal Efectivo, string DetalleJson)
        {
            if (string.IsNullOrEmpty(DetalleJson))
            {
                TempData["Error"] = "Debe agregar al menos un platillo.";
                return RedirectToAction(nameof(Index));
            }

            var detalles = JsonConvert.DeserializeObject<List<DetalleVentaViewModel>>(DetalleJson);
            if (detalles == null || detalles.Count == 0)
            {
                TempData["Error"] = "Detalle de venta inválido.";
                return RedirectToAction(nameof(Index));
            }

            decimal totalVenta = detalles.Sum(d => d.total);
            decimal cambio = Efectivo - totalVenta;

            foreach (var detalle in detalles)
            {
                var venta = new Ventum
                {
                    IdPlatillo = detalle.idPlatillo,
                    IdCliente = IdCliente,
                    PrecioUnitario = detalle.precioUnitario,
                    Cantidad = detalle.cantidad,
                    Total = detalle.total,
                    Efectivo = Efectivo,
                    Cambio = cambio,
                    UsuarioRegistro = User.Identity.Name,
                    FechaRegistro = DateTime.Now,
                    Estado = 1
                };
                _context.Add(venta);
            }
            await _context.SaveChangesAsync();

            TempData["Mensaje"] = "Venta registrada correctamente.";
            return RedirectToAction(nameof(Index));
        }

        // Acciones existentes para Create (opcional, si las usas en otra vista)
        public IActionResult Create()
        {
            ViewData["IdCliente"] = new SelectList(_context.Clientes.Where(c => c.Estado == 1), "Id", "NombreCompleto");
            ViewData["IdPlatillo"] = new SelectList(_context.Platillos.Where(p => p.Estado == 1), "Id", "Nombre");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdPlatillo,IdCliente,Cantidad,Efectivo")] Ventum ventum)
        {
            var platillo = await _context.Platillos.FindAsync(ventum.IdPlatillo);
            if (platillo == null) return View(ventum);

            ventum.PrecioUnitario = platillo.Precio;
            ventum.Total = platillo.Precio * ventum.Cantidad;
            ventum.Cambio = ventum.Efectivo - ventum.Total;
            ventum.UsuarioRegistro = "admin";
            ventum.FechaRegistro = DateTime.Now;
            ventum.Estado = 1;

            if (ModelState.IsValid)
            {
                _context.Add(ventum);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdCliente"] = new SelectList(_context.Clientes.Where(c => c.Estado == 1), "Id", "NombreCompleto", ventum.IdCliente);
            ViewData["IdPlatillo"] = new SelectList(_context.Platillos.Where(p => p.Estado == 1), "Id", "Nombre", ventum.IdPlatillo);
            return View(ventum);
        }
    }
}