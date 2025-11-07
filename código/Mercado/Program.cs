using Mercado; //permite usar a classe Produtos criada no outro arquivo

Console.Clear();

//cria objetos para a classe mercado

Produtos Abacaxi = new Produtos("Abacaxi", 4, 33); 

Produtos Melão = new Produtos("Melão", 5, 54);

Produtos Banana = new Produtos("Banana", 3, 67);

//chama o método que imprime as informações do produto no console

Abacaxi.ExibirInfo();

Melão.ExibirInfo();

Banana.ExibirInfo();