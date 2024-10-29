using System;
using Application.DTOs.Cliente;
using Application.Entities;
using Application.Services;

namespace Application.Interfaces.Services;

public interface IClienteService : IGenericService<Cliente, ClienteViewDTO, ClienteSaveEditDTO>
{

}
