using SpotifySearcher.WCFServices.Modules.PlayList.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifySearcher.WCFServices.Modules.Category
{
    public interface ICategoryModule
    {
        Task<IList<PlayListItem>> GetPlayLists(string category);
    }
}
