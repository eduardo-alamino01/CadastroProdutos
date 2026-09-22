using System;
using System.Collections.Generic;

namespace Exercicio05_CadastroFilmes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Filme> filmes = new List<Filme>();

            int opcao = 0;

            while (opcao != 3)
            {
                Console.WriteLine("\n===== CADASTRO DE FILMES =====");
                Console.WriteLine("1 - Cadastrar filme");
                Console.WriteLine("2 - Listar filmes");
                Console.WriteLine("3 - Sair");
                Console.Write("Escolha uma opção: ");

                opcao = int.Parse(Console.ReadLine());

                if (opcao == 1)
                {
                    Filme filme = new Filme();

                    Console.Write("\nTítulo: ");
                    filme.Titulo = Console.ReadLine();

                    Console.Write("Gênero: ");
                    filme.Genero = Console.ReadLine();

                    Console.Write("Ano: ");
                    filme.Ano = int.Parse(Console.ReadLine());

                    Console.Write("Duração em minutos: ");
                    filme.Duracao = int.Parse(Console.ReadLine());

                    Console.Write("Nota: ");
                    filme.Nota = double.Parse(Console.ReadLine());

                    filmes.Add(filme);

                    Console.WriteLine("\nFilme cadastrado com sucesso!");
                }
                else if (opcao == 2)
                {
                    if (filmes.Count == 0)
                    {
                        Console.WriteLine("\nNenhum filme cadastrado.");
                    }
                    else
                    {
                        foreach (Filme filme in filmes)
                        {
                            filme.ExibirInformacoes();
                        }
                    }
                }
                else if (opcao == 3)
                {
                    Console.WriteLine("\nPrograma encerrado.");
                }
                else
                {
                    Console.WriteLine("\nOpção inválida!");
                }
            }
        }
    }
}