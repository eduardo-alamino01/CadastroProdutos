using System;

public class Produto
{
    public string Nome;
    public string Categoria;
    public double Preco;
    public int Quantidade;

    public void MostrarProduto()
    {
        Console.WriteLine("\n--------------------");
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Categoria: {Categoria}");
        Console.WriteLine($"Preço: R$ {Preco:F2}");
        Console.WriteLine($"Quantidade: {Quantidade}");
        Console.WriteLine($"Valor total em estoque: R$ {Preco * Quantidade:F2}");
        Console.WriteLine("--------------------");
    }
}