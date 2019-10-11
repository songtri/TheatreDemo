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

		public Time(int hours, int minutes)
		{
		}

		public override string ToString()
		{
			return base.ToString();
		}

		static public bool operator ==(Time lhs, Time rhs)
		{
			return true;
		}

		static public bool operator !=(Time lhs, Time rhs)
		{
			return false;
		}
	}
}
