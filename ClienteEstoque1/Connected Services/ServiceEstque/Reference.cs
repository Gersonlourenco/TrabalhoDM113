﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClienteEstoque1.ServiceEstque {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Produto", Namespace="http://schemas.datacontract.org/2004/07/Products")]
    [System.SerializableAttribute()]
    public partial class Produto : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescricaoProdutoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal EstoqueProdutoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NomeProdutoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NumeroProdutoField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string DescricaoProduto {
            get {
                return this.DescricaoProdutoField;
            }
            set {
                if ((object.ReferenceEquals(this.DescricaoProdutoField, value) != true)) {
                    this.DescricaoProdutoField = value;
                    this.RaisePropertyChanged("DescricaoProduto");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal EstoqueProduto {
            get {
                return this.EstoqueProdutoField;
            }
            set {
                if ((this.EstoqueProdutoField.Equals(value) != true)) {
                    this.EstoqueProdutoField = value;
                    this.RaisePropertyChanged("EstoqueProduto");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NomeProduto {
            get {
                return this.NomeProdutoField;
            }
            set {
                if ((object.ReferenceEquals(this.NomeProdutoField, value) != true)) {
                    this.NomeProdutoField = value;
                    this.RaisePropertyChanged("NomeProduto");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NumeroProduto {
            get {
                return this.NumeroProdutoField;
            }
            set {
                if ((object.ReferenceEquals(this.NumeroProdutoField, value) != true)) {
                    this.NumeroProdutoField = value;
                    this.RaisePropertyChanged("NumeroProduto");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://projetoavaliativo.dm113/02", ConfigurationName="ServiceEstque.IServicoEstque")]
    public interface IServicoEstque {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://projetoavaliativo.dm113/02/IServicoEstque/AdicionarEstoque", ReplyAction="http://projetoavaliativo.dm113/02/IServicoEstque/AdicionarEstoqueResponse")]
        bool AdicionarEstoque(string numeroProduto, decimal quantidade);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://projetoavaliativo.dm113/02/IServicoEstque/AdicionarEstoque", ReplyAction="http://projetoavaliativo.dm113/02/IServicoEstque/AdicionarEstoqueResponse")]
        System.Threading.Tasks.Task<bool> AdicionarEstoqueAsync(string numeroProduto, decimal quantidade);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://projetoavaliativo.dm113/02/IServicoEstque/RemoverEstoque", ReplyAction="http://projetoavaliativo.dm113/02/IServicoEstque/RemoverEstoqueResponse")]
        bool RemoverEstoque(string numeroProduto, decimal quantidade);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://projetoavaliativo.dm113/02/IServicoEstque/RemoverEstoque", ReplyAction="http://projetoavaliativo.dm113/02/IServicoEstque/RemoverEstoqueResponse")]
        System.Threading.Tasks.Task<bool> RemoverEstoqueAsync(string numeroProduto, decimal quantidade);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://projetoavaliativo.dm113/02/IServicoEstque/ConsultarEstoque", ReplyAction="http://projetoavaliativo.dm113/02/IServicoEstque/ConsultarEstoqueResponse")]
        decimal ConsultarEstoque(string numeroProduto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://projetoavaliativo.dm113/02/IServicoEstque/ConsultarEstoque", ReplyAction="http://projetoavaliativo.dm113/02/IServicoEstque/ConsultarEstoqueResponse")]
        System.Threading.Tasks.Task<decimal> ConsultarEstoqueAsync(string numeroProduto);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServicoEstqueChannel : ClienteEstoque1.ServiceEstque.IServicoEstque, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServicoEstqueClient : System.ServiceModel.ClientBase<ClienteEstoque1.ServiceEstque.IServicoEstque>, ClienteEstoque1.ServiceEstque.IServicoEstque {
        
        public ServicoEstqueClient() {
        }
        
        public ServicoEstqueClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServicoEstqueClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicoEstqueClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicoEstqueClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool AdicionarEstoque(string numeroProduto, decimal quantidade) {
            return base.Channel.AdicionarEstoque(numeroProduto, quantidade);
        }
        
        public System.Threading.Tasks.Task<bool> AdicionarEstoqueAsync(string numeroProduto, decimal quantidade) {
            return base.Channel.AdicionarEstoqueAsync(numeroProduto, quantidade);
        }
        
        public bool RemoverEstoque(string numeroProduto, decimal quantidade) {
            return base.Channel.RemoverEstoque(numeroProduto, quantidade);
        }
        
        public System.Threading.Tasks.Task<bool> RemoverEstoqueAsync(string numeroProduto, decimal quantidade) {
            return base.Channel.RemoverEstoqueAsync(numeroProduto, quantidade);
        }
        
        public decimal ConsultarEstoque(string numeroProduto) {
            return base.Channel.ConsultarEstoque(numeroProduto);
        }
        
        public System.Threading.Tasks.Task<decimal> ConsultarEstoqueAsync(string numeroProduto) {
            return base.Channel.ConsultarEstoqueAsync(numeroProduto);
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Name="IServicoEstque", Namespace="http://projetoavaliativo.dm113/01", ConfigurationName="ServiceEstque.IServicoEstque1")]
    public interface IServicoEstque1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://projetoavaliativo.dm113/01/IServicoEstque/ListarProdutos", ReplyAction="http://projetoavaliativo.dm113/01/IServicoEstque/ListarProdutosResponse")]
        string[] ListarProdutos();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://projetoavaliativo.dm113/01/IServicoEstque/ListarProdutos", ReplyAction="http://projetoavaliativo.dm113/01/IServicoEstque/ListarProdutosResponse")]
        System.Threading.Tasks.Task<string[]> ListarProdutosAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://projetoavaliativo.dm113/01/IServicoEstque/IncluirProduto", ReplyAction="http://projetoavaliativo.dm113/01/IServicoEstque/IncluirProdutoResponse")]
        bool IncluirProduto(ClienteEstoque1.ServiceEstque.Produto produto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://projetoavaliativo.dm113/01/IServicoEstque/IncluirProduto", ReplyAction="http://projetoavaliativo.dm113/01/IServicoEstque/IncluirProdutoResponse")]
        System.Threading.Tasks.Task<bool> IncluirProdutoAsync(ClienteEstoque1.ServiceEstque.Produto produto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://projetoavaliativo.dm113/01/IServicoEstque/RemoverProduto", ReplyAction="http://projetoavaliativo.dm113/01/IServicoEstque/RemoverProdutoResponse")]
        bool RemoverProduto(string numeroProduto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://projetoavaliativo.dm113/01/IServicoEstque/RemoverProduto", ReplyAction="http://projetoavaliativo.dm113/01/IServicoEstque/RemoverProdutoResponse")]
        System.Threading.Tasks.Task<bool> RemoverProdutoAsync(string numeroProduto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://projetoavaliativo.dm113/01/IServicoEstque/ConsultarEstoque", ReplyAction="http://projetoavaliativo.dm113/01/IServicoEstque/ConsultarEstoqueResponse")]
        decimal ConsultarEstoque(string numeroProduto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://projetoavaliativo.dm113/01/IServicoEstque/ConsultarEstoque", ReplyAction="http://projetoavaliativo.dm113/01/IServicoEstque/ConsultarEstoqueResponse")]
        System.Threading.Tasks.Task<decimal> ConsultarEstoqueAsync(string numeroProduto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://projetoavaliativo.dm113/01/IServicoEstque/AdicionarEstoque", ReplyAction="http://projetoavaliativo.dm113/01/IServicoEstque/AdicionarEstoqueResponse")]
        bool AdicionarEstoque(string numeroProduto, decimal quantidade);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://projetoavaliativo.dm113/01/IServicoEstque/AdicionarEstoque", ReplyAction="http://projetoavaliativo.dm113/01/IServicoEstque/AdicionarEstoqueResponse")]
        System.Threading.Tasks.Task<bool> AdicionarEstoqueAsync(string numeroProduto, decimal quantidade);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://projetoavaliativo.dm113/01/IServicoEstque/RemoverEstoque", ReplyAction="http://projetoavaliativo.dm113/01/IServicoEstque/RemoverEstoqueResponse")]
        bool RemoverEstoque(string numeroProduto, decimal quantidade);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://projetoavaliativo.dm113/01/IServicoEstque/RemoverEstoque", ReplyAction="http://projetoavaliativo.dm113/01/IServicoEstque/RemoverEstoqueResponse")]
        System.Threading.Tasks.Task<bool> RemoverEstoqueAsync(string numeroProduto, decimal quantidade);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://projetoavaliativo.dm113/01/IServicoEstque/VerProduto", ReplyAction="http://projetoavaliativo.dm113/01/IServicoEstque/VerProdutoResponse")]
        ClienteEstoque1.ServiceEstque.Produto VerProduto(string numeroProduto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://projetoavaliativo.dm113/01/IServicoEstque/VerProduto", ReplyAction="http://projetoavaliativo.dm113/01/IServicoEstque/VerProdutoResponse")]
        System.Threading.Tasks.Task<ClienteEstoque1.ServiceEstque.Produto> VerProdutoAsync(string numeroProduto);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServicoEstque1Channel : ClienteEstoque1.ServiceEstque.IServicoEstque1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServicoEstque1Client : System.ServiceModel.ClientBase<ClienteEstoque1.ServiceEstque.IServicoEstque1>, ClienteEstoque1.ServiceEstque.IServicoEstque1 {
        
        public ServicoEstque1Client() {
        }
        
        public ServicoEstque1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServicoEstque1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicoEstque1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicoEstque1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string[] ListarProdutos() {
            return base.Channel.ListarProdutos();
        }
        
        public System.Threading.Tasks.Task<string[]> ListarProdutosAsync() {
            return base.Channel.ListarProdutosAsync();
        }
        
        public bool IncluirProduto(ClienteEstoque1.ServiceEstque.Produto produto) {
            return base.Channel.IncluirProduto(produto);
        }
        
        public System.Threading.Tasks.Task<bool> IncluirProdutoAsync(ClienteEstoque1.ServiceEstque.Produto produto) {
            return base.Channel.IncluirProdutoAsync(produto);
        }
        
        public bool RemoverProduto(string numeroProduto) {
            return base.Channel.RemoverProduto(numeroProduto);
        }
        
        public System.Threading.Tasks.Task<bool> RemoverProdutoAsync(string numeroProduto) {
            return base.Channel.RemoverProdutoAsync(numeroProduto);
        }
        
        public decimal ConsultarEstoque(string numeroProduto) {
            return base.Channel.ConsultarEstoque(numeroProduto);
        }
        
        public System.Threading.Tasks.Task<decimal> ConsultarEstoqueAsync(string numeroProduto) {
            return base.Channel.ConsultarEstoqueAsync(numeroProduto);
        }
        
        public bool AdicionarEstoque(string numeroProduto, decimal quantidade) {
            return base.Channel.AdicionarEstoque(numeroProduto, quantidade);
        }
        
        public System.Threading.Tasks.Task<bool> AdicionarEstoqueAsync(string numeroProduto, decimal quantidade) {
            return base.Channel.AdicionarEstoqueAsync(numeroProduto, quantidade);
        }
        
        public bool RemoverEstoque(string numeroProduto, decimal quantidade) {
            return base.Channel.RemoverEstoque(numeroProduto, quantidade);
        }
        
        public System.Threading.Tasks.Task<bool> RemoverEstoqueAsync(string numeroProduto, decimal quantidade) {
            return base.Channel.RemoverEstoqueAsync(numeroProduto, quantidade);
        }
        
        public ClienteEstoque1.ServiceEstque.Produto VerProduto(string numeroProduto) {
            return base.Channel.VerProduto(numeroProduto);
        }
        
        public System.Threading.Tasks.Task<ClienteEstoque1.ServiceEstque.Produto> VerProdutoAsync(string numeroProduto) {
            return base.Channel.VerProdutoAsync(numeroProduto);
        }
    }
}
