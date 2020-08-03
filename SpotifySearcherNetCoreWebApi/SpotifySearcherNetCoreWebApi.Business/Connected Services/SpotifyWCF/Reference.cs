//------------------------------------------------------------------------------
// <generado automáticamente>
//     Este código fue generado por una herramienta.
//     //
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </generado automáticamente>
//------------------------------------------------------------------------------

namespace SpotifyWCF
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="SongsModel", Namespace="http://schemas.datacontract.org/2004/07/SpotifySearcher.WCFServices.Modules.Song." +
        "Models")]
    public partial class SongsModel : object
    {
        
        private SpotifyWCF.SongReducedModel[] SongsField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public SpotifyWCF.SongReducedModel[] Songs
        {
            get
            {
                return this.SongsField;
            }
            set
            {
                this.SongsField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="SongReducedModel", Namespace="http://schemas.datacontract.org/2004/07/SpotifySearcher.WCFServices.Modules.Song." +
        "Models")]
    public partial class SongReducedModel : object
    {
        
        private string SongIdField;
        
        private string SongTitleField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string SongId
        {
            get
            {
                return this.SongIdField;
            }
            set
            {
                this.SongIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string SongTitle
        {
            get
            {
                return this.SongTitleField;
            }
            set
            {
                this.SongTitleField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="SpotifyWCF.ISongService")]
    public interface ISongService
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISongService/GetListSongsBasedCategory", ReplyAction="http://tempuri.org/ISongService/GetListSongsBasedCategoryResponse")]
        System.Threading.Tasks.Task<SpotifyWCF.GetListSongsBasedCategoryResponse> GetListSongsBasedCategoryAsync(SpotifyWCF.GetListSongsBasedCategoryRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetListSongsBasedCategory", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class GetListSongsBasedCategoryRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public string category;
        
        public GetListSongsBasedCategoryRequest()
        {
        }
        
        public GetListSongsBasedCategoryRequest(string category)
        {
            this.category = category;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetListSongsBasedCategoryResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class GetListSongsBasedCategoryResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public SpotifyWCF.SongsModel GetListSongsBasedCategoryResult;
        
        public GetListSongsBasedCategoryResponse()
        {
        }
        
        public GetListSongsBasedCategoryResponse(SpotifyWCF.SongsModel GetListSongsBasedCategoryResult)
        {
            this.GetListSongsBasedCategoryResult = GetListSongsBasedCategoryResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    public interface ISongServiceChannel : SpotifyWCF.ISongService, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    public partial class SongServiceClient : System.ServiceModel.ClientBase<SpotifyWCF.ISongService>, SpotifyWCF.ISongService
    {
        
    /// <summary>
    /// Implemente este método parcial para configurar el punto de conexión de servicio.
    /// </summary>
    /// <param name="serviceEndpoint">El punto de conexión para configurar</param>
    /// <param name="clientCredentials">Credenciales de cliente</param>
    static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public SongServiceClient() : 
                base(SongServiceClient.GetDefaultBinding(), SongServiceClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.BasicHttpBinding_ISongService.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public SongServiceClient(EndpointConfiguration endpointConfiguration) : 
                base(SongServiceClient.GetBindingForEndpoint(endpointConfiguration), SongServiceClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public SongServiceClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(SongServiceClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public SongServiceClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(SongServiceClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public SongServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public System.Threading.Tasks.Task<SpotifyWCF.GetListSongsBasedCategoryResponse> GetListSongsBasedCategoryAsync(SpotifyWCF.GetListSongsBasedCategoryRequest request)
        {
            return base.Channel.GetListSongsBasedCategoryAsync(request);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual System.Threading.Tasks.Task CloseAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_ISongService))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("No se pudo encontrar un punto de conexión con el nombre \"{0}\".", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_ISongService))
            {
                return new System.ServiceModel.EndpointAddress("http://localhost/SpotifySearcher.WCFServices/SongService.svc");
            }
            throw new System.InvalidOperationException(string.Format("No se pudo encontrar un punto de conexión con el nombre \"{0}\".", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return SongServiceClient.GetBindingForEndpoint(EndpointConfiguration.BasicHttpBinding_ISongService);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return SongServiceClient.GetEndpointAddress(EndpointConfiguration.BasicHttpBinding_ISongService);
        }
        
        public enum EndpointConfiguration
        {
            
            BasicHttpBinding_ISongService,
        }
    }
}
