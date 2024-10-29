using System;
using Application.DTOs.Cliente;
using Application.Entities;
using Application.Interfaces;
using Application.Interfaces.Services;
using AutoMapper;

namespace Application.Services;

public class ClienteService : GenericService<Cliente, ClienteViewDTO, ClienteSaveEditDTO>, IClienteService
{
    private readonly IClienteRepository _clienteRepository;
    private readonly IMapper _mapper;
    public ClienteService(IClienteRepository clienteRepository, IMapper mapper) : base (clienteRepository, mapper)
    {
        _clienteRepository = clienteRepository;
        _mapper = mapper;
    }
}
