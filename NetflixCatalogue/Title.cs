using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixCatalogue
{
    public class Title
    {

        //member variables
        protected string name;
        protected double? rating;
        public string genreForTitle;

        public List<Title> allTitlesList = new List<Title>();

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }


        public virtual double? Rating
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

        public string GenreForTitle
        {
            get
            {
                return genreForTitle;
            }
            set
            {
                genreForTitle = value;
            }
        }



        //constructor
        public Title()
        {
            name = null;
            rating = null;
            genreForTitle = null;
        }

        public Title(string Name, double Rating, string GenreForTitle)
        {
            name = Name;
            rating = Rating;
            genreForTitle = GenreForTitle;
        }



        //functions
         public static Genre operator+(Title title1, Title title2)
         {
            Genre aggregatedGenre = new Genre();
            aggregatedGenre.GenreName = title1.genreForTitle + "/" + title2.genreForTitle;
            aggregatedGenre.titleList.Add(title1);
            aggregatedGenre.titleList.Add(title2);
            return aggregatedGenre;
         }

    }
}