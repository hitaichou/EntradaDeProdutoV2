using System.Globalization;

namespace Exercicio_EntradaSaida_Materia_do_Estoque
{
    class Produto
    {
        //Atributos
        public string Nome;
        public double Preco;
        public int Quantidade;

        //Contrutor tem o mesmo nome da classe
        //Construtores obrigam a instanciação ter dados
        public Produto(string nome, double preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }


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
