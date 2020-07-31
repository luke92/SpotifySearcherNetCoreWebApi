using System.Collections.Generic;
using System.Runtime.Serialization;

namespace SpotifySearcher.WCFServices.Modules.Song.Models
{
    [DataContract]
    public class SongsModel
    {
        [DataMember] public List<SongReducedModel> Songs { get; set; }

        public SongsModel()
        {
            Songs = new List<SongReducedModel>();
        }
    }
}