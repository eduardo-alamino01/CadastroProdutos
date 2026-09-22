using System;

namespace Exercicio06_CadastroClientes
{
    internal class Cliente
    {
        public string Nome;
        public int Idade;
        public string Cidade;
        public string Email;
        public string Telefone;

        public void ApresentarCliente()
        {
            Console.WriteLine("\n===== DADOS DO CLIENTE =====");
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Idade: {Idade} anos");
            Console.WriteLine($"Cidade: {Cidade}");
            Console.WriteLine($"Email: {Email}");
            Console.WriteLine($"Telefone: {Telefone}");
            Console.WriteLine("============================");
        }
    }
}