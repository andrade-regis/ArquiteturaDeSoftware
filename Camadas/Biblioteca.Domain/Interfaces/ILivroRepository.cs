using System;
using Biblioteca.Domain.Models;

namespace Biblioteca.Domain.Interfaces;

public interface ILivroRepository
{
    void Add(Livro livro);

    IEnumerable<Livro> GetLivros();
}
