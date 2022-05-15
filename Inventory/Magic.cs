using CsvHelper;
using FF5Abridged.Common;

namespace FF5Abridged.Inventory
{
	public class Magic
	{
		public const int Cure = 374; // T1
		public const int Libra = 375; // T1
		public const int Poisona = 376; // T1
		public const int Silence = 377; // T2
		public const int Protect = 378; // T2
		public const int Mini = 379; // T2
		public const int Cura = 380; // T3
		public const int Raise = 381; // T3
		public const int Confuse = 382; // T3
		public const int Blink = 383; // T4
		public const int Shell = 384; // T4
		public const int Esuna = 385; // T4
		public const int Curaga = 386; // T5
		public const int Reflect = 387; // T5
		public const int Berserk = 388; // T5
		public const int Arise = 389; // T6
		public const int Holy = 390; // T6
		public const int Dispel = 391; // T6
		public const int Fire = 392; // T1
		public const int Blizzard = 393; // T1
		public const int Thunder = 394; // T1
		public const int Poison = 395; // T2
		public const int Sleep = 396; // T2
		public const int Toad = 397; // T2
		public const int Fira = 398; // T3
		public const int Blizzara = 399; // T3
		public const int Thundara = 400; // T3
		public const int Drain = 401; // T4
		public const int Break = 402; // T4
		public const int Bio = 403; // T4
		public const int Firaga = 404; // T5
		public const int Blizzaga = 405; // T5
		public const int Thundaga = 406; // T5
		public const int Flare = 407; // T6
		public const int Death = 408; // T6
		public const int Osmose = 409; // T6
		public const int Speed = 410; // T1
		public const int Slow = 411; // T1
		public const int Regen = 412; // T1
		public const int Mute = 413; // T2
		public const int Haste = 414; // T2
		public const int Float = 415; // T2
		public const int Gravity = 416; // T3
		public const int Stop = 417; // T3
		public const int Teleport = 418; // T3
		public const int Comet = 419; // T4
		public const int Slowga = 420; // T4
		public const int Return = 421; // T4
		public const int Graviga = 422; // T5
		public const int Hastega = 423; // T5
		public const int Old = 424; // T5
		public const int Meteor = 425; // T6
		public const int Quick = 426; // T6
		public const int Banish = 427; // T6
		public const int Chocobo = 428; // T2
		public const int Sylph = 429; // T2
		public const int Remora = 430; // T2
		public const int Shiva = 431; // T3
		public const int Ramuh = 432; // T3
		public const int Ifrit = 433; // T3
		public const int Titan = 434; // T4
		public const int Golem = 435; // T4
		public const int Catoblepas = 436; // T4
		public const int Carbuncle = 437; // T5
		public const int Syldra = 438; // T5
		public const int Odin = 439; // T5
		public const int Phoenix = 440; // T6
		public const int Leviathan = 441; // T6
		public const int Bahamut = 442; // T6
		public const int SinewyEtude = 461; // T3
		public const int SwiftSong = 462; // T3
		public const int MightyMarch = 463; // T4
		public const int ManasPaean = 464; // T4
		public const int HerosRime = 465; // T5
		public const int Requiem = 466; // T5
		public const int RomeosBallad = 467; // T6
		public const int AlluringAir = 468; // T6
		public const int Doom = 649; // T3
		public const int Roulette = 650; // T4
		public const int AquaBreath = 651; // T4
		public const int Level5Death = 652; // T5
		public const int Level4Graviga = 653; // T2
		public const int Level2Old = 654; // T4
		public const int Level3Flare = 655; // T4
		public const int PondsChorus = 656; // T2
		public const int LilliputianLyric = 657; // T2
		public const int Flash = 658; // T1
		public const int TimeSlip = 659; // T3
		public const int MoonFlute = 660; // T4
		public const int DeathClaw = 661; // T6
		public const int Aero = 662; // T1
		public const int Aera = 663; // T3
		public const int Aeroga = 664; // T5
		public const int FlameThrower = 665; // T3
		public const int GoblinPunch = 666; // T1
		public const int DarkSpark = 667; // T4
		public const int OffGuard = 668; // T2
		public const int Transfusion = 669; // T3
		public const int MindBlast = 670; // T5
		public const int Vampire = 671; // T3
		public const int MagicHammer = 672; // T1
		public const int MightyGuard = 673; // T5
		public const int SelfDestruct = 674; // T3
		public const int QuestionMark = 675; // T3
		public const int Needles1000 = 676; // T4
		public const int WhiteWind = 677; // T4
		public const int Missile = 678; // T3

