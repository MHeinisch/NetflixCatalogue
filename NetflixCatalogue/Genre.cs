using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixCatalogue
{
    public class Genre
    {

        //member variables
        //Title title = new Title();
        //public Show show = new Show();

        public List<Title> titleList = new List<Title>();

        string genreName;

        public virtual string GenreName
        {
            get
            {
                return genreName;
            }
            set
            {
                genreName = value;
            }
        }



        //constructor
        public Genre()
        {

        }



        //functions
        public static Genre operator+ (Genre genre1, Genre genre2)
        {
            Genre combinedGenre = new Genre();
            combinedGenre.genreName = genre1.genreName + "/" + genre2.genreName;
            for(int titleListOneIndex = 0; titleListOneIndex < genre1.titleList.Count(); titleListOneIndex++)
            {
                combinedGenre.titleList.Add(genre1.titleList[titleListOneIndex]);
            }
            for (int titleListTwoIndex = 0; titleListTwoIndex < genre1.titleList.Count(); titleListTwoIndex++)
            {
                combinedGenre.titleList.Add(genre2.titleList[titleListTwoIndex]);
            }
            return combinedGenre;
        }

        public static Genre operator+ (Genre genre, Title title)
        {
            Genre aggregatedGenre = new Genre();
            List<Title> aggregatedTitleList = new List<Title>();
            aggregatedGenre.genreName = genre.genreName + "/" + title.GenreForTitle;
            for(int genreTitleListIndex = 0; genreTitleListIndex < genre.titleList.Count(); genreTitleListIndex++)
            {
                aggregatedTitleList.Add(genre.titleList[genreTitleListIndex]);
            }
            aggregatedTitleList.Add(title);
            aggregatedGenre.titleList = aggregatedTitleList;
            return aggregatedGenre;
        }

        public void FillAllGenresTitleLists(Genre romance, Genre action, Genre comedy, Title title)
        {
            FillRomanceTitleList(romance, title);
            FillActionTitleList(action, title);
            FillComedyTitleList(comedy, title);
        }

        public void FillRomanceTitleList(Genre romance, Title title)
        {
            for(int allTitlesListIndex = 0; allTitlesListIndex < title.allTitlesList.Count(); allTitlesListIndex++)
            {
                if(title.allTitlesList[allTitlesListIndex].GenreForTitle.Equals("Romance"))
                {
                    romance.titleList.Add(title.allTitlesList[allTitlesListIndex]);
                }
            }
        }

        public void FillActionTitleList(Genre action, Title title)
        {
            for (int allTitlesListIndex = 0; allTitlesListIndex < title.allTitlesList.Count(); allTitlesListIndex++)
            {
                if (title.allTitlesList[allTitlesListIndex].GenreForTitle.Equals("Action"))
                {
                    action.titleList.Add(title.allTitlesList[allTitlesListIndex]);
                }
            }
        }

        public void FillComedyTitleList(Genre comedy, Title title)
        {
            for (int allTitlesListIndex = 0; allTitlesListIndex < title.allTitlesList.Count(); allTitlesListIndex++)
            {
                if (title.allTitlesList[allTitlesListIndex].GenreForTitle.Equals("Comedy"))
                {
                    comedy.titleList.Add(title.allTitlesList[allTitlesListIndex]);
                }
            }
        }
    }
}
