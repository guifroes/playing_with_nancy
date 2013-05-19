using System;

namespace ConsoleNancy
{
	public class HomeModule : Nancy.NancyModule
	{
		public HomeModule ()
		{
			Get["/"] = _ => "bla bla";
		}
	}
}

