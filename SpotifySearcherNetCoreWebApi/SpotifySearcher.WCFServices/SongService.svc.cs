using SpotifySearcher.WCFServices.Modules.Song;
using SpotifySearcher.WCFServices.Modules.Song.Models;
using System.Threading.Tasks;

namespace SpotifySearcher.WCFServices
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "SongService" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione SongService.svc o SongService.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class SongService : ISongService
    {
        private readonly ISongModule _songModule;
        
        public SongService()
        {
            _songModule = new SongModule();
        }

        public async Task<SongsModel> GetListSongsBasedCategory(string category)
        {
            return await _songModule.GetListSongsBasedCategory(category);
        }
    }
}
