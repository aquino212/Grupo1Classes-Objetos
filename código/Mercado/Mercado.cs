namespace Mercado
{
    public class Produtos
    {

        //variáveis que guardam as informações do produto.
        public string Nome;
        public double Preco;
        public int Estoque;

        //recebe valores e coloca dentro dos campos da classe
        public Produtos(string n, double p, int e)
        {
            Nome = n;
            Preco = p;
            Estoque = e;
        }

        //mostra os dados do produto
        public void ExibirInfo()
        {
            Console.WriteLine($"Produto: {Nome} | Preço: R${Preco:F2} | Estoque: {Estoque}");
        }

    }

}
