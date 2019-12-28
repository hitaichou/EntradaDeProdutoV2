using System;
using System.Globalization;

namespace Exercicio_EntradaSaida_Materia_do_Estoque
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Entre com os dados do produto:");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            

            //Instanciação do objeto passando os valores não nulos
            Produto p = new Produto(nome, preco);

            //Instanciação sem padrâmetros
            Produto p2 = new Produto();

            //Outra forma de instanciar
            Produto p3 = new Produto
            {
              Nome = "TV",
              Preco = 500.00,
              Quantidade = 20
            };

            Console.WriteLine();

            //O "p" já vem formatado com o return da classe Produto
            //por este motivo não é necessário formatar na chamada abaixo.
            Console.WriteLine("Dados do produto: " + p);

            Console.WriteLine();
            Console.Write("Digite o número a ser adicionado ao estoque: ");
            int qte = int.Parse(Console.ReadLine());
            //Depois de criado a operação na Classe Produto
            //chamamos a função Adicionar Produtos e passamos a quantidade
            //que o usuário inputou no programa
            p.AdicionarProdutos(qte);

            Console.WriteLine();

            Console.WriteLine("Dados atualizados: " + p);

            Console.WriteLine();
            Console.Write("Digite o número a ser removido do estoque: ");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qte);

            Console.WriteLine();

            Console.WriteLine("Dados atualizados: " + p);
        }
    }
}
