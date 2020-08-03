using SpotifySearcher.WCFServices.Modules.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SpotifySearcher.WCFServices.Modules.Song.Models
{

    public class AddedBy
    {
        public ExternalUrlsModel External_urls { get; set; }
        public string Href { get; set; }
        public string Id { get; set; }
        public string Type { get; set; }
        public string Uri { get; set; }
    }

    public class Artist2
    {
        public ExternalUrlsModel External_urls { get; set; }
        public string Href { get; set; }
        public string Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Uri { get; set; }
    }

    public class ExternalIds
    {
        public string Isrc { get; set; }
    }


    public class VideoThumbnail
    {
        public object Url { get; set; }
    }

    public class TrackItem
    {
        public DateTime Added_at { get; set; }
        public AddedBy Added_by { get; set; }
        public bool Is_local { get; set; }
        public string Primary_color { get; set; }
        public SongModel Track { get; set; }
        public VideoThumbnail Video_thumbnail { get; set; }
    }

    public class TracksModel
    {
        public string Href { get; set; }
        public List<TrackItem> Items { get; set; }
        public int Limit { get; set; }
        public object Next { get; set; }
        public int Offset { get; set; }
        public object Previous { get; set; }
        public int Total { get; set; }
    }


}