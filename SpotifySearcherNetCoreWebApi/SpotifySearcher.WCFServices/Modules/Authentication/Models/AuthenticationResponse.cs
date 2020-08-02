using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SpotifySearcher.WCFServices.Modules.Authentication.Models
{
    public class AuthenticationResponse
    {
        public TokenResponseOk ResponseOk { get; set; }
        public TokenResponseError ResponseError { get; set; }
        public bool IsAuthenticated { get; set; }
    }
}