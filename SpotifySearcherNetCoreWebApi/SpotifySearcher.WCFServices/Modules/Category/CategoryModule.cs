using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Newtonsoft.Json;
using SpotifySearcher.WCFServices.Modules.Authentication;
using SpotifySearcher.WCFServices.Modules.PlayList.Models;

namespace SpotifySearcher.WCFServices.Modules.Category
{
    public class CategoryModule : ICategoryModule
    {
        private readonly IAuthenticationModule _authenticationModule;

        public CategoryModule()
        {
            _authenticationModule = new AuthenticationModule();
        }

        public async Task<IList<PlayListItem>> GetPlayLists(string category)
        {
            var httpClient = await _authenticationModule.GetHttpClient();

            string url = "/v1/browse/categories/" + category + "/playlists?limit=1";
            var response = await httpClient.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                var result = JsonConvert.DeserializeObject<PlayListsModel>(json);
                return result.Playlists.Items;
            }
            else
            {
                return null;
            }
        }
    }
}