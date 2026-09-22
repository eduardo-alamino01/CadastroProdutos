using System;
using System.Collections.Generic;

namespace Exercicio06_CadastroClientes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Cliente> clientes = new List<Cliente>();

            int opcao = 0;

            while (opcao != 4)
            {
                Console.WriteLine("\n===== CADASTRO DE CLIENTES =====");
                Console.WriteLine("1 - Cadastrar cliente");
                Console.WriteLine("2 - Listar clientes");
                Console.WriteLine("3 - Pesquisar cliente");
                Console.WriteLine("4 - Sair");
                Console.Write("Escolha uma opção: ");

                opcao = int.Parse(Console.ReadLine());

                if (opcao == 1)
                {
                    Cliente cliente = new Cliente();

                    Console.Write("\nNome: ");
                    cliente.Nome = Console.ReadLine();

                    Console.Write("Idade: ");
                    cliente.Idade = int.Parse(Console.ReadLine());

                    Console.Write("Cidade: ");
                    cliente.Cidade = Console.ReadLine();

                    Console.Write("Email: ");
                    cliente.Email = Console.ReadLine();

                    Console.Write("Telefone: ");
                    cliente.Telefone = Console.ReadLine();

                    clientes.Add(cliente);

                    Console.WriteLine("\nCliente cadastrado com sucesso!");
                }
                else if (opcao == 2)
                {
                    if (clientes.Count == 0)
                    {
                        Console.WriteLine("\nNenhum cliente cadastrado.");
                    }
                    else
                    {
                        foreach (Cliente cliente in clientes)
                        {
                            cliente.ApresentarCliente();
                        }
                    }
                }
                else if (opcao == 3)
                {
                    Console.Write("\nDigite o nome do cliente: ");
                    string pesquisa = Console.ReadLine().ToLower();

                    bool encontrou = false;

                    foreach (Cliente cliente in clientes)
                    {
                        if (cliente.Nome.ToLower().Contains(pesquisa))
                        {
                            cliente.ApresentarCliente();
                            encontrou = true;
                        }
                    }

                    if (!encontrou)
                    {
                        Console.WriteLine("\nCliente não encontrado.");
                    }
                }
                else if (opcao == 4)
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