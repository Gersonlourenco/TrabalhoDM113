using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using ClienteEstoque1.ServiceEstque;

namespace ClienteEstoque1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a proxy object and connect to the service 
            ServicoEstque1Client proxy = new ServicoEstque1Client();

            int i = 1;

            // 1) Adicionar um produto(por exemplo, Produto 11)
            Console.WriteLine("Test " + i++ + ": Adicionar um produto");
            Produto prod1 = new Produto();
            prod1.NomeProduto = "Produto 11";
            prod1.DescricaoProduto = "Produto 11";
            prod1.NumeroProduto = "11";
            prod1.EstoqueProduto = 210;

            Console.WriteLine("Produto incluido: {0}", proxy.IncluirProduto(prod1) ? "SIM" : "NAO");
            Console.WriteLine();
            Console.WriteLine();

            //2) Remover o produto 10
            Console.WriteLine("Test " + i++ + ": Remover o produto 11");
            Console.WriteLine("Produto Removido: {0}", proxy.RemoverProduto("11") ? "SIM" : "NAO");
            Console.WriteLine();
            Console.WriteLine();

            //3) Listar todos os produtos
            Console.WriteLine("Test " + i++ + ": Listar todos os produtos");
            foreach (String prod in proxy.ListarProdutos().ToList())
            {
                Console.WriteLine("Produto: {0}", prod);
            }
            Console.WriteLine();
            Console.WriteLine();

            //4) Verificar todas as informações do Produto 2
            Console.WriteLine("Test " + i++ + ": Verificar todas as informações do Produto 2");
            Produto prod2 = proxy.VerProduto("2000");

            Console.WriteLine("Nome Produto: {0}", prod2.NomeProduto);
            Console.WriteLine();
            Console.WriteLine("Numero Produto: {0}", prod2.NumeroProduto);
            Console.WriteLine();
            Console.WriteLine("Descricao Produto: {0}", prod2.DescricaoProduto);
            Console.WriteLine();
            Console.WriteLine("Estoque Produto: {0}", prod2.EstoqueProduto);
            Console.WriteLine();
            Console.WriteLine();

            //5) Adicionar 10 unidades para este produto
            Console.WriteLine("Test " + i++ + ": Adicionar 10 unidades para este produto");
            Console.WriteLine("Adicionado: {0}", proxy.AdicionarEstoque("2000", 10) ? "SIM" : "NAO");
            Console.WriteLine();
            Console.WriteLine();

            //6) Verificar o estoque do Produto 2
            Console.WriteLine("Test " + i++ + ": Verificar o estoque do Produto 2");
            Console.WriteLine("Estoque produto: {0}", proxy.ConsultarEstoque("2000"));
            Console.WriteLine();
            Console.WriteLine();

            //7) Verificar o estoque atual do Produto 1
            Console.WriteLine("Test " + i++ + ": Verificar o estoque atual do Produto 1");
            Console.WriteLine("Estoque produto: {0}", proxy.ConsultarEstoque("1000"));
            Console.WriteLine();
            Console.WriteLine();

            //8) Remover 20 unidades para este produto
            Console.WriteLine("Test " + i++ + ": Remover 20 unidades para este produto");
            Console.WriteLine("Removido: {0}", proxy.RemoverEstoque("1000", 20) ? "SIM" : "NAO");
            Console.WriteLine();
            Console.WriteLine();

            //9) Verificar o estoque do Produto 1 novamente
            Console.WriteLine("Test " + i++ + ": Verificar o estoque do Produto 1 novamente");
            Console.WriteLine("Estoque produto: {0}", proxy.ConsultarEstoque("1000"));
            Console.WriteLine();
            Console.WriteLine();

            //10) Verificar todas as informações do Produto 1
            Console.WriteLine("Test " + i++ + ": Verificar todas as informações do Produto 1");
            Produto prod3 = proxy.VerProduto("1000");

            Console.WriteLine("Nome Produto: {0}", prod3.NomeProduto);
            Console.WriteLine();
            Console.WriteLine("Numero Produto: {0}", prod3.NumeroProduto);
            Console.WriteLine();
            Console.WriteLine("Descricao Produto: {0}", prod3.DescricaoProduto);
            Console.WriteLine();
            Console.WriteLine("Estoque Produto: {0}", prod3.EstoqueProduto);
            Console.WriteLine();
            Console.WriteLine();

        }
    }
}
