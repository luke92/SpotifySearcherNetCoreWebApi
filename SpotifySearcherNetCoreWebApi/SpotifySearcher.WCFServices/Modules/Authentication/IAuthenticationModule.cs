using SpotifySearcher.WCFServices.Modules.Authentication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace SpotifySearcher.WCFServices.Modules.Authentication
{
    public interface IAuthenticationModule
    {
        Task<AuthenticationResponse> Authenticate();

        HttpClient GetHttpClient();
    }
}
