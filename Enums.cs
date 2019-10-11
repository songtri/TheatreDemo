using System;

namespace TheatreDemo
{
	enum Day
	{
		Sun,
		Mon,
		Tue,
		Wed,
		Thu,
		Fri,
		Sat
	}

	[Flags]
	enum Genre
	{
		Unrated = 0x01,
		Action = 0x02,
		Romance = 0x04,
		Documentary = 0x08,
		Mystery = 0x10,
		Musical = 0x20,
		Horror = 0x40,
		Comedy = 0x80,
		Fantasy = 0x100,
		Animation = 0x200,
		Adventure = 0x400,
	}
}