using System;

namespace Exercicio03_CadastroFuncionarios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Funcionario funcionario = new Funcionario();

            Console.WriteLine("===== CADASTRO DE FUNCIONÁRIO =====");

            Console.Write("\nNome: ");
            funcionario.Nome = Console.ReadLine();

            Console.Write("Idade: ");
            funcionario.Idade = int.Parse(Console.ReadLine());

            Console.Write("Cargo: ");
            funcionario.Cargo = Console.ReadLine();

            Console.Write("Salário: R$ ");
            funcionario.Salario = double.Parse(Console.ReadLine());

            Console.Write("Setor: ");
            funcionario.Setor = Console.ReadLine();

            funcionario.Apresentar();

            Console.WriteLine("\nPressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}