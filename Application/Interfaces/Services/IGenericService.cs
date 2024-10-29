using System;

namespace Application.Interfaces;

public interface IGenericService<TEntity, ViewDTO, SaveEditDTO> 
where TEntity : class
where ViewDTO : class
where SaveEditDTO : class
{
    Task<SaveEditDTO> Add(SaveEditDTO vm);

    Task Update(SaveEditDTO entity, int id);

    Task Delete(int id);

    Task<List<ViewDTO>> GetAllViewDTO();

    Task<SaveEditDTO> GetById(int id);
}
