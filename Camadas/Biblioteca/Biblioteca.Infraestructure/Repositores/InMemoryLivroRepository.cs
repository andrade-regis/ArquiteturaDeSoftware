using System;
using Biblioteca.Domain.Interfaces;
using Biblioteca.Domain.Models;

namespace Biblioteca.Infraestructure.Repositores;

public class InMemoryLivroRepository : ILivroRepository
{
    private readonly List<Livro> _livros = new();

    public void Add(Livro livro)
    {
        livro.Id = _livros.Count + 1;
        _livros.Add(livro);
    }

    public IEnumerable<Livro> GetLivros()
    {
        return _livros;
    }
}
