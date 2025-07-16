using System;
using Biblioteca.Domain.Interfaces;
using Biblioteca.Domain.Models;

namespace Biblioteca.Application.Services;

public class LivroService
{
    private readonly ILivroRepository _repository;

    public LivroService(ILivroRepository repository)
    {
        _repository = repository;
    }

    public void RegistrarLivro(string título, string autor, string editora, int anoDeLançamento)
    {
        var livro = new Livro
        {
            Título = título,
            Autor = autor,
            Editora = editora,
            AnoDeLançamento = anoDeLançamento
        };

        _repository.Add(livro);
    }

    public IEnumerable<Livro> ListarLivros()
    {
        return _repository.GetLivros();
    }
}
