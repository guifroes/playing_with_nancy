using System;
using Nancy.Hosting.Self;
using System.Diagnostics;

namespace ConsoleNancy
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			var nancyHost = new NancyHost(new Uri("http://localhost:80/"),
			                              new Uri("http://127.0.0.1:80/"));

			nancyHost.Start();
            
			Console.WriteLine("nancy now listening - navigating to http://localhost:80/. Press enter to stop.");
			Process.Start("http://localhost:80/");
			Console.ReadKey();

			nancyHost.Stop();

			Console.WriteLine("Stopped. Bye!");
		}
	}
}
