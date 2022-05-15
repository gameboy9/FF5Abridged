using FF5Abridged.Inventory;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using CsvHelper;
using System.Text;
using System.Threading.Tasks;
using CsvHelper.Configuration.Attributes;

namespace FF5Abridged.Randomize
{
	public class Treasure
	{
		private class message
		{
			[Index(0)]
			public string id { get; set; }
			[Index(1)]
			public string msgString { get; set; }
		}

		private class content
		{
			[Index(0)]
			public int id { get; set; }
			[Index(1)]
			public string mes_id_name { get; set; }
			[Index(2)]
			public string mes_id_battle { get; set; }
			[Index(3)]
			public string mes_id_description { get; set; }
			[Index(4)]
			public int icon_id { get; set; }
			[Index(5)]
			public int type_id { get; set; }
			[Index(6)]
			public int type_value { get; set; }
		}

		public Treasure(Random r1, int randoLevel, Jobs jobObject, string directory, string csvDirectory)
		{
			string[] CSVs = new string[] { "story_mes_de.txt", "story_mes_en.txt", "story_mes_es.txt", "story_mes_fr.txt", "story_mes_it.txt", "story_mes_ja.txt", "story_mes_ko.txt", "story_mes_pt.txt", "story_mes_ru.txt", "story_mes_th.txt", "story_mes_zhc.txt", "story_mes_zht.txt" };
			List<List<int>> finalItems = new List<List<int>>();
			List<int> jobsAcquired = new List<int>();

			// Now we need to cycle through the four super item scripts and place treasures in there.  We also will have to update the text accordingly.
			string[] scripts = new string[] { 
				"Map_30230\\Map_30230\\sc_e_0087_1.json",
				"Map_20010\\Map_20010\\sc_e_0018.json",
				"Map_20020\\Map_20020\\sc_e_0031.json",
				"Map_20030\\Map_20030\\sc_npc_20030_1.json",
				"Map_20040\\Map_20040\\sc_e_0139_5.json",
				"Map_20050\\Map_20050\\sc_e_0037_2.json",
				"Map_20070\\Map_20070\\sc_e_0044.json",
				"Map_20090\\Map_20090\\sc_e_0139_7.json",
				"Map_20100\\Map_20100\\sc_e_0055.json",
				"Map_20110\\Map_20110\\sc_e_0056.json",
				"Map_20120\\Map_20120\\sc_e_0057.json" };

			List<int> stdMinTier = new List<int> { 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
			List<int> proMinTier = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };

			int k = 0;
			foreach (string script in scripts)
			{
				k++;
				List<int> rewards = new List<int>();
				string json = File.ReadAllText(Path.Combine(directory, script));
				EventJSON jEvents = JsonConvert.DeserializeObject<EventJSON>(json);
				foreach (var singleScript in jEvents.Mnemonics)
				{
					if (singleScript.mnemonic == "Wait" || singleScript.mnemonic == "SysCall" || singleScript.mnemonic == "GetItem")
					{
						int finalType = r1.Next() % 5;

						int finalItem = -1;
						int finalJob = -1;
						int minTier = k + 1;
						int maxTier = k + 3;

						switch (finalType)
						{
							case 0:
								finalItem = new Weapons().selectItem(r1, minTier, maxTier);
								break;
							case 1:
								finalItem = new Armor().selectItem(r1, minTier, maxTier);
								break;
							case 2:
								finalItem = new Magic().selectItem(r1, minTier, maxTier);
								break;
							case 3:
								// Acquire job
								finalJob = jobObject.getJob();
								break;
							default: // Get nothing
								break;
						}
						if (finalType <= 2)
						{
							singleScript.mnemonic = "GetItem";
							singleScript.operands.iValues[0] = finalItem;
							singleScript.operands.iValues[1] = 1;
							singleScript.operands.rValues[0] = 0;
							rewards.Add(finalItem);
						}
						else if (finalType <= 4 && finalJob != -1)
						{
							singleScript.mnemonic = "SysCall";

							singleScript.operands.rValues[0] = 0;
							singleScript.operands.sValues[0] = jobObject.jobToString(finalJob);
							rewards.Add(finalJob + 10000);
						}
					}
				}

				JsonSerializer serializer = new JsonSerializer();

				using (StreamWriter sw = new StreamWriter(Path.Combine(directory, script)))
				using (JsonWriter writer = new JsonTextWriter(sw))
				{
					serializer.Serialize(writer, jEvents);
				}

				finalItems.Add(rewards);
			}


			foreach (string CSV in CSVs)
			{
				List<message> records = new List<message>();
				using (StreamReader reader = new StreamReader(Path.Combine(csvDirectory, CSV)))
				{
					CsvHelper.Configuration.CsvConfiguration config = new CsvHelper.Configuration.CsvConfiguration(System.Globalization.CultureInfo.InvariantCulture);
					config.Delimiter = "\t";
					config.HasHeaderRecord = false;
					config.BadDataFound = null;

					using (CsvReader csv = new CsvReader(reader, config))
						records = csv.GetRecords<message>().ToList();
				}

				int j = -1;
				foreach (string script in scripts)
                {
					j++;
					message record = new message();
					int finalItem;

					switch (script)
					{
						case "Map_30230\\Map_30230\\sc_e_0087_1.json":
							record = records.Where(c => c.id == "E0002_00_189_a_01").Single();
							break;
						case "Map_20010\\Map_20010\\sc_e_0018.json":
							record = records.Where(c => c.id == "E0003_00_189_a_02").Single();
							break;
						case "Map_20020\\Map_20020\\sc_e_0031.json":
							record = records.Where(c => c.id == "E0003_00_189_a_03").Single();
							break;
						case "Map_20030\\Map_20030\\sc_npc_20030_1.json":
							record = records.Where(c => c.id == "E0003_00_189_a_04").Single();
							break;
						case "Map_20040\\Map_20040\\sc_e_0139_5.json":
							record = records.Where(c => c.id == "E0003_00_189_a_05").Single();
							break;
						case "Map_20050\\Map_20050\\sc_e_0037_2.json":
							record = records.Where(c => c.id == "E0003_00_189_a_06").Single();
							break;
						case "Map_20070\\Map_20070\\sc_e_0044.json":
							record = records.Where(c => c.id == "E0003_00_189_a_07").Single();
							break;
						case "Map_20090\\Map_20090\\sc_e_0139_7.json":
							record = records.Where(c => c.id == "E0003_00_189_a_08").Single();
							break;
						case "Map_20100\\Map_20100\\sc_e_0055.json":
							record = records.Where(c => c.id == "E0003_00_189_a_09").Single();
							break;
						case "Map_20110\\Map_20110\\sc_e_0056.json":
							record = records.Where(c => c.id == "E0003_00_189_a_10").Single();
							break;
						case "Map_20120\\Map_20120\\sc_e_0057.json":
							record = records.Where(c => c.id == "E0003_00_189_a_11").Single();
							break;
					}

					record.msgString = "You found NOTHING!";
					int l = 0;
					foreach(var item in finalItems[j])
					{
						if (item < 10000)
						{
							if (l == 0)
								record.msgString = "Found ";
							else if (l == 2)
								record.msgString += "<P>\\nFound ";
							else
								record.msgString += "\\nFound ";
							record.msgString += itemLookup(itemIDLookup(item), CSV.Replace("story_mes_", "").Replace(".txt", "")) + "!";
						} else
						{
							if (l == 0)
								record.msgString = "Received the job ";
							else if (l == 2)
								record.msgString += "<P>\\nReceived the job ";
							else
								record.msgString += "\\nReceived the job ";
							record.msgString += itemLookup("MSG_JOB_NAME_" + (item - 10000).ToString("0#").Trim(), CSV.Replace("story_mes_", "").Replace(".txt", "")) + "!";
						}
						l++;
					}
				}

				message startRecord = records.Where(c => c.id == "N102_C01_030_05_02").Single();
				startRecord.msgString = "Welcome to Final Fantasy V:  Awesome Battles Randomized Involving Danger, Gilgamesh, and Ex Death, or FF5:  ABRIDGED for short.<P>\\n" +
					"RULES:\\nSet party order, jobs, and do your opening shopping now.\\nStart your timer when you leave this room.<P>\\n" +
					"You will undergo 12 areas filled with monsters.\\nAt the end of each area, you will fight a boss.<P>\\n" +
					"Defeat the boss and you will win prizes such as more jobs or nice treasure!<P>\\nGood luck and have fun!";

				using (StreamWriter writer = new StreamWriter(Path.Combine(csvDirectory, CSV)))
				{
					CsvHelper.Configuration.CsvConfiguration config = new CsvHelper.Configuration.CsvConfiguration(System.Globalization.CultureInfo.InvariantCulture);
					config.Delimiter = "\t";
					config.HasHeaderRecord = false;

					using (CsvWriter csv = new CsvWriter(writer, config))
						csv.WriteRecords(records);
				}
			}
		}

