using SpotifySearcher.WCFServices.Modules.Song.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifySearcher.WCFServices.Modules.Song
{
    public interface ISongModule
    {
        Task<SongsModel> GetListSongsBasedCategory(string category);
    }
}
