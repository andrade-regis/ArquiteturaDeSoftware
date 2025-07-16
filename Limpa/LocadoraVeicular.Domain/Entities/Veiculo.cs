using System;
using System.Linq.Expressions;

namespace LocadoraVeicular.Domain.Entities;

public class Veiculo
{
    public Guid Id { get; set; }

    required
    public string Marca { get; set; }

    required
    public string Modelo { get; set; }

    public int Ano { get; set; }


    public Veiculo(string marca, string modelo, int ano)
    {
        Id = new Guid();
        Marca = marca;
        Modelo = modelo;
        Ano = ano;
    }
}
