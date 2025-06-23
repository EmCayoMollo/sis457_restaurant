using System;
using System.Collections.Generic;

namespace WebRestaurant.Models;

public partial class VentaDetalle
{
    public int Id { get; set; }

    public int IdVenta { get; set; }

    public int? IdPlatillo { get; set; }

    public int? IdRefresco { get; set; }

    public int Cantidad { get; set; }

    public decimal TotalVentaDetalle { get; set; }

    public string UsuarioRegistro { get; set; } = null!;

    public DateTime FechaRegistro { get; set; }

    public short Estado { get; set; }

    public virtual Platillo? IdPlatilloNavigation { get; set; }

    public virtual Refresco? IdRefrescoNavigation { get; set; }

    public virtual Ventum IdVentaNavigation { get; set; } = null!;
}
