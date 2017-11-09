using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFXIVPartyLogs
{
	class Program
	{
		static void Main(string[] args)
		{
			while (true)
			{
				Console.Write("Character name:");
				string CharacterName = Console.ReadLine();
				Console.Write("Server name:");
				string ServerName = Console.ReadLine();
				Console.Write("Region:");
				string Region = Console.ReadLine();
				Console.Write("Zone:");
				int Zone = Convert.ToInt32(Console.ReadLine());
				Console.Write("Encounter:");
				int Encounter = Convert.ToInt32(Console.ReadLine()); ;
				Console.Write("Job:");
				string Spec = Console.ReadLine();
				Parse parse = new Parse(CharacterName, ServerName, Region);
				parse.UpdateTopLog(Zone, Encounter, Spec);
				Console.WriteLine("Highest DPS:{0} | Highest Percentile:{1}", parse.PerSecondAmount, parse.Percentile);
			}
		}
	}
}
