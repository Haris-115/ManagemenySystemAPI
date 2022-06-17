using System;
using System.Collections.Generic;
using System.Text;

namespace question_22
{
	class StopWatch
	{
		public DateTime StartTime;
		public DateTime StopTime;
		public bool IsRunning;
		public void Stopwatch()
		{
			StartTime = DateTime.Now;
			StopTime = DateTime.Now;
			IsRunning = false;
		}

		public void onStart()
		{
			Console.WriteLine(DateTime.Now);
			Console.WriteLine("Type start to start..");
			var inputString = Console.ReadLine();
			if (inputString == "start")
			{
				Start();
			}
			else
			{
				Console.WriteLine("Type start to start..");
				while (Console.ReadLine() != "start")
				{
					Console.WriteLine("Type start to start..");
				}
				Start();
			}

			Console.WriteLine("Type stop to stop..");
			inputString = Console.ReadLine();
			if (inputString == "stop")
			{
				Stop();
				Console.WriteLine("Stopped at {0}", StopTime);

			}
			else
			{
				Console.WriteLine("Type stop to stop..");
				while (Console.ReadLine() != "stop")
				{
					Console.WriteLine("Type stop to stop..");
				}
				Stop();
				Console.WriteLine("Stopped at {0}", StopTime);

			}
		}
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
