using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheatreDemo
{
	class Movie
	{
		public int Length { get; }
		public int Year { get; }
		public string Title { get; }
		public Genre Genre { get; private set; }
		public List<string> Cast { get; }

		public Movie(string title, int year, int length)
		{
            this.Title = title;
            this.Year = year;
            this.Length = length;
            this.Cast = new List<string>();
		}

		public void AddActor(string actor)
		{
            Cast.Add(actor);
		}

		public void SetGenre(Genre genre)
		{
            this.Genre = genre;
		}

		public override string ToString()
		{
            return $"{Title}\nYear:{Year}\nLength:{Length}\nGenre:{Genre}\nCast:{string.Join(",", Cast)}";
		}
	}
}
