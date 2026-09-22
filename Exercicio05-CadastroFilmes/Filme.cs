using System;

namespace Exercicio05_CadastroFilmes
{
    internal class Filme
    {
        public string Titulo;
        public string Genero;
        public int Ano;
        public int Duracao;
        public double Nota;

        public void ExibirInformacoes()
        {
            Console.WriteLine("\n===== DADOS DO FILME =====");
            Console.WriteLine($"Título: {Titulo}");
            Console.WriteLine($"Gênero: {Genero}");
            Console.WriteLine($"Ano: {Ano}");
            Console.WriteLine($"Duração: {Duracao} minutos");
            Console.WriteLine($"Nota: {Nota:F1}");

            if (Nota >= 8)
            {
                Console.WriteLine("Classificação: FILME BEM AVALIADO!");
            }

            Console.WriteLine("==========================");
        }
    }
}