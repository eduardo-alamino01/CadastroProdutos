using System;

namespace Exercicio03_CadastroFuncionarios
{
    internal class Funcionario
    {
        public string Nome;
        public int Idade;
        public string Cargo;
        public double Salario;
        public string Setor;

        public void Apresentar()
        {
            Console.WriteLine("\n===== DADOS DO FUNCIONÁRIO =====");
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Idade: {Idade} anos");
            Console.WriteLine($"Cargo: {Cargo}");
            Console.WriteLine($"Salário: R$ {Salario:F2}");
            Console.WriteLine($"Setor: {Setor}");
            Console.WriteLine($"Salário anual: R$ {CalcularSalarioAnual():F2}");
            Console.WriteLine("===============================");
        }

        public double CalcularSalarioAnual()
        {
            return Salario * 12;
        }
    }
}