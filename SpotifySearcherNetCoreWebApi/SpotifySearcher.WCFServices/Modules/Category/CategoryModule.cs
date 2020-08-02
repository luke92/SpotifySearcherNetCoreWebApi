using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using SpotifySearcher.WCFServices.Modules.PlayList.Models;

namespace SpotifySearcher.WCFServices.Modules.Category
{
    public class CategoryModule : ICategoryModule
    {
        public Task<IList<PlayListItem>> GetPlayLists(string category)
        {
            throw new NotImplementedException();
        }
    }
}