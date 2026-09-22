using System;

namespace Exercicio07_CadastroCursos
{
    internal class Curso
    {
        public string Nome;
        public int CargaHoraria;
        public string Professor;
        public string Modalidade;
        public int QuantidadeVagas;

        public void MostrarCurso()
        {
            Console.WriteLine("\n===== DADOS DO CURSO =====");
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Carga Horária: {CargaHoraria} horas");
            Console.WriteLine($"Professor: {Professor}");
            Console.WriteLine($"Modalidade: {Modalidade}");
            Console.WriteLine($"Quantidade de Vagas: {QuantidadeVagas}");
            Console.WriteLine("==========================");
        }
    }
}