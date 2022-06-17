using System;
using System.Threading;

namespace exrcise_21
{
    class Program
    {
        static void Main(string[] args)
        {
			Console.WriteLine(DateTime.Now);
			var stopWatch = new Stopwatch();
			Console.WriteLine("Type start to start..");
			var inputString = Console.ReadLine();
			if (inputString == "start")
			{
				stopWatch.Start();
			}
			else
			{
				Console.WriteLine("Type start to start..");
				while (Console.ReadLine() != "start")
				{
					Console.WriteLine("Type start to start..");
				}
				stopWatch.Start();
			}

			Console.WriteLine("Type stop to stop..");
			inputString = Console.ReadLine();
			if (inputString == "stop")
			{
				stopWatch.Stop();
				Console.WriteLine("Stopped at {0}", stopWatch.StopTime);

			}
			else
			{
				Console.WriteLine("Type stop to stop..");
				while (Console.ReadLine() != "stop")
				{
					Console.WriteLine("Type stop to stop..");
				}
				stopWatch.Stop();
				Console.WriteLine("Stopped at {0}", stopWatch.StopTime);

			}
		}
    }
	public class Stopwatch
	{
		public DateTime StartTime;
		public DateTime StopTime;
		public bool IsRunning; 

		public void Start()
		{
			if (!IsRunning)
			{
				IsRunning = true;
				StartTime = DateTime.Now;
				Console.WriteLine("DateTime Now: {0}", DateTime.Now);
				Console.WriteLine("started at {0}", StartTime);
			}
			else
			{
				throw new InvalidOperationException("Stopwatch is already running");
			}
		}

		public void Stop()
		{
			if (IsRunning)
			{
				IsRunning = false;
				StopTime = DateTime.Now;
				Console.WriteLine("DateTime Now: {0}", DateTime.Now);
				Console.WriteLine("Stopped at {0}", StopTime);
				Console.WriteLine("You stopped after {0}", StopTime - StartTime);
			}
			else
			{
				throw new InvalidOperationException("Stopwatch can't be stopped: start it first.");
			}
		}
	}
}

					


