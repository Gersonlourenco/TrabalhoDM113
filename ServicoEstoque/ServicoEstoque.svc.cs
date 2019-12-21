using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using EstoqueEntityModel;
using System.ServiceModel.Activation;



namespace Products
{
    // WCF service that implements the service contract 
    // This implementation performs minimal error checking and exception handling 
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class ServicoEstoque : IServicoEstque, IServicoEstqueV2
    {
        public bool AdicionarEstoque(string numeroProduto, decimal quantidade)
        {
            // Connect to the ProductsModel database
            try
            {
                using (ProvedorEstoque database = new ProvedorEstoque())
                {
                    // Find the ProductID for the specified product
                    ProdutoEstoque produto = database.ProdutosEstoque.First(pi => pi.NumeroProduto == numeroProduto);

                    if (produto != null)
                    {
                        produto.EstoqueProduto += (int)quantidade;
                        database.SaveChanges();

                        return true;
                    }                    
                }
            }
            catch
            {
                // Ignore exceptions in this implementation
            }

            return false;
        }

        public decimal ConsultarEstoque(string numeroProduto)
        {
            decimal estoqueProduto = 0;
            try
            {
                using (ProvedorEstoque database = new ProvedorEstoque())
                {
                    ProdutoEstoque product = (from ProdutoEstoque in database.ProdutosEstoque select ProdutoEstoque).First();
                    estoqueProduto = product.EstoqueProduto;
                }
            }
            catch
            {
                // Ignore exceptions in this implementation
            }
            return estoqueProduto;
        }

        public bool IncluirProduto(Produto produto)
        {
            try
            {
                using (ProvedorEstoque database = new ProvedorEstoque())
                {
                    // Find the ProductID for the specified product
                    int qtdeItens = database.ProdutosEstoque.Count(pi => pi.NumeroProduto == produto.NumeroProduto);

                    if (qtdeItens == 0)
                    {
                        ProdutoEstoque produtoAux = new ProdutoEstoque();
                        produtoAux.NumeroProduto = produto.NumeroProduto;
                        produtoAux.DescricaoProduto = produto.DescricaoProduto;
                        produtoAux.NomeProduto = produto.NomeProduto;
                        produtoAux.EstoqueProduto = (int) produto.EstoqueProduto;

                        database.ProdutosEstoque.Add(produtoAux);
                        database.SaveChanges();

                        return true;
                    }
                }
            }
            catch
            {
                // Ignore exceptions in this implementation
            }

            return false;
        }

        public List<string> ListarProdutos()
        {
            // Create a list of products
            List<string> productsList = new List<string>();
            try
            {
                // Connect to the ProductsModel database
                using (ProvedorEstoque database = new ProvedorEstoque())
                {
                    // Fetch the products in the database
                    List<ProdutoEstoque> products = (from ProdutoEstoque in database.ProdutosEstoque select ProdutoEstoque).ToList();
                    foreach (ProdutoEstoque product in products)
                    {
                        productsList.Add(product.NomeProduto);
                    }
                }
            }
            catch
            {
                // Ignore exceptions in this implementation
            }
            // Return the list of products
            return productsList;
        }

        public bool RemoverEstoque(string numeroProduto, decimal quantidade)
        {
            // Connect to the ProductsModel database
            try
            {
                using (ProvedorEstoque database = new ProvedorEstoque())
                {
                    // Find the ProductID for the specified product
                    ProdutoEstoque produto = database.ProdutosEstoque.First(pi => pi.NumeroProduto == numeroProduto);

                    if (produto != null)
                    {
                        produto.EstoqueProduto -= (int)quantidade;
                        database.SaveChanges();

                        return true;
                    }
                }
            }
            catch
            {
                // Ignore exceptions in this implementation
            }

            return false;
        }

        public bool RemoverProduto(string numeroProduto)
        {
            // Connect to the ProductsModel database
            try
            {
                using (ProvedorEstoque database = new ProvedorEstoque())
                {
                    // Find the ProductID for the specified product
                    ProdutoEstoque produto = database.ProdutosEstoque.First(pi => pi.NumeroProduto == numeroProduto);

                    if (produto != null)
                    {
                        database.ProdutosEstoque.Remove(produto);
                        database.SaveChanges();

                        return true;
                    }                    
                }
            }
            catch
            {
                // Ignore exceptions in this implementation
            }

            return false;
        }

        public Produto VerProduto(string numeroProduto)
        {
            Produto estoqueProduto = new Produto();
            try
            {
                using (ProvedorEstoque database = new ProvedorEstoque())
                {
                    ProdutoEstoque product = database.ProdutosEstoque.First(pi => pi.NumeroProduto == numeroProduto);
                    if (product != null)
                    {
                        estoqueProduto.NumeroProduto = product.NumeroProduto;
                        estoqueProduto.DescricaoProduto = product.DescricaoProduto;
                        estoqueProduto.NomeProduto = product.NomeProduto;
                        estoqueProduto.EstoqueProduto = product.EstoqueProduto;
                    }
                }
            }
            catch
            {
                // Ignore exceptions in this implementation
            }

            return estoqueProduto;
        }
    }

}
/*namespace ServicoEstoque
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IServicoEstoque
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
    }
}*/
