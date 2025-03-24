using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace JAVV20250324S1.AppWebMVC.Models;

public partial class Cliente
{
    public int Id { get; set; }

    [Required(ErrorMessage = "El nombre del Cliente es obligatorio")]
    public string Nombre { get; set; } = null!;

    public string? Direccion { get; set; }

    public string? Telefono { get; set; }

    public string? Email { get; set; }
}
