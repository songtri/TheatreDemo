using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheatreDemo
{
	class Time
	{
		public int Hours { get; }
		public int Minutes { get; }

		const int MAX_DIFF_MIN = 10;
		const int MIN_PER_HOUR = 60;

		public Time(int hours, int minutes)
		{
			Hours = hours;
			Minutes = minutes;
		}

		public override string ToString()
		{
			return $"{Hours}:{Minutes}";
		}

		static public bool operator ==(Time lhs, Time rhs)
		{
			int timeInMinutesL = lhs.Hours * MIN_PER_HOUR + lhs.Minutes;
			int timeInMinutesR = rhs.Hours * MIN_PER_HOUR + rhs.Minutes;

			return Math.Abs(timeInMinutesL - timeInMinutesR) <= MAX_DIFF_MIN;
		}

		static public bool operator !=(Time lhs, Time rhs)
		{
			int timeInMinutesL = lhs.Hours * MIN_PER_HOUR + lhs.Minutes;
			int timeInMinutesR = rhs.Hours * MIN_PER_HOUR + rhs.Minutes;

			return Math.Abs(timeInMinutesL - timeInMinutesR) > MAX_DIFF_MIN;
		}
	}
}
