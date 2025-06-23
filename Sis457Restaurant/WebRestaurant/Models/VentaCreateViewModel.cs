using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations; // Para validaciones
using WebRestaurant.Models; // Para tus modelos de entidad como Ventum, VentaDetalle, si los usas aquí

namespace WebRestaurant.Models.ViewModels
{
	// ViewModel principal para la creación de ventas
	public class VentaCreateViewModel
	{
		// Propiedades del encabezado de la venta (similares a Ventum)
		public int Id { get; set; } // Opcional, pero útil si se pasa un ID existente por alguna razón

		[Required(ErrorMessage = "El cliente es obligatorio.")]
		[Display(Name = "Cliente")]
		public int IdCliente { get; set; }

		[Required(ErrorMessage = "El tipo de servicio es obligatorio.")]
		[StringLength(50, ErrorMessage = "El tipo de servicio no puede exceder los 50 caracteres.")]
		[Display(Name = "Tipo de Servicio")]
		public string TipoServicio { get; set; }

		[DisplayFormat(DataFormatString = "{0:C}")] // Formato de moneda (currency)
		[Range(0.00, double.MaxValue, ErrorMessage = "El total debe ser un valor válido.")] // Permitir 0 temporalmente
		public decimal Total { get; set; }

		[Required(ErrorMessage = "El efectivo recibido es obligatorio.")]
		[Range(0.00, double.MaxValue, ErrorMessage = "El efectivo debe ser un valor válido.")]
		[Display(Name = "Efectivo Recibido")]
		public decimal Efectivo { get; set; }

		[DisplayFormat(DataFormatString = "{0:C}")]
		public decimal Cambio { get; set; }

		// Propiedades para las listas desplegables (usadas por la vista)
		public IEnumerable<SelectListItem> Clientes { get; set; }
		public IEnumerable<SelectListItem> Platillos { get; set; }
		public IEnumerable<SelectListItem> Refrescos { get; set; }

		// Diccionarios para los precios (usados por JavaScript en la vista)
		public Dictionary<string, decimal> PreciosPlatillos { get; set; }
		public Dictionary<string, decimal> PreciosRefrescos { get; set; }

		// Lista para los detalles de la venta (platillos/refrescos individuales)
		// Esta es la propiedad que el controlador está intentando inicializar
		public List<DetalleVentumViewModel> Detalles { get; set; }
	}

	// ViewModel para cada ítem de detalle de la venta.
	// Es una CLASE PÚBLICA SEPARADA en el mismo namespace.
	public class DetalleVentumViewModel
	{
		public int? IdPlatillo { get; set; } // Puede ser nulo si solo se selecciona un refresco
		public int? IdRefresco { get; set; } // Puede ser nulo si solo se selecciona un platillo

		[Required(ErrorMessage = "La cantidad es obligatoria para cada ítem.")]
		[Range(1, int.MaxValue, ErrorMessage = "La cantidad debe ser al menos 1.")]
		public int Cantidad { get; set; }

		[DisplayFormat(DataFormatString = "{0:C}")]
		[Range(0.00, double.MaxValue, ErrorMessage = "El precio unitario debe ser un valor válido.")]
		public decimal PrecioUnitario { get; set; }

		[DisplayFormat(DataFormatString = "{0:C}")]
		[Range(0.00, double.MaxValue, ErrorMessage = "El total del ítem debe ser un valor válido.")]
		public decimal Total { get; set; }
	}
}
