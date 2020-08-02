using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SpotifySearcher.WCFServices.Modules.Category.Models
{
    public class CategoryModel
    {

        public string Href { get; set; }
        public List<Icon> Icons { get; set; }
        public string Id { get; set; }
        public string Name { get; set; }
        
    }

    public class Icon
    {
        public int? Height { get; set; }
        public string Url { get; set; }
        public int? Width { get; set; }
    }
}