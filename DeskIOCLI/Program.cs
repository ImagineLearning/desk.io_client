using System;
using System.Net;
using DeskIOLib;

namespace DeskIOCLI
{
	class Program
	{
		static void Main(string[] args)
		{
			if (args.Length < 2 || args.Length > 3)
			{
				Console.WriteLine("DeskIOCLI <ip> <command> <duration (optional)>");
				return;
			}

			var deskIp = IPAddress.Parse(args[0]);
			var desk = new Desk(deskIp);

			var command = args[1].ToLower();
			
			var duration = -1;
			if (args.Length == 3)
				duration = int.Parse(args[2]);

			switch (command)
			{
				case "up":
					desk.Raise(duration);
					break;
				case "down":
					desk.Lower(duration);
					break;
				case "stop":
					desk.Stop();
					break;
				default:
					Console.WriteLine("Invalid command: " + args[1]);
					break;
			}
			
			desk.Disconnect();
		}
	}
}
