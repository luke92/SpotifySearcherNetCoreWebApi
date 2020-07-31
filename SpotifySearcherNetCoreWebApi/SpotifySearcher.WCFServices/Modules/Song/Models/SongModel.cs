using System.Collections.Generic;

namespace SpotifySearcher.WCFServices.Modules.Song.Models
{
    public class SongModel
    {
        public List<Artist> Artists { get; set; }
        public int Disc_number { get; set; }
        public int Duration_ms { get; set; }
        public bool Explicit { get; set; }
        public ExternalUrls External_urls { get; set; }
        public string Href { get; set; }
        public string Id { get; set; }
        public bool Is_local { get; set; }
        public bool Is_playable { get; set; }
        public string Name { get; set; }
        public string Preview_url { get; set; }
        public int Track_number { get; set; }
        public string Type { get; set; }
        public string Uri { get; set; }

        public SongModel()
        {
            Artists = new List<Artist>();
            External_urls = new ExternalUrls();
        }
    }
    

    public class ExternalUrls
    {
        public string Spotify { get; set; }
    }

    public class Artist
    {
        public ExternalUrls External_urls { get; set; }
        public string Href { get; set; }
        public string Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Uri { get; set; }

        public Artist()
        {
            External_urls = new ExternalUrls();
        }
    }

}
