using System;

namespace Biblioteca.Domain.Models;

public class Livro
{
    public int Id { get; set; }

    required
    public string Título { get; set; }

    required
    public string Autor { get; set; }

    required
    public string Editora { get; set; }

    public int AnoDeLançamento;
}
