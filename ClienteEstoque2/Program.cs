using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using ClienteEstoque2.ServicoEstque2;

namespace ClienteEstoque2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a proxy object and connect to the service 
            ServicoEstqueClient proxy = new ServicoEstqueClient();

            int i = 1;

            //1) Verificar o estoque atual do Produto 1
            Console.WriteLine("Test " + i++ + ": Verificar o estoque atual do Produto 1");
            Console.WriteLine("Estoque produto: {0}", proxy.ConsultarEstoque("1000"));
            Console.WriteLine();
            Console.WriteLine();

            //2) Adicionar 20 unidades para este produto
            Console.WriteLine("Test " + i++ + ": Adiconar 20 unidades para este produto");
            Console.WriteLine("Adicionado: {0}", proxy.AdicionarEstoque("1000", 20) ? "SIM" : "NAO");
            Console.WriteLine();
            Console.WriteLine();

            //3) Verificar o estoque do Produto 1 novamente
            Console.WriteLine("Test " + i++ + ": Verificar o estoque do Produto 1 novamente");
            Console.WriteLine("Estoque produto: {0}", proxy.ConsultarEstoque("1000"));
            Console.WriteLine();
            Console.WriteLine();

            //4) Verificar o estoque atual do Produto 5
            Console.WriteLine("Test " + i++ + ": Verificar o estoque atual do Produto 1");
            Console.WriteLine("Estoque produto: {0}", proxy.ConsultarEstoque("4000"));
            Console.WriteLine();
            Console.WriteLine();

            //5) Remover 10 unidades para este produto
            Console.WriteLine("Test " + i++ + ": Remover 10 unidades para este produto");
            Console.WriteLine("Removido: {0}", proxy.RemoverEstoque("4000", 20) ? "SIM" : "NAO");
            Console.WriteLine();
            Console.WriteLine();

            //6) Verificar o estoque do Produto 5 novamente
            Console.WriteLine("Test " + i++ + ": Verificar o estoque atual do Produto 1");
            Console.WriteLine("Estoque produto: {0}", proxy.ConsultarEstoque("4000"));
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
