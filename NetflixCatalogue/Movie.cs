using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixCatalogue
{
    public class Movie : Title
    {

        //member variables
        int duration;

        public List<Movie> movieList = new List<Movie>();

        public override double? Rating
        {
            get
            {
                return rating;
            }
            set
            {
                rating = value;
            }
        }



        //constructor
        public Movie()
        {

        }

        public Movie(string Name, double Rating, string GenreForTitle, int Duration) : base(Name, Rating, GenreForTitle)
        {
            duration = Duration;
        }



        //functions
        public override string ToString()
        {
            return name + "\t(" + duration + "m)" + "\t" + Rating + " stars";
        }

    }
}
