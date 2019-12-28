using System;
using System.Globalization;

namespace Exercicio_EntradaSaida_Materia_do_Estoque
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto();


            Console.WriteLine("Entre com os dados do produto:");
            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque: ");
            p.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine();

            //O "p" já vem formatado com o return da classe Produto
            //por este motivo não é necessário formatar na chamada abaixo.
            Console.WriteLine("Dados do produto: " + p);

            Console.WriteLine();
            Console.Write("Digite o número a ser adicionado ao estoque: ");
            int qte = int.Parse(Console.ReadLine());
            //Depois de criado a operação na Classe Produto
            //chamamos a função Adicionar Produtos e passamos a quantidad
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
