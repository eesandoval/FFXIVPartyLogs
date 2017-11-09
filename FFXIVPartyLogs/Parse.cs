using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace FFXIVPartyLogs
{
	class Parse
	{
		public string CharacterName;
		public string ServerName;
		public string ServerRegion;
		public int Zone;
		public int Encounter;
		public string Spec;
		public int PerSecondAmount;
		public double Percentile;
		private string RawLogData;

		public Parse(string characterName, string serverName, string serverRegion)
		{
			CharacterName = characterName;
			ServerName = serverName;
			ServerRegion = serverRegion;
			Zone = 0;
			Encounter = 0;
			PerSecondAmount = 0;
			Percentile = 0;
			Spec = "Paladin";
		}

		public void UpdateTopLog(int zone, int encounter, string spec)
		{
			Zone = zone;
			Encounter = encounter;
			Spec = spec;
			if (UpdateRawLogData())
			{
				JArray jArray = JArray.Parse(RawLogData);
				JObject jObject = null;
				foreach (JObject j in jArray) jObject = j;
				JArray specs = (JArray)jObject["specs"];
				foreach (JObject j in specs)
				{
					if ((string)j["sepc"] == Spec)
					{
						jObject = j;
						break;
					}
				}
				if (jObject != null)
				{
					PerSecondAmount = (int)jObject["specs"][0]["best_persecondamount"];
					Percentile = (double)jObject["specs"][0]["best_historical_percent"];
				}
			}
		}

		private bool UpdateRawLogData()
		{
			RawLogData = FFLogsHelper.GetParses(CharacterName, ServerName, ServerRegion, Zone, Encounter);
			if (RawLogData == null || RawLogData == "")
				return false;
			return true;
		}
	}
}