		private string itemIDLookup(int finalItem)
		{
			List<content> contentCSV = new List<content>();
			using (StreamReader reader = new StreamReader(Path.Combine("Data", "Master", "content.csv")))
			{
				CsvHelper.Configuration.CsvConfiguration config = new CsvHelper.Configuration.CsvConfiguration(System.Globalization.CultureInfo.InvariantCulture);
				config.Delimiter = ",";
				config.HasHeaderRecord = true;
				config.BadDataFound = null;

				using (CsvReader csv = new CsvReader(reader, config))
					contentCSV = csv.GetRecords<content>().ToList();
			}
			return contentCSV.Where(c => c.id == finalItem).Single().mes_id_name;
		}

		private string itemLookup(string mesName, string language)
		{
			// Get mes_id_name from content.csv, then get accordingly name from whatever language you're using. (system_xx)
			List<message> records = new List<message>();
			using (StreamReader reader = new StreamReader(Path.Combine("Data", "Message", "system_" + language + ".txt")))
			{
				CsvHelper.Configuration.CsvConfiguration config = new CsvHelper.Configuration.CsvConfiguration(System.Globalization.CultureInfo.InvariantCulture);
				config.Delimiter = "\t";
				config.HasHeaderRecord = false;
				config.BadDataFound = null;

				using (CsvReader csv = new CsvReader(reader, config))
					records = csv.GetRecords<message>().ToList();
			}

			return records.Where(c => c.id == mesName).Single().msgString;
		}
	}
}