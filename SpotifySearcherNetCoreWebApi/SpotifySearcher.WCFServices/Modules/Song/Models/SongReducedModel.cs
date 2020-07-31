using System.Runtime.Serialization;

namespace SpotifySearcher.WCFServices.Modules.Song.Models
{
    [DataContract]
    public class SongReducedModel
    {
        [DataMember] public string SongId { get; set; }
        [DataMember] public string SongTitle { get; set; }
    }
}