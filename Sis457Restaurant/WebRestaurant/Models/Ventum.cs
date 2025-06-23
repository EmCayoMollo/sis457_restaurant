using System;
using System.Collections.Generic;

namespace WebRestaurant.Models;

public partial class Ventum
{
    public int Id { get; set; }

    public int IdCliente { get; set; }

    public string? TipoServicio { get; set; }

    public decimal Total { get; set; }

    public decimal Efectivo { get; set; }

    public decimal Cambio { get; set; }

    public string UsuarioRegistro { get; set; } = null!;

    public DateTime FechaRegistro { get; set; }

    public short Estado { get; set; }

    public virtual Cliente IdClienteNavigation { get; set; } = null!;

    public virtual ICollection<VentaDetalle> VentaDetalles { get; set; } = new List<VentaDetalle>();
}
