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
    public class ServicoEstoque : IServicoEstque
    {
        public bool AdicionarEstoque(string numeroProduto, decimal quantidade)
        {
            throw new NotImplementedException();
        }

        public decimal ConsultarEstoque(string numeroProduto)
        {
            throw new NotImplementedException();
        }

        public bool IncluirProduto(Produto produto)
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }

        public bool RemoverProduto(string numeroProduto)
        {
            throw new NotImplementedException();
        }

        public Produto VerProduto(string numeroProduto)
        {
            throw new NotImplementedException();
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
