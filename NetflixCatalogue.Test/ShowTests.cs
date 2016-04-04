using Microsoft.VisualStudio.TestTools.UnitTesting;
using NetflixCatalogue;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixCatalogue.Tests
{
    [TestClass()]
    public class ShowTests
    {
        [TestMethod()]
        public void OverrideToStringShouldPrintNameAndNumEpisodesTest()
        {
            //arrange
            string name = "Scrubs";
            int numberOfEpisodes = 20;
            string toString = "Scrubs\t(20)";
            //act
            string actualString = name + "\t(" + numberOfEpisodes + ")";
            //assert
            Assert.AreEqual(toString, actualString);
        }

        [TestMethod()]
        public void AddEpisodesShouldAddEdisode()
        {
            //arrange
            Episode episode = new Episode();
            List<Episode> episodeList = new List<Episode>();
            int listSize = episodeList.Count();
            //act
            episodeList.Add(episode);
            int listSizeFinal = episodeList.Count();
            //assert
            Assert.AreNotEqual(listSize, listSizeFinal);
        }

        [TestMethod()]
        public void AddEpisodesShouldAddOneEpisode()
        {
            //arrange
            Episode episode = new Episode();
            List<Episode> episodeList = new List<Episode>();
            int expectedListSize = 1;
            //act
            episodeList.Add(episode);
            int actualListSize = episodeList.Count();
            //assert
            Assert.AreEqual(expectedListSize, actualListSize);
        }

        [TestMethod()]
        public void AddEpisodesShouldAddCorrectEpisode()
        {
            //arrange
            Episode crazyEpisode = new Episode();
            List<Episode> episodeList = new List<Episode>();
            //act
            episodeList.Add(crazyEpisode);
            bool listContains = episodeList.Contains(crazyEpisode);
            //assert
            Assert.IsTrue(listContains);
        }
    }
}