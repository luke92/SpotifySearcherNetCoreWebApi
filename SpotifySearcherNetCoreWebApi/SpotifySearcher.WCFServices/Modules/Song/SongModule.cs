using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using SpotifySearcher.WCFServices.Modules.Authentication;
using SpotifySearcher.WCFServices.Modules.Song.Models;

namespace SpotifySearcher.WCFServices.Modules.Song
{
    public class SongModule : ISongModule
    {
        private readonly IAuthenticationModule _authenticationModule;

        public SongModule()
        {
            _authenticationModule = new AuthenticationModule();
        }

        public async Task<SongsModel> GetListSongsBasedCategory(string category)
        {
            var list = new SongsModel();

            var authenticateResponse = await _authenticationModule.Authenticate();

            if (authenticateResponse.IsAuthenticated)
            {

            }

            return list;
        }
    }
}