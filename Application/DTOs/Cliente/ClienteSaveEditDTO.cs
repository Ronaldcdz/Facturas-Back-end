using System;
using System.Text.Json.Serialization;

namespace Application.DTOs.Cliente;

public class ClienteSaveEditDTO
{
    public int Id { get; set; }
    public required string Nombre { get; set; }
    public required string Rnc { get; set; }
    public string? Direccion { get; set; }
    public required int CiudadId { get; set; }
    public string? Telefono { get; set; }
    // public string? Atencion { get; set; }
    // public string? Proyecto { get; set; }
    public string? Correo { get; set; }

}
