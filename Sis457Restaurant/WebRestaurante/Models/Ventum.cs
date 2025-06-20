using System;
using System.Collections.Generic;

namespace WebRestaurante.Models;

public partial class Ventum
{
    public int Id { get; set; }

    public int IdPlatillo { get; set; }

    public int IdCliente { get; set; }

    public decimal PrecioUnitario { get; set; }

    public int Cantidad { get; set; }

    public decimal Total { get; set; }

    public decimal Efectivo { get; set; }

    public decimal Cambio { get; set; }

    public string UsuarioRegistro { get; set; } = null!;

    public DateTime FechaRegistro { get; set; }

    public short Estado { get; set; }

    public virtual Cliente IdClienteNavigation { get; set; } = null!;

    public virtual Platillo IdPlatilloNavigation { get; set; } = null!;
}
