using System;
using System.Collections.Generic;

namespace Exercicio08_CadastroPedidos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Pedido> pedidos = new List<Pedido>();
            int opcao = 0;

            while (opcao != 3)
            {
                Console.WriteLine("\n===== CADASTRO DE PEDIDOS =====");
                Console.WriteLine("1 - Cadastrar pedido");
                Console.WriteLine("2 - Listar pedidos");
                Console.WriteLine("3 - Sair");
                Console.Write("Escolha uma opção: ");

                opcao = int.Parse(Console.ReadLine());

                if (opcao == 1)
                {
                    Pedido pedido = new Pedido();

                    Console.Write("\nNúmero do pedido: ");
                    pedido.Numero = Console.ReadLine();

                    Console.Write("Cliente: ");
                    pedido.Cliente = Console.ReadLine();

                    Console.Write("Produto: ");
                    pedido.Produto = Console.ReadLine();

                    Console.Write("Quantidade: ");
                    pedido.Quantidade = int.Parse(Console.ReadLine());

                    Console.Write("Valor unitário: R$ ");
                    pedido.ValorUnitario = double.Parse(Console.ReadLine());

                    pedidos.Add(pedido);

                    Console.WriteLine("\nPedido cadastrado com sucesso!");
                }
                else if (opcao == 2)
                {
                    if (pedidos.Count == 0)
                    {
                        Console.WriteLine("\nNenhum pedido cadastrado.");
                    }
                    else
                    {
                        foreach (Pedido pedido in pedidos)
                        {
                            pedido.MostrarPedido();
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