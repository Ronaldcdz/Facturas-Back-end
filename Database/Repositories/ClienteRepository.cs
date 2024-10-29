using System;
using Application.Entities;
using Application.Interfaces;
using Database.Context;

namespace Database.Repositories;

public class ClienteRepository : GenericRepository<Cliente>, IClienteRepository
{
    private readonly ApplicationContext _dbContext;
        public ClienteRepository(ApplicationContext context) : base(context)
        {
            _dbContext = context;
        }
}
