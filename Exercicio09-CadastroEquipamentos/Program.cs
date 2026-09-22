using System;
using System.Collections.Generic;

namespace Exercicio09_CadastroEquipamentos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Equipamento> equipamentos = new List<Equipamento>();

            int opcao = 0;

            while (opcao != 4)
            {
                Console.WriteLine("\n===== CADASTRO DE EQUIPAMENTOS =====");
                Console.WriteLine("1 - Cadastrar equipamento");
                Console.WriteLine("2 - Listar equipamentos");
                Console.WriteLine("3 - Pesquisar equipamento");
                Console.WriteLine("4 - Sair");
                Console.WriteLine("5 - Equipamentos em manutenção");
                Console.Write("Escolha uma opção: ");

                opcao = int.Parse(Console.ReadLine());

                if (opcao == 1)
                {
                    Equipamento equipamento = new Equipamento();

                    Console.Write("\nPatrimônio: ");
                    equipamento.Patrimonio = Console.ReadLine();

                    Console.Write("Tipo: ");
                    equipamento.Tipo = Console.ReadLine();

                    Console.Write("Marca: ");
                    equipamento.Marca = Console.ReadLine();

                    Console.Write("Modelo: ");
                    equipamento.Modelo = Console.ReadLine();

                    Console.Write("Número de Série: ");
                    equipamento.NumeroSerie = Console.ReadLine();

                    Console.Write("Status: ");
                    equipamento.Status = Console.ReadLine();

                    equipamentos.Add(equipamento);

                    Console.WriteLine("\nEquipamento cadastrado com sucesso!");
                }
                else if (opcao == 2)
                {
                    if (equipamentos.Count == 0)
                    {
                        Console.WriteLine("\nNenhum equipamento cadastrado.");
                    }
                    else
                    {
                        foreach (Equipamento equipamento in equipamentos)
                        {
                            equipamento.MostrarEquipamento();
                        }
                    }
                }
                else if (opcao == 3)
                {
                    Console.Write("\nDigite o patrimônio ou modelo: ");
                    string pesquisa = Console.ReadLine().ToLower();

                    bool encontrou = false;

                    foreach (Equipamento equipamento in equipamentos)
                    {
                        if (equipamento.Patrimonio.ToLower().Contains(pesquisa) ||
                            equipamento.Modelo.ToLower().Contains(pesquisa))
                        {
                            equipamento.MostrarEquipamento();
                            encontrou = true;
                        }
                    }

                    if (!encontrou)
                    {
                        Console.WriteLine("\nEquipamento não encontrado.");
                    }
                }
                else if (opcao == 4)
                {
                    Console.WriteLine("\nPrograma encerrado.");
                }
                else if (opcao == 5)
                {
                    bool encontrou = false;

                    Console.WriteLine("\n===== EQUIPAMENTOS EM MANUTENÇÃO =====");

                    foreach (Equipamento equipamento in equipamentos)
                    {
                        if (equipamento.Status.ToLower() == "manutenção")
                        {
                            equipamento.MostrarEquipamento();
                            encontrou = true;
                        }
                    }

                    if (!encontrou)
                    {
                        Console.WriteLine("\nNenhum equipamento em manutenção.");
                    }
                }
                else
                {
                    Console.WriteLine("\nOpção inválida!");
                }
            }
        }
    }
}