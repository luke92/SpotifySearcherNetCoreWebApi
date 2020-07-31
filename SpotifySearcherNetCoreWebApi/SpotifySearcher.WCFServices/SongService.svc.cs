using SpotifySearcher.WCFServices.Modules.Song.Models;

namespace SpotifySearcher.WCFServices
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "SongService" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione SongService.svc o SongService.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class SongService : ISongService
    {
        public SongsModel GetListSongsBasedSongTitle(string SongTitle)
        {
            return new SongsModel();
        }

        public SongModel GetSong(string SongId)
        {
            return new SongModel();
        }

        public SongsModel GetListSongsBasedCategory(string category)
        {
            return new SongsModel();
        }
    }
}
