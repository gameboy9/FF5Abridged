using CsvHelper;

namespace FF5Abridged.Inventory
{
	class Armor
	{
		private class singleArmor
		{
			public int id { get; set; }
			public int sort_id { get; set; }
			public int type_id { get; set; }
			public int equip_job_group_id { get; set; }
			public int parts_group_id { get; set; }
			public int defense { get; set; }
			public int ability_defense { get; set; }
			public int weight { get; set; }
			public int evasion_rate { get; set; }
			public int ability_evasion_rate { get; set; }
			public int ability_disturbed_rate { get; set; }
			public int destroy_rate { get; set; }
			public int magnetic_force { get; set; }
			public int invalid_reflection { get; set; }
			public int trigger_ability_id { get; set; }
			public int wear_function_group_id { get; set; }
			public int wear_condition_group_id { get; set; }
			public int resistance_attribute { get; set; }
			public int resistance_condition { get; set; }
			public int resistance_species { get; set; }
			public int strength { get; set; }
			public int vitality { get; set; }
			public int agility { get; set; }
			public int intelligence { get; set; }
			public int spirit { get; set; }
			public int magic { get; set; }
			public int max_hp_up { get; set; }
			public int max_mp_up { get; set; }
			public int battle_effect_asset_id { get; set; }
			public int guard_icon { get; set; }
			public int se_asset_id { get; set; }
			public int buy { get; set; }
			public int sell { get; set; }
			public int sales_not_possible { get; set; }
			public string process_prog { get; set; }
		}

		public const int LeatherShield = 178; // T1
		public const int BronzeShield = 179; // T2
		public const int IronShield = 180; // T2
		public const int MythrilShield = 181; // T3
		public const int GoldenShield = 182; // T6
		public const int AegisShield = 183; // T9
		public const int DiamondShield = 184; // T8
		public const int FlameShield = 185; // T9
		public const int IceShield = 186; // T9
		public const int CrystalShield = 187; // T10
		public const int GenjiShield = 188; // T12
		public const int LeatherCap = 190; // T1
		public const int PlumedHat = 191; // T3
		public const int HypnoCrown = 192; // T7
		public const int GreenBeret = 194; // T4
		public const int Headband = 195; // T7
		public const int TigerMask = 196; // T8
		public const int BlackCowl = 197; // T10
		public const int LamiasTiara = 198; // T9
		public const int WizardsHat = 199; // T6
		public const int SagesMiter = 200; // T8
		public const int Circlet = 201; // T10
		public const int GoldHairpin = 202; // T9
		public const int Ribbon = 203; // T9
		public const int BronzeHelm = 204; // T2
		public const int IronHelm = 205; // T2
		public const int MythrilHelm = 206; // T3
		public const int GoldenHelm = 207; // T6
		public const int DiamondHelm = 208; // T8
		public const int CrystalHelm = 209; // T10
		public const int GenjiHelm = 210; // T10
		public const int Thornlet = 212; // T9
		public const int LeatherArmor = 213; // T1
		public const int AngelRobe = 214; // T8
		public const int MirageVest = 215; // T10
		public const int RainbowDress = 216; // T12
		public const int CopperCuirass = 218; // T2
		public const int KenpoGi = 219; // T2
		public const int SilverPlate = 220; // T3
		public const int NinjaSuit = 221; // T4
		public const int PowerSash = 222; // T7
		public const int DiamondPlate = 223; // T8
		public const int BlackGarb = 224; // T10
		public const int BoneMail = 225; // T7
		public const int CottonRobe = 226; // T2
		public const int SilkRobe = 227; // T3
		public const int SagesSurplice = 228; // T4
		public const int GaiaGear = 229; // T6
		public const int LuminousRobe = 230; // T8
		public const int BlackRobe = 231; // T9
		public const int WhiteRobe = 232; // T9
		public const int BronzeArmor = 234; // T2
		public const int IronArmor = 235; // T2
		public const int MythrilArmor = 236; // T3
		public const int GoldenArmor = 237; // T4
		public const int DiamondArmor = 238; // T8
		public const int CrystalArmor = 239; // T10
		public const int GenjiArmor = 240; // T12
		public const int MythrilGloves = 242; // T3
		public const int ThiefsGloves = 243; // T6
		public const int Gauntlets = 244; // T7
		public const int TitansGloves = 245; // T12
		public const int GenjiGloves = 246; // T9
		public const int SilverArmlet = 247; // T3
		public const int PowerArmlet = 248; // T7
		public const int DiamondArmlet = 249; // T8
		public const int LeatherShoes = 251; // T1
		public const int HermesSandals = 252; // T10
		public const int RedSlippers = 253; // T12
		public const int AngelRing = 254; // T6
		public const int FlameRing = 255; // T6
		public const int CoralRing = 256; // T6
		public const int ReflectRing = 257; // T8
		public const int ProtectRing = 258; // T9
		public const int CursedRing = 259; // T9
		public const int KaiserKnuckles = 260; // T10
		public const int SilverSpecs = 261; // T2
		public const int ElvenMantle = 262; // T3
		public const int KornagoGourd = 266; // T7
		 

