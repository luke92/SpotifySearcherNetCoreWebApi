namespace SpotifySearcher.WCFServices.Modules.Shared.Models
{
    public class ErrorModel
    {
        public Error error { get; set; }
    }

    public class Error
    {
        public int status { get; set; }
        public string message { get; set; }

    }
}