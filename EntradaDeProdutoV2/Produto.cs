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
        public double Preco { get; private set; } //Auto-Propertie: com esta forma, não é preciso criar método no código abaixo
        public int Quantidade { get; private set; } //Quando há lógica customizada, não é possível criar Auto-Propertie.       
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
            Preco    = preco;
            Quantidade = quantidade;
        }

        public Produto(string nome, double preco)
        {
            //Nome = nome;
            //Preco = preco;
            //Quantidade = 0; //quantidade inicia com zero. Esta linha é opcional, pois pode ser atribuido zero na variável
            //Alterado para as variáveis private
            _nome = nome;
            Preco = preco;
            Quantidade = 0;
        }
        //As Properties substitui o GET e SET fazendo tudo dentro de um mesmo método.
        public string Nome
        {
            get { return _nome; }
            //O parâmetro de entrada "nome" está sendo referenciado por "value".
            set {
                  if (value != null && value.Length > 1)
                  {
                    _nome = value;
                  }
            }
        }        

       

        public double ValorTotalEmEstoque()
        {
            //return Preco * Quantidade;
            return Preco * Quantidade;
        }

        //void -> não retorna valor de saída, e sim faz uma operação
        //ela necessita de uma variável de entrada
        public void AdicionarProdutos(int quantidade)
        {
            //Quantidade com "Q" maiúsculo é da entrada do usuário que é usado na classe
            //quantidade com "q" minúsculo é a alteração da quantidade
            //Quantidade = Quantidade + quantidade;
            Quantidade = Quantidade + quantidade;
        }
        public void RemoverProdutos(int quantidade)
        {
            Quantidade = Quantidade - quantidade;
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
                + Preco.ToString("F2", CultureInfo.InvariantCulture) //tratamento
                + ", "
                + Quantidade
                + " unidades, Total: $ "
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture); //chamada da função Valor Total Em Estoque


        }
    }
}
