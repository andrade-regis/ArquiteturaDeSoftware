using System;
using LocadoraVeicular.Domain.Entities;
using LocadoraVeicular.Domain.Interfaces;

namespace LocadoraVeicular.Application.UseCases;

public class GetVeiculosByMarca
{
    private readonly IVeiculoRepository _repository;

    public GetVeiculosByMarca(IVeiculoRepository repository)
    {
        _repository = repository;
    }

    public async Task<IEnumerable<Veiculo>> ExecuteAsync(string marca)
    {
        return await _repository.GetByMarcaAsync(marca);
    }
}
