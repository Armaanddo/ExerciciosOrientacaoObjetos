using System;

namespace ControleBasicoDeEstoque
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto();
            int qtde=0;
            Console.WriteLine("Entre com os dados do produto: ");
            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            p.Preco = double.Parse(Console.ReadLine());
            Console.Write("Quantidade no estoque: ");
            p.AdicionarProdutos(int.Parse(Console.ReadLine()));

            Console.WriteLine("Dados do produto: " + p.Nome + ", $ " + p.Preco + ", " + p.QtdeEstoque + " unidades, Total: $ " +p.ValorTotalEmEstoque());

            Console.WriteLine("Digite o numero de produtos a ser adicionado ao estoque: ");
            qtde = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qtde);

            Console.WriteLine("Dados atualizados: " + p.Nome + ", $ " + p.Preco + ", " + p.QtdeEstoque + " unidades, Total: $ " + p.ValorTotalEmEstoque());


            Console.WriteLine("Digite o numero de produtos a ser removidos do estoque: ");
            p.RemoverProdutos(int.Parse(Console.ReadLine()));
            Console.WriteLine("Dados atualizados: " + p.Nome + ", $ " + p.Preco + ", " + p.QtdeEstoque + " unidades, Total: $ " + p.ValorTotalEmEstoque());






        }
    }
}
