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
		}

		public void AddActor(string actor)
		{
		}

		public void SetGenre(Genre genre)
		{
		}

		public override string ToString()
		{
			return base.ToString();
		}
	}
}
