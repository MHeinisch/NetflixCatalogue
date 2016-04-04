using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixCatalogue
{
    class Program
    {
        static void Main(string[] args)
        {

            View run = new View();

            run.SetupCatalogue();

            run.PrintTitlesFromGenreList();

            Console.ReadLine();

        }
    }
}
