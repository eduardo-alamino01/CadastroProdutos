using System;
using System.Collections.Generic;

namespace Exercicio10_CadastroJogos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Jogo> jogos = new List<Jogo>();

            int opcao = 0;

            while (opcao != 3)
            {
                Console.WriteLine("\n===== CADASTRO DE JOGOS =====");
                Console.WriteLine("1 - Cadastrar jogo");
                Console.WriteLine("2 - Listar jogos");
                Console.WriteLine("3 - Sair");
                Console.Write("Escolha uma opção: ");

                opcao = int.Parse(Console.ReadLine());

                if (opcao == 1)
                {
                    Jogo jogo = new Jogo();

                    Console.Write("\nNome: ");
                    jogo.Nome = Console.ReadLine();

                    Console.Write("Gênero: ");
                    jogo.Genero = Console.ReadLine();

                    Console.Write("Plataforma: ");
                    jogo.Plataforma = Console.ReadLine();

                    Console.Write("Ano: ");
                    jogo.Ano = int.Parse(Console.ReadLine());

                    Console.Write("Preço: R$ ");
                    jogo.Preco = double.Parse(Console.ReadLine());

                    jogos.Add(jogo);

                    Console.WriteLine("\nJogo cadastrado com sucesso!");
                }
                else if (opcao == 2)
                {
                    if (jogos.Count == 0)
                    {
                        Console.WriteLine("\nNenhum jogo cadastrado.");
                    }
                    else
                    {
                        foreach (Jogo jogo in jogos)
                        {
                            jogo.MostrarJogo();
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