namespace SpotifySearcher.WCFServices.Modules.Shared.Models
{
    public class ErrorModel
    {
        public Error Error { get; set; }
    }

    public class Error
    {
        public int Status { get; set; }
        public string Message { get; set; }

    }
}