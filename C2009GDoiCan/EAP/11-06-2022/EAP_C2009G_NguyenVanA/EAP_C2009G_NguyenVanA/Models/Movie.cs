using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EAP_C2009G_NguyenVanA.Models
{
    public class Movie
    {
        public int MovieId { get; set; }
        public string Title { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int RunningTime { get; set; }
        public float BoxOffice { get; set; }
        //foreign key
        public int GenreId { get; set; }
        public virtual Genre Genre { get; set; }
    }
}