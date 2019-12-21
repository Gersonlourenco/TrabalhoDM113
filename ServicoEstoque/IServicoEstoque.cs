using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;


namespace Products
{
    // Service contract describing the operations provided by the WCF service
    [ServiceContract]//(Namespace = "http://projetoavaliativo.dm113/01", Name = "IServicoEstque")]
    public interface IServicoEstque
    {
        // Lista produtos
        [OperationContract]
        List<string> ListarProdutos();

        //inclui produtos
        [OperationContract]
        bool IncluirProduto(Produto produto);

        //remove produto
        [OperationContract]
        bool RemoverProduto(string numeroProduto);

        //consulta estoque
        [OperationContract]
        decimal ConsultarEstoque(string numeroProduto);

        //adicionar estoque
        [OperationContract]
        bool AdicionarEstoque(string numeroProduto, decimal quantidade);

        //remove estoque
        [OperationContract]
        bool RemoverEstoque(string numeroProduto, decimal quantidade);

        //ver produto
        [OperationContract]
        Produto VerProduto(string numeroProduto);
    }

    /* Service contract describing the operations provided by the WCF service
    [ServiceContract(Namespace = "http://projetoavaliativo.dm113/02", Name = "IServicoEstque")]
    public interface IServicoEstqueV2
    {        
        //adicionar estoque
        [OperationContract]
        bool AdicionarEstoque(string numeroProduto, decimal quantidade);

        //remove estoque
        [OperationContract]
        bool RemoverEstoque(string numeroProduto, decimal quantidade);

        //consulta estoque
        [OperationContract]
        decimal ConsultarEstoque(string numeroProduto);
    }*/


    // Data contract describing the details of a product passed to client applications
    [DataContract]
    public class Produto
    {
        [DataMember]
        public string NumeroProduto;
        [DataMember]
        public string NomeProduto;
        [DataMember]
        public string DescricaoProduto;
        [DataMember]
        public decimal EstoqueProduto;
    }
}

/*
namespace ServicoEstoque
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IServicoEstoque
    {

        [OperationContract]
        string GetData(int value);

        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);

        // TODO: Add your service operations here
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
*/
