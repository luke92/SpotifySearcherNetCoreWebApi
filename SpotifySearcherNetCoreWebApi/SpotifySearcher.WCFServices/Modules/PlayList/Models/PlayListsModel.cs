using SpotifySearcher.WCFServices.Modules.Shared.Models;
using SpotifySearcher.WCFServices.Modules.Song.Models;
using System.Collections.Generic;

namespace SpotifySearcher.WCFServices.Modules.PlayList.Models
{
    public class PlayListsModel
    {
        public Playlists Playlists { get; set; }
    }

    public class Owner
    {
        public string Display_name { get; set; }
        public ExternalUrlsModel External_urls { get; set; }
        public string Href { get; set; }
        public string Id { get; set; }
        public string Type { get; set; }
        public string Uri { get; set; }
    }

    public class Tracks
    {
        public string Href { get; set; }
        public int Total { get; set; }
    }

    public class PlayListItem
    {
        public bool Collaborative { get; set; }
        public string Description { get; set; }
        public ExternalUrlsModel External_urls { get; set; }
        public string Href { get; set; }
        public string Id { get; set; }
        public List<ImageModel> Images { get; set; }
        public string Name { get; set; }
        public Owner Owner { get; set; }
        public object Primary_color { get; set; }
        public object Public { get; set; }
        public string Snapshot_id { get; set; }
        public Tracks Tracks { get; set; }
        public string Type { get; set; }
        public string Uri { get; set; }
    }


    public class Playlists
    {
        public string Href { get; set; }
        public List<PlayListItem> Items { get; set; }
        public int Limit { get; set; }
        public string Next { get; set; }
        public int Offset { get; set; }
        public object Previous { get; set; }
        public int Total { get; set; }
    }

}