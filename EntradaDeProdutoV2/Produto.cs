using System.Globalization;

namespace Exercicio_EntradaSaida_Materia_do_Estoque
{
    class Produto
    {
        //********Atributos********
        //public string Nome;
        //public double Preco;
        //public int Quantidade;

        //padrão de nomenclatura para atributos privativos começam com "_"
        private string _nome;
        private double _preco;
        private int _quantidade;
        //****************

        public Produto()
        {
            
        }
        //O this chama o construtor sem parâmetro de entrada que possui
        //a quantidade.
        /*public Produto(string nome, double preco) : this()
        {
            Nome = nome;
            Preco = preco;
        }
        //Usando o this para chamar o construtor com nome e preco como parâmetros de entrada
        //assim não é preciso repetir as variáveis
        public Produto(string nome, double preco, int quantidade) : this (nome, preco)
        {
            Quantidade = quantidade;
        }*/

        
        //Contrutor tem o mesmo nome da classe
        //Construtores obrigam a instanciação ter dados
        public Produto(string nome, double preco, int quantidade)
        {
            //Nome = nome;
            //Preco = preco;
            //Quantidade = quantidade;

            //Alterado para as variáveis private
            _nome = nome;
            _preco = preco;
            _quantidade = quantidade;
        }

        public Produto(string nome, double preco)
        {
            //Nome = nome;
            //Preco = preco;
            //Quantidade = 0; //quantidade inicia com zero. Esta linha é opcional, pois pode ser atribuido zero na variável
            //Alterado para as variáveis private
            _nome = nome;
            _preco = preco;
            _quantidade = 0;
        }
        
        //Métodos GET e SET
        public string GetNome()
        {
            return _nome;
        }
        //método void, pois não retorna dados
        //dentro de um método SET, é possível também colocar regras de negócio
        public void SetNome(string nome)
        {   //Length é uma propriedade de STRING que retorna o tamanho do string
            if(nome != null && nome.Length > 1)
            { 
                _nome = nome;
            }
        }

        public double GetPreco()
        {
            return _preco;
        }
        public int GetQuantidade()
        {
            return _quantidade;
        }

        public double ValorTotalEmEstoque()
        {
            //return Preco * Quantidade;
            return _preco * _quantidade;
        }

        //void -> não retorna valor de saída, e sim faz uma operação
        //ela necessita de uma variável de entrada
        public void AdicionarProdutos(int quantidade)
        {
            //Quantidade com "Q" maiúsculo é da entrada do usuário que é usado na classe
            //quantidade com "q" minúsculo é a alteração da quantidade
            //Quantidade = Quantidade + quantidade;
            _quantidade = _quantidade + quantidade;
        }
        public void RemoverProdutos(int quantidade)
        {
            _quantidade = _quantidade - quantidade;
        }


        //Sobreposição        
        public override string ToString()
        {
            /*return Nome
                 + ", $ "
                 + Preco.ToString("F2", CultureInfo.InvariantCulture) //tratamento
                 + ", "
                 + Quantidade
                 + " unidades, Total: $ "
                 + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture); //chamada da função Valor Total Em Estoque*/
            return _nome
                + ", $ "
                + _preco.ToString("F2", CultureInfo.InvariantCulture) //tratamento
                + ", "
                + _quantidade
                + " unidades, Total: $ "
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture); //chamada da função Valor Total Em Estoque


        }
    }
}
