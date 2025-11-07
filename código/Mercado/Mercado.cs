namespace Mercado
{
    public class Produtos
    {
        public string Nome;
        public double Preco;
        public int Estoque;

    public Produtos(string n, double p, int e)
    {
        Nome = n;
        Preco = p;
        Estoque = e;
    }

    public void ExibirInfo()
    {
        Console.WriteLine($"Produto: {Nome} | Preço: R${Preco:F2} | Estoque: {Estoque}");
    }
    }
}