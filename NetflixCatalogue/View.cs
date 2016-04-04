using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixCatalogue
{
    public class View
    {

        //member variables
        Genre genre = new Genre();
        Title title = new Title();
        Show show = new Show();
        Movie movie = new Movie();

        Genre all = new Genre();
        Genre romance = new Genre();
        Genre action = new Genre();
        Genre comedy = new Genre();


        public Movie loveActually = new Movie("Love Actually", 2, "Romance", 136);
        public Movie titanic = new Movie("The Titanic", 4, "Romance", 210);

        public Movie avengers = new Movie("The Avengers", 5, "Action", 143);
        public Movie spiderman = new Movie("Spider-Man", 5, "Action", 121);

        public Movie stepbrothers = new Movie("Step Brothers", 5, "Comedy", 106);
        public Movie hangover = new Movie("The Hangover", 5, "Comedy", 108);

        public Show greysAnatomy = new Show("Grey's Anatomy", 0, "Romance", 261);
        public Show prettyLittleLiars = new Show("Pretty Little Liars", 0, "Romance", 140);

        public Show daredevil = new Show("DareDevil", 0, "Action", 26);
        public Show arrow = new Show("Arrow", 0, "Action", 84);

        public Show scrubs = new Show("Scrubs", 0, "Comedy", 182);
        public Show archer = new Show("Archer", 0, "Comedy", 75);

        List<Genre> genreList = new List<Genre>();



        //constructor
        public View()
        {

        }



        //functions
        public void SetupCatalogue()
        {
            AddMoviesToAllTitlesList();
            AddShowsToAllTitlesList();
            FillGenreList();
            SetGenreNames();
            genre.FillAllGenresTitleLists(romance, action, comedy, title);
            AddShowsToShowsList();
            AddEpisodesForAllShows();
            AddMoviesToMoviesList();
            show.SetShowRatings(show.showList);
        }

        public void AddMoviesToAllTitlesList()
        {
            title.allTitlesList.Add(loveActually);
            title.allTitlesList.Add(titanic);
            title.allTitlesList.Add(avengers);
            title.allTitlesList.Add(spiderman);
            title.allTitlesList.Add(stepbrothers);
            title.allTitlesList.Add(hangover);
        }

        public void AddMoviesToMoviesList()
        {
            movie.movieList.Add(loveActually);
            movie.movieList.Add(titanic);
            movie.movieList.Add(avengers);
            movie.movieList.Add(spiderman);
            movie.movieList.Add(stepbrothers);
            movie.movieList.Add(hangover);
        }

        public void AddShowsToAllTitlesList()
        {
            title.allTitlesList.Add(greysAnatomy);
            title.allTitlesList.Add(prettyLittleLiars);
            title.allTitlesList.Add(daredevil);
            title.allTitlesList.Add(arrow);
            title.allTitlesList.Add(scrubs);
            title.allTitlesList.Add(archer);
        }

        public void AddShowsToShowsList()
        {
            show.showList.Add(greysAnatomy);
            show.showList.Add(prettyLittleLiars);
            show.showList.Add(daredevil);
            show.showList.Add(arrow);
            show.showList.Add(scrubs);
            show.showList.Add(archer);
        }

        public void AddEpisodesForAllShows()
        {
            show.AddEpisodesToList(greysAnatomy);
            show.AddEpisodesToList(prettyLittleLiars);
            show.AddEpisodesToList(daredevil);
            show.AddEpisodesToList(arrow);
            show.AddEpisodesToList(scrubs);
            show.AddEpisodesToList(archer);
        }

        public void FillGenreList()
        {
            genreList.Add(romance);
            genreList.Add(action);
            genreList.Add(comedy);
        }

        public void SetGenreNames()
        {
            genreList[0].GenreName = "Romance";
            genreList[1].GenreName = "Action";
            genreList[2].GenreName = "Comedy";
        }

        public void PrintTitlesFromGenreList()
      {
            for(int genreListIndex = 0; genreListIndex < genreList.Count(); genreListIndex++)
            {
                Console.WriteLine("Genre: " + genreList[genreListIndex].GenreName);
                Console.WriteLine("\tTitles: ");
                for(int titleListIndex = 0; titleListIndex < genreList[genreListIndex].titleList.Count(); titleListIndex++)
                {
                    Console.WriteLine("\t\t" + genreList[genreListIndex].titleList[titleListIndex].ToString());
                }
            }
        }
    }
}