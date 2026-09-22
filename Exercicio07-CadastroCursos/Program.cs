using System;
using System.Collections.Generic;

namespace Exercicio07_CadastroCursos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Curso> cursos = new List<Curso>();

            int opcao = 0;

            while (opcao != 3)
            {
                Console.WriteLine("\n===== CADASTRO DE CURSOS =====");
                Console.WriteLine("1 - Cadastrar curso");
                Console.WriteLine("2 - Listar cursos");
                Console.WriteLine("3 - Sair");
                Console.WriteLine("4 - Ver cursos disponíveis");
                Console.Write("Escolha uma opção: ");

                opcao = int.Parse(Console.ReadLine());

                if (opcao == 1)
                {
                    Curso curso = new Curso();

                    Console.Write("\nNome: ");
                    curso.Nome = Console.ReadLine();

                    Console.Write("Carga Horária: ");
                    curso.CargaHoraria = int.Parse(Console.ReadLine());

                    Console.Write("Professor: ");
                    curso.Professor = Console.ReadLine();

                    Console.Write("Modalidade: ");
                    curso.Modalidade = Console.ReadLine();

                    Console.Write("Quantidade de Vagas: ");
                    curso.QuantidadeVagas = int.Parse(Console.ReadLine());

                    cursos.Add(curso);

                    Console.WriteLine("\nCurso cadastrado com sucesso!");
                }
                else if (opcao == 2)
                {
                    if (cursos.Count == 0)
                    {
                        Console.WriteLine("\nNenhum curso cadastrado.");
                    }
                    else
                    {
                        foreach (Curso curso in cursos)
                        {
                            curso.MostrarCurso();
                        }
                    }
                }
                else if (opcao == 3)
                {
                    Console.WriteLine("\nPrograma encerrado.");
                }
                else if (opcao == 4)
                {
                    bool encontrou = false;

                    Console.WriteLine("\n===== CURSOS COM VAGAS =====");

                    foreach (Curso curso in cursos)
                    {
                        if (curso.QuantidadeVagas > 0)
                        {
                            curso.MostrarCurso();
                            encontrou = true;
                        }
                    }

                    if (!encontrou)
                    {
                        Console.WriteLine("Nenhum curso com vagas disponíveis.");
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