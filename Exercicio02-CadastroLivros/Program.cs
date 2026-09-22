using System;
using System.Collections.Generic;

namespace Exercicio02_CadastroLivros
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Livro> livros = new List<Livro>();

            int opcao = 0;

            while (opcao != 3)
            {
                Console.WriteLine("\n===== CADASTRO DE LIVROS =====");
                Console.WriteLine("1 - Cadastrar livro");
                Console.WriteLine("2 - Listar livros");
                Console.WriteLine("3 - Sair");
                Console.Write("Escolha uma opção: ");

                opcao = int.Parse(Console.ReadLine());

                if (opcao == 1)
                {
                    Livro livro = new Livro();

                    Console.Write("\nTítulo: ");
                    livro.Titulo = Console.ReadLine();

                    Console.Write("Autor: ");
                    livro.Autor = Console.ReadLine();

                    Console.Write("Ano: ");
                    livro.Ano = int.Parse(Console.ReadLine());

                    Console.Write("Categoria: ");
                    livro.Categoria = Console.ReadLine();

                    Console.Write("O livro está disponível? (S/N): ");
                    string resposta = Console.ReadLine();

                    if (resposta.ToUpper() == "S")
                    {
                        livro.Disponivel = true;
                    }
                    else
                    {
                        livro.Disponivel = false;
                    }

                    livros.Add(livro);

                    Console.WriteLine("\nLivro cadastrado com sucesso!");
                }
                else if (opcao == 2)
                {
                    Console.WriteLine("\n===== LIVROS CADASTRADOS =====");

                    if (livros.Count == 0)
                    {
                        Console.WriteLine("Nenhum livro cadastrado.");
                    }
                    else
                    {
                        foreach (Livro livro in livros)
                        {
                            livro.MostrarLivro();
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