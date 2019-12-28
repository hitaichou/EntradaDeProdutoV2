using System.Globalization;

namespace Exercicio_EntradaSaida_Materia_do_Estoque
{
    class Produto
    {
        //Atributos
        public string Nome;
        public double Preco;
        public int Quantidade;

        public Produto()
        {
            Quantidade = 10;
        }
        //O this chama o construtor sem parâmetro de entrada que possui
        //a quantidade.
        public Produto(string nome, double preco) : this()
        {
            Nome = nome;
            Preco = preco;
        }
        //Usando o this para chamar o construtor com nome e preco como parâmetros de entrada
        //assim não é preciso repetir as variáveis
        public Produto(string nome, double preco, int quantidade) : this (nome, preco)
        {
            Quantidade = quantidade;
        }

        /*public Produto()
        {
            //consrutor vazio
        }
        
        //Contrutor tem o mesmo nome da classe
        //Construtores obrigam a instanciação ter dados
        public Produto(string nome, double preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = 0; //quantidade inicia com zero. Esta linha é opcional, pois pode ser atribuido zero na variável
        }
        */

        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }

        //void -> não retorna valor de saída, e sim faz uma operação
        //ela necessita de uma variável de entrada
        public void AdicionarProdutos(int quantidade)
        {
            //Quantidade com "Q" maiúsculo é da entrada do usuário que é usado na classe
            //quantidade com "q" minúsculo é a alteração da quantidade
            Quantidade = Quantidade + quantidade;
        }
        public void RemoverProdutos(int quantidade)
        {
            Quantidade = Quantidade - quantidade;
        }


        //Sobreposição        
        public override string ToString()
        {
            return Nome
                 + ", $ "
                 + Preco.ToString("F2", CultureInfo.InvariantCulture) //tratamento
                 + ", "
                 + Quantidade
                 + " unidades, Total: $ "
                 + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture); //chamada da função Valor Total Em Estoque
        }
    }
}
