using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core;
using KompasWrapper;
using Microsoft.VisualBasic.Devices;

namespace StressTest
{
	class Program
	{
		static void Main(string[] args)
		{
			var builder = new DresserBuilder();
            var stopWatch = new Stopwatch();
            var parameters = new Parameters();
			var streamWriter = new StreamWriter("log.txt", true);
            var count = 0;
			const double fromBitsToGigabytes = 0.000000000931322574615478515625;
            stopWatch.Start();
			while (true)
			{
				builder.Build(parameters);
				var computerInfo = new ComputerInfo();
				var usedMemory = (computerInfo.TotalPhysicalMemory - computerInfo.AvailablePhysicalMemory) *
				                 fromBitsToGigabytes;
				streamWriter.WriteLine(
					$"{++count}\t{stopWatch.Elapsed:hh\\:mm\\:ss}\t{usedMemory}");
				//streamWriter.Flush();
            }
		}
	}
}
