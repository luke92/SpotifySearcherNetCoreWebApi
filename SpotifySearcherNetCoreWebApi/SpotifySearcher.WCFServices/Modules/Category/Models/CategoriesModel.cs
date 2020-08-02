using System.Collections.Generic;

namespace SpotifySearcher.WCFServices.Modules.Category.Models
{
    public class CategoriesModel
    {
        public Categories Categories { get; set; }
               
    }

    public class Categories
    {
        public string Href { get; set; }
        public List<CategoryModel> Items { get; set; }
        public int Limit { get; set; }
        public string Next { get; set; }
        public int Offset { get; set; }
        public object Previous { get; set; }
        public int Total { get; set; }
    }
}