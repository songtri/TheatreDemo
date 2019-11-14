using System;
using System.Collections.Generic;

namespace TheatreDemo
{
	class Theatre
	{
		private List<Show> shows;
		public string Name { get; }

		public Theatre(string name)
		{
			Name = name;
			shows = new List<Show>();
		}

		public void AddShow(Show show)
		{
			shows.Add(show);
		}

		public void PrintShows()
		{
			Console.WriteLine($"{Name} Theater");
			foreach (var show in shows)
			{
				Console.WriteLine(show);
			}
		}

		public void PrintShows(Genre genre)
		{
			Console.WriteLine($"{Name} Theater");
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
			Console.WriteLine($"{Name} Theater");
			foreach (var show in shows)
			{
				if (show.Day == day)
					Console.WriteLine(show);
			}
		}

		public void PrintShows(Time time)
		{
			Console.WriteLine($"{Name} Theater");
			foreach (var show in shows)
			{
				if (show.Time == time)
					Console.WriteLine(show);
			}
		}

		public void PrintShows(string actor)
		{
			Console.WriteLine($"{Name} Theater");
			foreach (var show in shows)
			{
				if (show.Movie.Cast.Contains(actor))
					Console.WriteLine(show);
			}
		}

		public void PrintShows(Day day, Time time)
		{
			Console.WriteLine($"{Name} Theater");
			foreach (var show in shows)
			{
				if (show.Time == time && show.Day == day)
					Console.WriteLine(show);
			}
		}
	}
}
