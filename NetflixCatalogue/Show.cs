using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace NetflixCatalogue
{
    public class Show : Title
    {

        //member variables
        Episode episode = new Episode();

        List<Episode> episodeList = new List<Episode>();

        public List<Show> showList = new List<Show>();

        int numberOfEpisodes;



        public override double? Rating
        {
            get
            {
                return rating;
            }
            set
            {
                if (rating == null)
                {
                    rating = 0;
                }
                else
                {
                    for (int episodeListIndex = 0; episodeListIndex < episodeList.Count(); episodeListIndex++)
                    {
                        rating += episodeList[episodeListIndex].Rating;
                    }
                    rating /= episodeList.Count();
                }
            }
        }

        public List<Show> ShowList
        {
            get
            {
                return showList;
            }
        }

        //constructor
        public Show()
        {

        }

        public Show(string Name, double Rating, string GenreForTitle, int NumberOfEpisodes) : base(Name, Rating, GenreForTitle)
        {
            numberOfEpisodes = NumberOfEpisodes;
            rating = 0;
        }



        //functions
        public void AddEpisodesToList(Show show)
        {
            for (int episodeListIndex = 0; episodeListIndex < show.numberOfEpisodes; episodeListIndex++)
            {
                show.episodeList.Add(episode);
            }
        }

        public override string ToString()
        {
            return name + "\t(" + numberOfEpisodes + " episodes)" + "\t" + Rating + " stars";
        }

        public void SetShowRatings(List<Show> showList)
        {
            Random randomRating = new Random();
            for (int showListIndex = 0; showListIndex < showList.Count(); showListIndex++)
            {
                for(int episodeListIndex = 0; episodeListIndex < showList[showListIndex].episodeList.Count(); episodeListIndex++)
                {
                    Thread.Sleep(1);
                    episode.Rating = randomRating.Next(1, 6);
                    showList[showListIndex].episodeList[episodeListIndex].Rating = episode.Rating;
                }
                showList[showListIndex].Rating = rating;
            }
        }

    }
}
