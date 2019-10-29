using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//michael magtibay 301029090
namespace TheatreDemo
{
	class Theatre
	{
		private List<Show> shows = new List<Show>();
		public string Name { get; }

		public Theatre(string name)
		{
            this.Name = name;
            this.shows = new List<Show>();

        }

		public void AddShow(Show show)
		{
            this.shows.Add(show);
		}

		public void PrintShows()
		{

            foreach (var show in shows)
            {
                Console.WriteLine(show);
            }
        }

		public void PrintShows(Genre genre)
		{
            foreach (var show in shows)
            {
                if (show.Movie.Genre.HasFlag(genre))
                {
                    Console.WriteLine(show);
                }

            }

          
		}

		public void PrintShows(Day day)
		{

            var Shows = shows.FindAll(d => d.Day == day);
            foreach (var show in Shows)
            {
               
                Console.WriteLine(show);
            }
        }

		public void PrintShows(Time time)
		{
            var Shows = shows.FindAll(t => t.Time == time);
            foreach (var show in Shows)
            {

                Console.WriteLine(show);
            }

        }

		public void PrintShows(string actor)
		{
            var Shows = shows.FindAll(a => a.Movie.Cast.Contains(actor));
            foreach (var show in Shows)
            {

                Console.WriteLine(show);
            }

        }

		public void PrintShows(Day day, Time time)
		{
            var Shows = shows.FindAll(s => s.Time == time && s.Day == day);
            foreach (var show in Shows)
            {

                Console.WriteLine(show);
            }

        }
	}
}
