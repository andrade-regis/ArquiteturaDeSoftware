using System;
using LocadoraVeicular.Domain.Entities;
using LocadoraVeicular.Domain.Interfaces;

namespace LocadoraVeicular.Application.UseCases;

public class GetAllVeiculos
{
    private readonly IVeiculoRepository _repository;

    public GetAllVeiculos(IVeiculoRepository repository)
    {
        _repository = repository;
    }

    public async Task<IEnumerable<Veiculo>> ExecuteAsync()
    {
        return await _repository.GetAllAsync();
    }
}
