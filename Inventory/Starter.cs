using FF5Abridged.Inventory;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FF5Abridged.Inventory
{
	internal class Starter
	{
		public Starter(Random r1, Jobs jobObject, string directory)
		{
			string json = File.ReadAllText(Path.Combine(directory, "Map_20250", "Map_20250", "sc_e_0001.json"));
			EventJSON jEvents = JsonConvert.DeserializeObject<EventJSON>(json);

			EventJSON.Mnemonic exit = jEvents.Mnemonics.Where(c => c.mnemonic == "Exit").Single();
			jEvents.Mnemonics.Remove(exit);
			EventJSON.Mnemonic changeMap = jEvents.Mnemonics.Where(c => c.mnemonic == "ChangeMap").Single();
			jEvents.Mnemonics.Remove(changeMap);

			for (int i = 0; i < 4; i++)
			{
				EventJSON.Mnemonic newJob = new EventJSON.Mnemonic();
				newJob.label = "";
				newJob.mnemonic = "SysCall";
				newJob.operands = new EventJSON.Operands();
				newJob.operands.iValues = new int?[8];
				newJob.operands.rValues = new float?[8];
				newJob.operands.sValues = new string[8];
				for (int j = 0; j < 8; j++)
				{
					newJob.operands.iValues[j] = 0;
					newJob.operands.rValues[j] = 0;
					newJob.operands.sValues[j] = j == 0 ? jobObject.jobToString(jobObject.getJob()) : "";
				}
				newJob.type = 1;
				newJob.comment = "";
				jEvents.Mnemonics.Add(newJob);
			}

			changeMap = new EventJSON.Mnemonic();
			changeMap.label = "";
			changeMap.mnemonic = "ChangeMap";
			changeMap.operands = new EventJSON.Operands();
			changeMap.operands.iValues = new int?[8];
			changeMap.operands.rValues = new float?[8];
			changeMap.operands.sValues = new string[8];
			for (int j = 0; j < 8; j++)
			{
				changeMap.operands.iValues[j] = j == 0 ? 321 : j == 1 ? 1 : 0;
				changeMap.operands.rValues[j] = 0;
				changeMap.operands.sValues[j] = "";
			}
			changeMap.type = 1;
			changeMap.comment = "";
			jEvents.Mnemonics.Add(changeMap);

			exit = new EventJSON.Mnemonic();
			exit.label = "";
			exit.mnemonic = "Exit";
			exit.operands = new EventJSON.Operands();
			exit.operands.iValues = new int?[8];
			exit.operands.rValues = new float?[8];
			exit.operands.sValues = new string[8];
			for (int j = 0; j < 8; j++)
			{
				exit.operands.iValues[j] = 0;
				exit.operands.rValues[j] = 0;
				exit.operands.sValues[j] = "";
			}
			exit.type = 2;
			exit.comment = "";
			jEvents.Mnemonics.Add(exit);

			JsonSerializer serializer = new JsonSerializer();
			using (StreamWriter sw = new StreamWriter(Path.Combine(directory, "Map_20250", "Map_20250", "sc_e_0001.json")))
			using (JsonWriter writer = new JsonTextWriter(sw))
			{
				serializer.Serialize(writer, jEvents);
			}
		}
	}
}
