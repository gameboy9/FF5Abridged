using CsvHelper;

namespace FF5Abridged.Inventory
{
	public class Items
	{
		private class singleItem
		{
			public int id { get; set; }
			public int sort_id { get; set; }
			public int type_id { get; set; }
			public int system_id { get; set; }
			public int item_lv { get; set; }
			public int attribute_id { get; set; }
			public int accuracy_rate { get; set; }
			public int destroy_rate { get; set; }
			public int standard_value { get; set; }
			public int renge_id { get; set; }
			public int menu_renge_id { get; set; }
			public int battle_renge_id { get; set; }
			public int invalid_reflection { get; set; }
			public int period_id { get; set; }
			public int throw_flag { get; set; }
			public int preparation_flag { get; set; }
			public int drink_flag { get; set; }
			public int machine_flag { get; set; }
			public int condition_group_id { get; set; }
			public int battle_effect_asset_id { get; set; }
			public int menu_se_asset_id { get; set; }
			public int menu_function_group_id { get; set; }
			public int battle_function_group_id { get; set; }
			public int buy { get; set; }
			public int sell { get; set; }
			public int sales_not_possible { get; set; }
		}

		public const int Potion = 2; // T1
		public const int HiPotion = 3; // T4
		public const int PhoenixDown = 4; // T2
		public const int Ether = 5; // T2
		public const int Antidote = 6; // T2
		public const int EyeDrops = 7; // T2
		public const int GoldNeedle = 8; // T2
		public const int MaidensKiss = 9; // T2
		public const int Mallet = 10; // T2
		public const int HolyWater = 11; // T6
		public const int Tent = 12; // T1
		public const int Cottage = 13; // T6
		public const int Elixir = 14; // T9
		public const int GoliathTonic = 15; // T6
		public const int PowerDrink = 16; // T6
		public const int SpeedShake = 17; // T6
		public const int IronDraft = 18; // T6
		public const int HeroCocktail = 19; // T6
		public const int TurtleShell = 20; // T7
		public const int DragonFang = 21; // T7
		public const int DarkMatter = 22; // T7
		public const int MagicLamp = 23; // T10
		public const int FlameScroll = 24; // T4
		public const int WaterScroll = 25; // T4
		public const int LightningScroll = 26; // T4
		public const int Ash = 27; // T8
		public const int Shuriken = 28; // T7
		public const int FumaShuriken = 29; // T10
		public const int Ramuh = 33; // T4
		public const int Catoblepas = 34; // T7
		public const int Golem = 35; // T7

		public List<List<int>> tiers = new List<List<int>>
			{ new List<int> { Potion, Tent },
			  new List<int> { EyeDrops, Antidote, GoldNeedle, MaidensKiss, Mallet, PhoenixDown },
			  new List<int> { },
			  new List<int> { HiPotion, FlameScroll, WaterScroll, LightningScroll, Ramuh },
			  new List<int> {  },
			  new List<int> { HolyWater, Cottage, GoliathTonic, PowerDrink, SpeedShake, IronDraft, HeroCocktail },
			  new List<int> { TurtleShell, DragonFang, DarkMatter, Shuriken, Catoblepas, Golem },
			  new List<int> { Ash },
			  new List<int> { Elixir },
			  new List<int> { FumaShuriken, MagicLamp },
			  new List<int> { },
			  new List<int> { }
		};

		public void adjustPrices(string directory, int multiplier, int divisor, int shopType)
		{
			List<singleItem> records;

			using (StreamReader reader = new StreamReader(Path.Combine("csv", "item.csv")))
			using (CsvReader csv = new CsvReader(reader, System.Globalization.CultureInfo.InvariantCulture))
				records = csv.GetRecords<singleItem>().ToList();

			foreach (singleItem item in records)
			{
				if (item.id == 51 || item.id == 52 || item.id == 53)
				{
					if (shopType == 1)
						item.buy *= 5;
					else if (shopType == 2)
						item.buy *= 25;
				}
				item.buy *= multiplier;
				item.buy /= divisor;
				item.sell *= Math.Min(multiplier, 4);
				item.sell /= divisor;

				item.buy = item.buy > 99999 ? 99999 : item.buy < 1 ? 1 : item.buy;
				item.sell = item.sell > 99999 ? 99999 : item.sell < 1 ? 1 : item.sell;
			}

			using (StreamWriter writer = new StreamWriter(Path.Combine(directory, "item.csv")))
			using (CsvWriter csv = new CsvWriter(writer, System.Globalization.CultureInfo.InvariantCulture))
			{
				csv.WriteRecords(records);
			}
		}

		public int selectItem(Random r1, int minTier, int maxTier)
		{
			minTier = Math.Min(minTier, 9);
			maxTier = Math.Min(maxTier, 10);

			List<int> selection = new List<int>();
			for (int i = minTier - 1; i <= maxTier - 1; i++)
				selection.AddRange(tiers[i]);
			return selection[r1.Next() % selection.Count];
		}
	}
}
