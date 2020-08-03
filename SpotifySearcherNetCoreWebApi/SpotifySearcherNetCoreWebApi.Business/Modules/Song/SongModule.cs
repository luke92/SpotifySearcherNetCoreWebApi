using System;
using System.Threading.Tasks;

namespace SpotifySearcherNetCoreWebApi.Business.Modules.Song
{
    public class SongModule : ISongModule
    {
        private readonly SpotifyWCF.ISongService _songService;

        public SongModule(SpotifyWCF.ISongService songService)
        {
            _songService = songService;
        }

        public async Task<SpotifyWCF.SongsModel> GetSongsByCategory(string category)
        {
            var songs = new SpotifyWCF.SongsModel();

            try
            {
                var request = new SpotifyWCF.GetListSongsBasedCategoryRequest
                {
                    category = category
                };

                var response = await _songService.GetListSongsBasedCategoryAsync(request);
                               
                songs = response.GetListSongsBasedCategoryResult;
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }           
            
            return songs;
        }
    }
}
