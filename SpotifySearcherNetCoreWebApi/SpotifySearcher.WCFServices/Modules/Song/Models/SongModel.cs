using SpotifySearcher.WCFServices.Modules.Shared.Models;
using System.Collections.Generic;

namespace SpotifySearcher.WCFServices.Modules.Song.Models
{
    public class SongModel
    {
        public Album Album { get; set; }
        public List<Artist> Artists { get; set; }
        public int Disc_number { get; set; }
        public int Duration_ms { get; set; }
        public bool Explicit { get; set; }
        public ExternalUrlsModel External_urls { get; set; }
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
            External_urls = new ExternalUrlsModel();
        }
    }


    public class Artist
    {
        public ExternalUrlsModel External_urls { get; set; }
        public string Href { get; set; }
        public string Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Uri { get; set; }

        public Artist()
        {
            External_urls = new ExternalUrlsModel();
        }
    }

    public class Album
    {
        public string Album_type { get; set; }
        public List<Artist> Artists { get; set; }
        public ExternalUrlsModel External_urls { get; set; }
        public string Href { get; set; }
        public string Id { get; set; }
        public List<ImageModel> Images { get; set; }
        public string Name { get; set; }
        public string Release_date { get; set; }
        public string Release_date_precision { get; set; }
        public int Total_tracks { get; set; }
        public string Type { get; set; }
        public string Uri { get; set; }
    }
}
