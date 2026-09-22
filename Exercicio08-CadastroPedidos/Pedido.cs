using System;

namespace Exercicio08_CadastroPedidos
{
    internal class Pedido
    {
        public string Numero;
        public string Cliente;
        public string Produto;
        public int Quantidade;
        public double ValorUnitario;

        public double CalcularTotal()
        {
            return Quantidade * ValorUnitario;
        }

        public void MostrarPedido()
        {
            Console.WriteLine("\n===== DADOS DO PEDIDO =====");
            Console.WriteLine($"Pedido: {Numero}");
            Console.WriteLine($"Cliente: {Cliente}");
            Console.WriteLine($"Produto: {Produto}");
            Console.WriteLine($"Quantidade: {Quantidade}");
            Console.WriteLine($"Valor unitário: R$ {ValorUnitario:F2}");
            Console.WriteLine($"Total: R$ {CalcularTotal():F2}");
            Console.WriteLine("===========================");
        }
    }
}