		public List<List<int>> tiers = new List<List<int>>
			{ new List<int> { LeatherShield, LeatherCap, LeatherArmor, LeatherShoes },
			  new List<int> { BronzeShield, IronShield, BronzeHelm, IronHelm, CopperCuirass, KenpoGi, CottonRobe, BronzeArmor, IronArmor, SilverSpecs },
			  new List<int> { MythrilShield, PlumedHat, MythrilHelm, SilverPlate, SilkRobe, MythrilArmor, MythrilGloves, SilverArmlet, ElvenMantle },
			  new List<int> { GreenBeret, NinjaSuit, SagesSurplice, GoldenArmor },
			  new List<int> { },
			  new List<int> { GoldenShield, WizardsHat, GoldenHelm, GaiaGear, ThiefsGloves, AngelRing, FlameRing, CoralRing },
			  new List<int> { HypnoCrown, Headband, PowerSash, BoneMail, Gauntlets, PowerArmlet, KornagoGourd },
			  new List<int> { DiamondShield, TigerMask, SagesMiter, DiamondHelm, AngelRobe, DiamondPlate, LuminousRobe, DiamondArmor, DiamondArmlet, ReflectRing },
			  new List<int> { AegisShield, FlameShield, IceShield, LamiasTiara, GoldHairpin, Ribbon, Thornlet, BlackRobe, WhiteRobe, GenjiGloves, ProtectRing, CursedRing },
			  new List<int> { CrystalShield, BlackCowl, Circlet, CrystalHelm, GenjiHelm, MirageVest, BlackGarb, CrystalArmor, HermesSandals, KaiserKnuckles },
			  new List<int> { },
			  new List<int> { GenjiShield, RainbowDress, GenjiArmor, TitansGloves, RedSlippers }
		};

		public void adjustPrices(string directory, int multiplier, int divisor)
		{
			List<singleArmor> records;

			using (StreamReader reader = new StreamReader(Path.Combine("csv", "armor.csv")))
			using (CsvReader csv = new CsvReader(reader, System.Globalization.CultureInfo.InvariantCulture))
				records = csv.GetRecords<singleArmor>().ToList();

			foreach (singleArmor item in records)
			{
				item.buy *= multiplier;
				item.buy /= divisor;
				item.sell *= Math.Min(multiplier, 4);
				item.sell /= divisor;

				item.buy = item.buy > 99999 ? 99999 : item.buy < 1 ? 1 : item.buy;
				item.sell = item.sell > 99999 ? 99999 : item.sell < 1 ? 1 : item.sell;
			}

			using (StreamWriter writer = new StreamWriter(Path.Combine(directory, "armor.csv")))
			using (CsvWriter csv = new CsvWriter(writer, System.Globalization.CultureInfo.InvariantCulture))
			{
				csv.WriteRecords(records);
			}
		}

		public int selectItem(Random r1, int minTier, int maxTier)
		{
			minTier = Math.Min(minTier, 10);
			maxTier = Math.Min(maxTier, 12);
			List<int> selection = new List<int>();
			for (int i = minTier - 1; i <= maxTier - 1; i++)
				selection.AddRange(tiers[i]);

			return selection[r1.Next() % selection.Count];
		}
	}
}
