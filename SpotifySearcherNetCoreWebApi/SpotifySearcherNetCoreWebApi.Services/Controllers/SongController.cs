using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SpotifySearcherNetCoreWebApi.Business.Modules.Song;

namespace SpotifySearcherNetCoreWebApi.Services.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SongController : ControllerBase
    {
        private readonly ISongModule _songModule;

        public SongController(ISongModule songModule)
        {
            _songModule = songModule;
        }

        [HttpGet("{category}")]
        public async Task<ActionResult<SpotifyWCF.SongsModel>> Get(string category)
        {
            return await _songModule.GetSongsByCategory(category);
        }
    }
}