using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Newtonsoft.Json;
using SpotifySearcher.WCFServices.Modules.Authentication;
using SpotifySearcher.WCFServices.Modules.Category;
using SpotifySearcher.WCFServices.Modules.Song.Models;

namespace SpotifySearcher.WCFServices.Modules.Song
{
    public class SongModule : ISongModule
    {
        private readonly ICategoryModule _categoryModule;
        private readonly IAuthenticationModule _authenticationModule;

        public SongModule()
        {
            _categoryModule = new CategoryModule();
            _authenticationModule = new AuthenticationModule();
        }

        public async Task<SongsModel> GetListSongsBasedCategory(string category)
        {
            var list = new SongsModel();
            string url = "/v1/playlists/{0}/tracks";
            var playLists = await _categoryModule.GetPlayLists(category);
            var httpClient = await _authenticationModule.GetHttpClient();

            foreach (var playlist in playLists)
            {
                string urlFormatted = String.Format(url, playlist.Id);
                var response = await httpClient.GetAsync(urlFormatted);

                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    var tracks = JsonConvert.DeserializeObject<TracksModel>(json);
                    foreach(var track in tracks.Items)
                    {
                        list.Songs.Add(new SongReducedModel
                        {
                            SongId = track.Track.Id,
                            SongTitle = track.Track.Name
                        });
                    }
                }
            }

            return list;
        }
    }
}