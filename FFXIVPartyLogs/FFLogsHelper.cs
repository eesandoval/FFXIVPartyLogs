using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using Newtonsoft.Json.Linq;
namespace FFXIVPartyLogs
{
	static class FFLogsHelper
	{
		public struct Encounter
		{
			public int id;
			public string name;
		}
		public struct Zone
		{
			public int id;
			public string name;
			public bool frozen;
			public List<Encounter> encounters;
		}

		public static List<Zone> Zones = null;

		private static string FFLogsAPI = "https://www.fflogs.com:443/v1";
		private static string ParsesAPI = "/parses/character/{0}/{1}/{2}?";
		private static string ZonesAPI = "/zones?";
		private static string APIKey = "1dc6b9e941157540fd28c9de961fcd41";
	
		static FFLogsHelper()
		{
			UpdateZones();
		}

		public static string GetParses(string characterName, string serverName, string serverRegion,
										int? zone=null, int? encounter=null, string metric=null,
										string bracket=null, string compare=null, string partition=null)
		{
			string result = null;
			using (WebClient webClient = new WebClient())
			{
				string url = FFLogsAPI + String.Format(ParsesAPI, characterName.Replace(" ", "%20"), serverName, serverRegion);
				url += zone != null ? "zone=" + zone.ToString() + "&" : "";
				url += encounter != null ? "encounter=" + encounter.ToString() + "&" : "";
				url += metric != null ? "metric=" + metric + "&" : "";
				url += bracket != null ? "bracket=" + bracket + "&" : "";
				url += compare != null ? "compare=" + compare + "&" : "";
				url += partition != null ? "partition-" + partition + "&" : "";
				url += "api_key=" + APIKey;
				result = webClient.DownloadString(url);
			}
			return result;
		}

		public static void UpdateZones()
		{
			Zones = new List<Zone>();
			using (WebClient webClient = new WebClient())
			{
				string url = FFLogsAPI + ZonesAPI + "api_key=" + APIKey;
				string response = webClient.DownloadString(url);
				JArray jZones = JArray.Parse(response);
				foreach (JObject jZone in jZones)
				{
					Zone zone = new Zone
					{
						id = (int)jZone["id"],
						name = (string)jZone["name"],
						frozen = (bool)jZone["frozen"]
					};
					List<Encounter> encounters = new List<Encounter>();
					JArray jEncounters = (JArray)jZone["encounters"];
					foreach (JObject jEncounter in jEncounters)
					{
						Encounter encounter = new Encounter
						{
							id = (int)jEncounter["id"],
							name = (string)jEncounter["name"]
						};
						encounters.Add(encounter);
					}
					zone.encounters = encounters;
				}
			}
		}
	}
}
