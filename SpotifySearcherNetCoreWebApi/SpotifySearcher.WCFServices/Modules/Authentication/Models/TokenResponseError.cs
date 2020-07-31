using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SpotifySearcher.WCFServices.Modules.Authentication.Models
{
    public class TokenResponseError
    {
        public string Error { get; set; }
        public string Error_description { get; set; }
    }
}