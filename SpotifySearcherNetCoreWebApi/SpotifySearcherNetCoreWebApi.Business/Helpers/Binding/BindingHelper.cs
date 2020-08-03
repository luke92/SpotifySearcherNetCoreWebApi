using System.ServiceModel;

namespace SpotifySearcherNetCoreWebApi.Business.Helpers.Binding
{
    public abstract class BindingHelper
    {
        public static System.ServiceModel.Channels.Binding GetHttpsBinding()
        {
            return new BasicHttpsBinding()
            {
                MaxBufferPoolSize = int.MaxValue,
                MaxBufferSize = int.MaxValue,
                MaxReceivedMessageSize = int.MaxValue
            };

        }

        public static System.ServiceModel.Channels.Binding GetHttpBinding()
        {
            return new BasicHttpBinding()
            {
                MaxBufferPoolSize = int.MaxValue,
                MaxBufferSize = int.MaxValue,
                MaxReceivedMessageSize = int.MaxValue
            };
        }
    }
}
