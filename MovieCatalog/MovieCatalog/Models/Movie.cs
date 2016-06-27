using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieCatalog.Models
{
    public class Movie
    {
        public int mv_id { get; set; }
        public string mv_title { get; set; }
        public DateTime mv_release_date { get; set; }
        public int mv_duration { get; set; }
        public string mv_language { get; set; }
        public string mv_director { get; set; }
        public string mv_story_line { get; set; }
        public decimal mv_imdb_score { get; set; }
    }
}