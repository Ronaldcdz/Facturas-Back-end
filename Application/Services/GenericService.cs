using System;
using Application.Interfaces;
using AutoMapper;

namespace Application.Services;

public class GenericService<TEntity, ViewDTO, SaveEditDTO> : IGenericService<TEntity, ViewDTO, SaveEditDTO>
where TEntity : class
where ViewDTO : class
where SaveEditDTO : class
{
    private readonly IGenericRepository<TEntity> _repository;
    private readonly IMapper _mapper;

    public GenericService(IGenericRepository<TEntity> repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public virtual async Task Update(SaveEditDTO vm, int id)
    {
        TEntity entity = _mapper.Map<TEntity>(vm);
        await _repository.UpdateAsync(entity, id);
    }

    public virtual async Task<SaveEditDTO> Add(SaveEditDTO vm)
    {
        TEntity entity = _mapper.Map<TEntity>(vm);
        entity = await _repository.AddAsync(entity);

        SaveEditDTO entityVm = _mapper.Map<SaveEditDTO>(entity);
        return entityVm;
    }

    public virtual async Task Delete(int id)
    {
        var item = await _repository.GetByIdAsync(id);
        await _repository.DeleteAsync(item);
    }

    public virtual async Task<SaveEditDTO> GetById(int id)
    {
        var entity = await _repository.GetByIdAsync(id);

        SaveEditDTO vm = _mapper.Map<SaveEditDTO>(entity);
        return vm;
    }

    public virtual async Task<List<ViewDTO>> GetAllViewDTO()
    {
        var entityList = await _repository.GetAllAsync();

        return _mapper.Map<List<ViewDTO>>(entityList);
    }
}
