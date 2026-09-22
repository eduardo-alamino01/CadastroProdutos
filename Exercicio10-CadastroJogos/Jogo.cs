using System;

namespace Exercicio10_CadastroJogos
{
    internal class Jogo
    {
        public string Nome;
        public string Genero;
        public string Plataforma;
        public int Ano;
        public double Preco;

        public void MostrarJogo()
        {
            Console.WriteLine("\n===== DADOS DO JOGO =====");
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Gênero: {Genero}");
            Console.WriteLine($"Plataforma: {Plataforma}");
            Console.WriteLine($"Ano: {Ano}");
            Console.WriteLine($"Preço: R$ {Preco:F2}");
            Console.WriteLine("=========================");
        }
    }
}