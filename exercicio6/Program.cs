using System;

class Produto
{
    // Propriedades
    public string Nome { get; set; }
    public double Preco { get; set; }
    public int Quantidade { get; set; }

    // Método para calcular o valor total em estoque
    public double ValorTotalEmEstoque()
    {
        return Preco * Quantidade;
    }
}

class Program
{
    static void Main()
    {
        // Array para armazenar os 3 produtos
        Produto[] produtos = new Produto[3];

        // Cadastro dos produtos
        for (int i = 0; i < 3; i++)
        {
            produtos[i] = new Produto();

            Console.WriteLine($"\nCadastro do Produto {i + 1}:");

            Console.Write("Nome: ");
            produtos[i].Nome = Console.ReadLine();

            Console.Write("Preço: ");
            produtos[i].Preco = double.Parse(Console.ReadLine());

            Console.Write("Quantidade: ");
            produtos[i].Quantidade = int.Parse(Console.ReadLine());
        }

        // Listagem dos produtos
        Console.WriteLine("\nLista de Produtos:");
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine($"Produto {i + 1}: {produtos[i].Nome} | Preço: {produtos[i].Preco:C} | Quantidade: {produtos[i].Quantidade} | Valor em Estoque: {produtos[i].ValorTotalEmEstoque():C}");
        }
    }
}
