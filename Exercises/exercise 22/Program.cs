using System;
using System.Threading;

namespace exercise_22
{
    class Program
    {
        static void Main(string[] args)
        {
			for (int i = 0; i < 10; i++)
			{
				Thread.Sleep(300);
				Console.WriteLine(DateTime.Now.ToString("yyyyMMddHHmmss"));
			}
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
			}

			Console.WriteLine("Type stop to stop..");
			inputString = Console.ReadLine();
			if (inputString == "stop")
			{
				stopWatch.Stop();
				Console.WriteLine("Stopped at {0}", stopWatch.StopTime.ToString("yyyyMMddHHmmss"));

			}
			else
			{
				Console.WriteLine("Type stop to stop..");
				while (Console.ReadLine() != "stop")
				{
					Console.WriteLine("Type stop to stop..");
				}
				stopWatch.Stop();
				Console.WriteLine("Stopped at {0}", stopWatch.StopTime.ToString("yyyyMMddHHmmss"));

			}
		}
    }
	public class Stopwatch
	{
		public DateTime StartTime { get; set; }
		public DateTime StopTime { get; set; }
		public bool IsRunning { get; set; }

		public void Start()
		{
			if (!IsRunning)
			{
				IsRunning = true;
				StartTime = DateTime.Now;
				Console.WriteLine("DateTime Now: {0}", DateTime.Now.ToString("yyyyMMddHHmmss"));
				Console.WriteLine("started at {0}", StartTime.ToString("yyyyMMddHHmmss"));
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
				Console.WriteLine("DateTime Now: {0}", DateTime.Now.ToString("yyyyMMddHHmmss"));
				Console.WriteLine("Stopped at {0}", StopTime.ToString("yyyyMMddHHmmss"));
				Console.WriteLine("You stopped after {0}", StopTime - StartTime);
			}
			else
			{
				throw new InvalidOperationException("Stopwatch can't be stopped: start it first.");
			}
		}
	}