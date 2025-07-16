using System;
using LocadoraVeicular.Domain.Entities;
using LocadoraVeicular.Domain.Interfaces;

namespace LocadoraVeicular.Application.UseCases;

public class GetVeiculosByAno
{
    private readonly IVeiculoRepository _repository;

    public GetVeiculosByAno(IVeiculoRepository repository)
    {
        _repository = repository;
    }

    public async Task<IEnumerable<Veiculo>> ExecuteAsync(int ano)
    {
        return await _repository.GetByAnoAsync(ano);
    }
}
