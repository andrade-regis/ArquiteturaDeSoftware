using System;
using LocadoraVeicular.Domain.Entities;

namespace LocadoraVeicular.Domain.Interfaces;

public interface IVeiculoRepository
{
    Task<IEnumerable<Veiculo>> GetAllAsync();

    Task<IEnumerable<Veiculo>> GetByMarcaAsync(string Marca);

    Task<IEnumerable<Veiculo>> GetByAnoAsync(int ano);

    Task AddAsync();
}