		public List<List<int>> tiers = new List<List<int>>
			{ new List<int> { Cure, Libra, Poisona, Fire, Blizzard, Thunder, Speed, Slow, Regen, Flash, Aero, GoblinPunch, MagicHammer },
			  new List<int> {  },
			  new List<int> { Silence, Protect, Mini, Poison, Sleep, Toad, Mute, Haste, Float, Chocobo, Sylph, Remora, Level4Graviga, PondsChorus, LilliputianLyric, OffGuard },
			  new List<int> {  },
			  new List<int> { Cura, Raise, Confuse, Fira, Blizzara, Thundara, Gravity, Stop, Teleport, Shiva, Ramuh, Ifrit, SinewyEtude, SwiftSong, Doom, TimeSlip, Aera, FlameThrower, Transfusion, Vampire, SelfDestruct, QuestionMark, Missile },
			  new List<int> {  },
			  new List<int> { Blink, Shell, Esuna, Drain, Break, Bio, Comet, Slowga, Return, Titan, Golem, Catoblepas, MightyMarch, ManasPaean, Roulette, AquaBreath, Level2Old, Level3Flare, MoonFlute, DarkSpark, Needles1000, WhiteWind },
			  new List<int> {  },
			  new List<int> { Curaga, Reflect, Berserk, Firaga, Blizzaga, Thundaga, Graviga, Hastega, Old, Carbuncle, Syldra, Odin, HerosRime, Requiem, Level5Death, Aeroga, MindBlast, MightyGuard },
			  new List<int> {  },
			  new List<int> { Arise, Holy, Dispel, Flare, Death, Osmose, Meteor, Banish, Quick, Phoenix, Leviathan, Bahamut, RomeosBallad, AlluringAir, DeathClaw },
			  new List<int> {  }
		};

		private class ability
		{
			public int id { get; set; }
			public int sort_id { get; set; }
			public int ability_lv { get; set; }
			public int ability_group_id { get; set; }
			public int type_id { get; set; }
			public int attribute_id { get; set; }
			public int attribute_group_id { get; set; }
			public int system_id { get; set; }
			public int use_value { get; set; }
			public int standard_value { get; set; }
			public int adding_hit_rate { get; set; }
			public int valid_hit_rate { get; set; }
			public int weak_hit_rate { get; set; }
			public int attack_count { get; set; }
			public int accuracy_rate { get; set; }
			public int Impact_status { get; set; }
			public int use_job_group_id { get; set; }
			public int condition_group_id { get; set; }
			public int renge_id { get; set; }
			public int menu_renge_id { get; set; }
			public int battle_renge_id { get; set; }
			public int content_flag_group_id { get; set; }
			public int invalid_reflection { get; set; }
			public int invalid_boss { get; set; }
			public int resistance_attribute { get; set; }
			public int battle_effect_asset_id { get; set; }
			public int menu_se_asset_id { get; set; }
			public int reaction_type { get; set; }
			public int menu_function_group_id { get; set; }
			public int battle_function_group_id { get; set; }
			public int buy { get; set; }
			public int sell { get; set; }
			public int sales_not_possible { get; set; }
			public int ability_wait { get; set; }
			public string process_prog { get; set; }
			public int data_a { get; set; }
			public int data_b { get; set; }
			public int data_c { get; set; }
		}

		public void adjustPrices(string directory, int multiplier, int divisor)
		{
			List<ability> records;

			using (StreamReader reader = new StreamReader(Path.Combine("csv", "weapon.csv")))
			using (CsvReader csv = new CsvReader(reader, System.Globalization.CultureInfo.InvariantCulture))
				records = csv.GetRecords<ability>().ToList();

			foreach (ability item in records)
			{
				item.buy *= multiplier;
				item.buy /= divisor;
				item.sell *= Math.Min(multiplier, 4);
				item.sell /= divisor;

				item.buy = item.buy > 99999 ? 99999 : item.buy < 1 ? 1 : item.buy;
				item.sell = item.sell > 99999 ? 99999 : item.sell < 1 ? 1 : item.sell;
			}

			using (StreamWriter writer = new StreamWriter(Path.Combine(directory, "weapon.csv")))
			using (CsvWriter csv = new CsvWriter(writer, System.Globalization.CultureInfo.InvariantCulture))
			{
				csv.WriteRecords(records);
			}
		}

		public int selectItem(Random r1, int minTier, int maxTier)
		{
			minTier = Math.Min(minTier, 11);
			maxTier = Math.Min(maxTier, 11);
			List<int> selection = new List<int>();
			for (int i = minTier - 1; i <= maxTier - 1; i++)
				selection.AddRange(tiers[i]);

			if (selection.Count == 0)
				return -1;

			return selection[r1.Next() % selection.Count];
		}
	}
}
