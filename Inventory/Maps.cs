using CsvHelper;
using CsvHelper.Configuration.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FF5Abridged.Inventory
{
	public class Maps
	{
		private class message
		{
			[Index(0)]
			public string id { get; set; }
			[Index(1)]
			public string msgString { get; set; }
		}

		public Maps(Random r1, string csvDirectory)
		{
			string[] CSVs = new string[] { "system_de.txt", "system_en.txt", "system_es.txt", "system_fr.txt", "system_it.txt", "system_ja.txt", "system_ko.txt", "system_pt.txt", "system_ru.txt", "system_th.txt", "system_zhc.txt", "system_zht.txt" };
			foreach (string CSV in CSVs)
			{
				List<message> records = new List<message>();
				using (StreamReader reader = new StreamReader(Path.Combine(csvDirectory, "Data", "Message", CSV)))
				{
					CsvHelper.Configuration.CsvConfiguration config = new CsvHelper.Configuration.CsvConfiguration(System.Globalization.CultureInfo.InvariantCulture);
					config.Delimiter = "\t";
					config.HasHeaderRecord = false;
					config.BadDataFound = null;

					using (CsvReader csv = new CsvReader(reader, config))
						records = csv.GetRecords<message>().ToList();
				}

				for (int i = -1; i < 24; i++)
				{
					message record = new message();

					switch (i)
					{
						case -1: record = records.Where(c => c.id == "MSG_MAP_NAME_59").Single(); break;
						case 0: record = records.Where(c => c.id == "MSG_MAP_NAME_56").Single(); break;
						case 1: record = records.Where(c => c.id == "MSG_MAP_NAME_10").Single(); break;
						case 2: record = records.Where(c => c.id == "MSG_MAP_NAME_15").Single(); break;
						case 3: record = records.Where(c => c.id == "MSG_MAP_NAME_17").Single(); break;
						case 4: record = records.Where(c => c.id == "MSG_MAP_NAME_20").Single(); break;
						case 5: record = records.Where(c => c.id == "MSG_MAP_NAME_18").Single(); break;
						case 6: record = records.Where(c => c.id == "MSG_MAP_NAME_25").Single(); break;
						case 7: record = records.Where(c => c.id == "MSG_MAP_NAME_30").Single(); break;
						case 8: record = records.Where(c => c.id == "MSG_MAP_NAME_32").Single(); break;
						case 9: record = records.Where(c => c.id == "MSG_MAP_NAME_34").Single(); break;
						case 10: record = records.Where(c => c.id == "MSG_MAP_NAME_38").Single(); break;
						case 11: record = records.Where(c => c.id == "MSG_MAP_NAME_46").Single(); break;
						case 12: record = records.Where(c => c.id == "MSG_ARA_NAME_56").Single(); break;
						case 13: record = records.Where(c => c.id == "MSG_ARA_NAME_06").Single(); break;
						case 14: record = records.Where(c => c.id == "MSG_ARA_NAME_24").Single(); break;
						case 15: record = records.Where(c => c.id == "MSG_ARA_NAME_25").Single(); break;
						case 16: record = records.Where(c => c.id == "MSG_ARA_NAME_07").Single(); break;
						case 17: record = records.Where(c => c.id == "MSG_ARA_NAME_08").Single(); break;
						case 18: record = records.Where(c => c.id == "MSG_ARA_NAME_01").Single(); break;
						case 19: record = records.Where(c => c.id == "MSG_ARA_NAME_04").Single(); break;
						case 20: record = records.Where(c => c.id == "MSG_ARA_NAME_03").Single(); break;
						case 21: record = records.Where(c => c.id == "MSG_ARA_NAME_11").Single(); break;
						case 22: record = records.Where(c => c.id == "MSG_ARA_NAME_05").Single(); break;
						case 23: record = records.Where(c => c.id == "MSG_ARA_NAME_12").Single(); break;
					}

					if (i == -1)
						record.msgString = "Big Bridge";
					else if (i < 12)
						record.msgString = "Big Bridge - Round " + (i + 1).ToString();
					else
					{
						int j = i - 11;
						record.msgString = j == 1 ? "Opening Area" : (j == 2 ? "1st" : j == 3 ? "2nd" : j == 4 ? "3rd" : (j - 1).ToString().Trim() + "th") + " Intermission";
					}
				}

				using (StreamWriter writer = new StreamWriter(Path.Combine(csvDirectory, "Data", "Message", CSV)))
				{
					CsvHelper.Configuration.CsvConfiguration config = new CsvHelper.Configuration.CsvConfiguration(System.Globalization.CultureInfo.InvariantCulture);
					config.Delimiter = "\t";
					config.HasHeaderRecord = false;

					using (CsvWriter csv = new CsvWriter(writer, config))
						csv.WriteRecords(records);
				}
			}

			CSVs = new string[] { "story_mes_de.txt", "story_mes_en.txt", "story_mes_es.txt", "story_mes_fr.txt", "story_mes_it.txt", "story_mes_ja.txt", "story_mes_ko.txt", "story_mes_pt.txt", "story_mes_ru.txt", "story_mes_th.txt", "story_mes_zhc.txt", "story_mes_zht.txt" };
			foreach (string CSV in CSVs)
			{
				List<message> records = new List<message>();
				using (StreamReader reader = new StreamReader(Path.Combine(csvDirectory, "Data", "Message", CSV)))
				{
					CsvHelper.Configuration.CsvConfiguration config = new CsvHelper.Configuration.CsvConfiguration(System.Globalization.CultureInfo.InvariantCulture);
					config.Delimiter = "\t";
					config.HasHeaderRecord = false;
					config.BadDataFound = null;

					using (CsvReader csv = new CsvReader(reader, config))
						records = csv.GetRecords<message>().ToList();
				}

				for (int i = 1; i <= 6; i++)
				{
					message record = new message();

					record = records.Where(c => c.id == "E0162_01_593_a_0" + i.ToString().Trim()).Single();

					switch (i)
					{
						case 1:
							record.msgString = "Congratulations!";
							break;
						case 2:
							record.msgString = "You have conquered FF5:  Abridged!";
							break;
						case 3:
							record.msgString = "Written by gameboyf9";
							break;
						case 4:
							record.msgString = "Special Thanks to...";
							break;
						case 5:
							record.msgString = "Albeoris, Silvis, and mcgrew";
							break;
						case 6:
							record.msgString = "Thanks for playing!";
							break;
					}
				}

				using (StreamWriter writer = new StreamWriter(Path.Combine(csvDirectory, "Data", "Message", CSV)))
				{
					CsvHelper.Configuration.CsvConfiguration config = new CsvHelper.Configuration.CsvConfiguration(System.Globalization.CultureInfo.InvariantCulture);
					config.Delimiter = "\t";
					config.HasHeaderRecord = false;

					using (CsvWriter csv = new CsvWriter(writer, config))
						csv.WriteRecords(records);
				}
			}

		}
	}
}
