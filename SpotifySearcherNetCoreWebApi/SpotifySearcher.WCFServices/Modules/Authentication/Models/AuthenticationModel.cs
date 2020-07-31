using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SpotifySearcher.WCFServices.Modules.Authentication.Models
{
    public class AuthenticationModel
    {
        public string ClientID { get; set; }
        public string ClientSecret { get; set; }
    }
}