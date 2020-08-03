using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SpotifySearcherNetCoreWebApi.Business.Modules.Song
{
    public interface ISongModule
    {
        Task<SpotifyWCF.SongsModel> GetSongsByCategory(string category);
    }
}
