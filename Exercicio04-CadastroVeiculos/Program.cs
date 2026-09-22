using System;
using System.Collections.Generic;

namespace Exercicio04_CadastroVeiculos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Veiculo> veiculos = new List<Veiculo>();

            int opcao = 0;

            while (opcao != 3)
            {
                Console.WriteLine("\n===== CADASTRO DE VEÍCULOS =====");
                Console.WriteLine("1 - Cadastrar veículo");
                Console.WriteLine("2 - Listar veículos");
                Console.WriteLine("3 - Sair");
                Console.WriteLine("4 - Pesquisar veículo");
                Console.Write("Escolha uma opção: ");

                opcao = int.Parse(Console.ReadLine());

                if (opcao == 1)
                {
                    Veiculo veiculo = new Veiculo();

                    Console.Write("\nMarca: ");
                    veiculo.Marca = Console.ReadLine();

                    Console.Write("Modelo: ");
                    veiculo.Modelo = Console.ReadLine();

                    Console.Write("Ano: ");
                    veiculo.Ano = int.Parse(Console.ReadLine());

                    Console.Write("Cor: ");
                    veiculo.Cor = Console.ReadLine();

                    Console.Write("Placa: ");
                    veiculo.Placa = Console.ReadLine();

                    veiculos.Add(veiculo);

                    Console.WriteLine("\nVeículo cadastrado com sucesso!");
                }
                else if (opcao == 2)
                {
                    if (veiculos.Count == 0)
                    {
                        Console.WriteLine("\nNenhum veículo cadastrado.");
                    }
                    else
                    {
                        foreach (Veiculo veiculo in veiculos)
                        {
                            veiculo.MostrarVeiculo();
                        }
                    }
                }
                else if (opcao == 4)
                {
                    Console.Write("\nDigite a marca ou modelo: ");
                    string pesquisa = Console.ReadLine().ToLower();

                    bool encontrou = false;

                    foreach (Veiculo veiculo in veiculos)
                    {
                        if (veiculo.Marca.ToLower().Contains(pesquisa) ||
                            veiculo.Modelo.ToLower().Contains(pesquisa))
                        {
                            veiculo.MostrarVeiculo();
                            encontrou = true;
                        }
                    }

                    if (!encontrou)
                    {
                        Console.WriteLine("\nNenhum veículo encontrado.");
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