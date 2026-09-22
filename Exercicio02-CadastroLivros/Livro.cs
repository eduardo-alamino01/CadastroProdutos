using System;

namespace Exercicio02_CadastroLivros
{
    internal class Livro
    {
        public string Titulo;
        public string Autor;
        public int Ano;
        public string Categoria;
        public bool Disponivel;

        public void MostrarLivro()
        {
            Console.WriteLine("\n--------------------");
            Console.WriteLine($"Título: {Titulo}");
            Console.WriteLine($"Autor: {Autor}");
            Console.WriteLine($"Ano: {Ano}");
            Console.WriteLine($"Categoria: {Categoria}");

            if (Disponivel)
            {
                Console.WriteLine("Status: DISPONÍVEL");
            }
            else
            {
                Console.WriteLine("Status: EMPRESTADO");
            }

            Console.WriteLine("--------------------");
        }
    }
}