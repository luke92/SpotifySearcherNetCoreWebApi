using SpotifySearcher.WCFServices.Modules.Song.Models;
using System.ServiceModel;


namespace SpotifySearcher.WCFServices
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "ISongService" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface ISongService
    {
        [OperationContract]
        SongsModel GetListSongsBasedCategory(string category);
    }
}
