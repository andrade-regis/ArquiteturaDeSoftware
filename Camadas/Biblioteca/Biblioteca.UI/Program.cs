using System;
using System.Text;
using Biblioteca.Application.Services;
using Biblioteca.Infraestructure.Repositores;

namespace Biblioteca.UI;

public class Program
{
    static void Main()
    {
        var repository = new InMemoryLivroRepository();
        var livroService = new LivroService(repository);

        livroService.RegistrarLivro("O homem que habita a escuridão",
                                    "Stephen King", "DarkSide", 2019);

        livroService.RegistrarLivro("CreepShow",
                                    "Stephen King", "DarkSide", 2017);

        livroService.RegistrarLivro("Hannibal a origem do mal",
                                    "Thomas Harris", "DarkSide", 2024);

        System.Console.WriteLine("Livros na biblioteca:\n");

        StringBuilder stringBuilder = new StringBuilder();

        foreach (var livro in livroService.ListarLivros())
        {
            stringBuilder.AppendLine($"Título: {livro.Título}");
            stringBuilder.AppendLine($"Autor(a): {livro.Autor}");
            stringBuilder.AppendLine($"Editora: {livro.Editora}");
            stringBuilder.AppendLine($"Ano de Lançamento: {livro.AnoDeLançamento}");
            stringBuilder.AppendLine("-----------------------------------------------\n");
        }

        System.Console.WriteLine(stringBuilder);

        Console.ReadKey();
    }
}
