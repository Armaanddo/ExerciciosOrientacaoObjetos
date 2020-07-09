using System;
using System.Collections.Generic;
using System.Text;

namespace ControleBasicoDeEstoque
{
    class Produto
    {
        public string Nome;
        public double Preco=0;
        public int QtdeEstoque;

       /* public void MostrarDadosDoProduto()
        {
            Console.WriteLine("Nome do produto: "+Nome);
            Console.WriteLine("Preço:"+ Preco);
            Console.WriteLine("Quantidade em estoque: "+QtdeEstoque);
        }
       */
        public void AdicionarProdutos(int Qtde)
        {
            QtdeEstoque += Qtde;
        }
        public void RemoverProdutos(int Qtde)
        {
            QtdeEstoque -= Qtde;
        }

        public double ValorTotalEmEstoque()
        {
            return QtdeEstoque*Preco;
        }
    }
}
