using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ize
{
    public record Movie
    {
        public string Title { get; init; }
        public string Director { get; init; }
        protected string Genre { get; init; }
        
        private int ReleaseYear { get; init; }
        private double Rating { get; set; } 
        protected int ViewCount { get; set; }

        public Movie(string title, string director, string genre, int releaseYear, double rating, int viewCount)
        {
            Title = title;
            Director = director;
            Genre = genre;
            ReleaseYear = releaseYear;
            Rating = rating;
            ViewCount = viewCount;
        }

        private bool ISValR(double r)
        {
           if(r > 0.0 && r <= 10.0)
            {
                return true;
            }
            return false;
        }
        public bool UpR(double ra)
        {
            if(ISValR(ra))
            {
                Rating = ra;
                return true;
            }
            return false;
        }
        public bool ISP()
        {
            if(ViewCount >= 1000000)
            {
                return true;
            }
            return false;
        }
        public string SUm()        {
            return $"Title: {Title}, Director: {Director}, Release Year: {ReleaseYear}, Rating: {Rating}";
        } 


    }
}
