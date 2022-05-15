using CsvHelper;

namespace FF5Abridged.Inventory
{
	class Weapons
	{
		private class singleWeapon
		{
			public int id { get; set; }
			public string sort_id { get; set; }
			public int type_id { get; set; }
			public int category_type { get; set; }
			public int attribute_id { get; set; }
			public int attribute_group_id { get; set; }
			public int equip_job_group_id { get; set; }
			public int parts_group_id { get; set; }
			public int attack { get; set; }
			public int weight { get; set; }
			public int accuracy_rate { get; set; }
			public int evasion_rate { get; set; }
			public int ability_disturbed_rate { get; set; }
			public int destroy_rate { get; set; }
			public int magnetic_force { get; set; }
			public int throw_flag { get; set; }
			public int back_flag { get; set; }
			public int two_handed_flag { get; set; }
			public int invalid_reflection { get; set; }
			public int trigger_ability_id { get; set; }
			public int wear_function_group_id { get; set; }
			public int wear_condition_group_id { get; set; }
			public int weak_attribute { get; set; }
			public int effective_species { get; set; }
			public int additional_condition_group_id { get; set; }
			public int strength { get; set; }
			public int vitality  { get; set; }
			public int agility { get; set; }
			public int intelligence { get; set; }
			public int spirit { get; set; }
			public int magic { get; set; }
			public int critical_rate { get; set; }
			public int max_hp_up { get; set; }
			public int max_mp_up { get; set; }
			public int battle_equipment_asset_id { get; set; }
			public int battle_effect_asset_id { get; set; }
			public int guard_icon { get; set; }
			public int buy { get; set; }
			public int sell { get; set; }
			public int sales_not_possible { get; set; }
			public string process_prog { get; set; }
		}

		public const int Knife = 60; // T1
		public const int Dagger = 61; // T1
		public const int MythrilKnife = 62; // T2
		public const int MageMasher = 63; // T4
		public const int MainGauche = 64; // T4
		public const int OrichalcumDirk = 65; // T6
		public const int DancingDagger = 66; // T6
		public const int AirKnife = 67; // T7
		public const int ThiefKnife = 68; // T10
		public const int AssassinsDagger = 69; // T11
		public const int ManEater = 70; // T12
		public const int ChickenKnife = 72; // T8
		public const int Kunai = 73; // T3
		public const int Kodachi = 74; // T6
		public const int SasukesKatana = 75; // T11
		public const int Broadsword = 77; // T1
		public const int LongSword = 78; // T2
		public const int MythrilSword = 79; // T3
		public const int CoralSword = 80; // T4
		public const int AncientSword = 81; // T5
		public const int SleepBlade = 82; // T6
		public const int RuneBlade = 83; // T10
		public const int GreatSword = 84; // T6
		public const int Excalipoor = 85; // T8
		public const int Enhancer = 86; // T10
		public const int Flametongue = 88; // T8
		public const int Icebrand = 89; // T8
		public const int BloodSword = 90; // T9
		public const int Defender = 91; // T10
		public const int Excalibur = 92; // T11
		public const int Ragnarok = 93; // T12
		public const int BraveBlade = 95; // T11
		public const int Spear = 96; // T2
		public const int MythrilSpear = 97; // T3
		public const int Trident = 98; // T4
		public const int WindSpear = 99; // T6
		public const int HeavyLance = 100; // T7
		public const int Javelin = 101; // T7
		public const int TwinLance = 102; // T9
		public const int Partisan = 103; // T9
		public const int HolyLance = 104; // T11
		public const int DragonLance = 105; // T12
		public const int BattleAxe = 107; // T2
		public const int MythrilHammer = 108; // T3
		public const int OgreKiller = 109; // T4
		public const int WarHammer = 110; // T6
		public const int DeathSickle = 111; // T7
		public const int PoisonAxe = 112; // T7
		public const int GaiaHammer = 113; // T9
		public const int RuneAxe = 114; // T10
		public const int ThorsHammer = 115; // T11
		public const int TitansAxe = 116; // T11
		public const int Ashura = 118; // T4
		public const int WindSlash = 119; // T7
		public const int Osafune = 120; // T7
		public const int Kotetsu = 121; // T8
		public const int Kikuichimonji = 122; // T10
		public const int Murasame = 123; // T11
		public const int Masamune = 124; // T11
		public const int Murakumo = 125; // T12
		public const int Rod = 127; // T1
		public const int FlameRod = 128; // T3
		public const int FrostRod = 129; // T3
		public const int ThunderRod = 130; // T3
		public const int PoisonRod = 131; // T6
		public const int LilithRod = 132; // T12
		public const int MagusRod = 133; // T10
		public const int WonderWand = 134; // T10
		public const int Staff = 136; // T1
		public const int HealingStaff = 137; // T4
		public const int PowerStaff = 138; // T8
		public const int StaffOfLight = 139; // T11
		public const int SagesStaff = 140; // T10
		public const int JudgmentStaff = 141; // T11
		public const int Flail = 143; // T2
		public const int MorningStar = 144; // T10
		public const int SilverBow = 145; // T3
		public const int FlameBow = 146; // T4
		public const int FrostBow = 147; // T4
		public const int ThunderBow = 148; // T4
		public const int DarkBow = 149; // T6
		public const int MagicBow = 150; // T10
		public const int KillerBow = 151; // T6
		public const int ElvenBow = 152; // T8
		public const int HayateBow = 153; // T8
		public const int AevisKiller = 154; // T10
		public const int YoichisBow = 155; // T10
		public const int ArtemissBow = 156; // T11
		public const int SilverHarp = 158; // T3
		public const int DreamHarp = 159; // T6
		public const int LamiasHarp = 160; // T7
		public const int ApollosHarp = 161; // T10
		public const int Whip = 162; // T3
		public const int BlitzWhip = 163; // T4
		public const int ChainWhip = 164; // T6
		public const int BeastKiller = 165; // T9
		public const int FireLash = 166; // T10
		public const int DragonsWhisker = 167; // T11
		public const int DiamondBell = 168; // T3
		public const int GaiaBell = 169; // T10
		public const int RuneChime = 170; // T11
		public const int Tinklebell = 171; // T12
		public const int MoonringBlade = 172; // T4
		public const int RisingSun = 173; // T10

		public List<List<int>> tiers = new List<List<int>>
			{ new List<int> { Knife, Dagger, Rod, Staff, Broadsword },
			  new List<int> { Flail, MythrilKnife, LongSword, Spear, BattleAxe, Flail },
			  new List<int> { Kunai, MythrilSword, MythrilSpear, MythrilHammer, FlameRod, FrostRod, ThunderRod, SilverBow, SilverHarp, Whip, DiamondBell },
			  new List<int> { MageMasher, MainGauche, CoralSword, Trident, OgreKiller, Ashura, HealingStaff, FlameBow, FrostBow, ThunderBow, BlitzWhip, MoonringBlade, AncientSword },
			  new List<int> { },
			  new List<int> { OrichalcumDirk, DancingDagger, Kodachi, SleepBlade, GreatSword, WindSpear, WarHammer, PoisonRod, DarkBow, KillerBow, DreamHarp, ChainWhip },
			  new List<int> { AirKnife, HeavyLance, Javelin, DeathSickle, PoisonAxe, WindSlash, Osafune, LamiasHarp },
			  new List<int> { ChickenKnife, Excalipoor, Flametongue, Icebrand, Kotetsu, PowerStaff, ElvenBow, HayateBow },
			  new List<int> { BloodSword, TwinLance, Partisan, GaiaHammer, BeastKiller },
			  new List<int> { ThiefKnife, RuneBlade, Enhancer, Defender, RuneAxe, Kikuichimonji, MagusRod, WonderWand, SagesStaff, MorningStar, MagicBow, AevisKiller, YoichisBow, ApollosHarp, FireLash, GaiaBell, RisingSun },
			  new List<int> { AssassinsDagger, SasukesKatana, Excalibur, BraveBlade, HolyLance, ThorsHammer, TitansAxe, Murasame, Masamune, StaffOfLight, JudgmentStaff, ArtemissBow, DragonsWhisker, RuneChime },
			  new List<int> { ManEater, Ragnarok, DragonLance, Murakumo, LilithRod, Tinklebell }
		};

		public void adjustPrices(string directory, int multiplier, int divisor)
		{
			List<singleWeapon> records;

			using (StreamReader reader = new StreamReader(Path.Combine("csv", "weapon.csv")))
			using (CsvReader csv = new CsvReader(reader, System.Globalization.CultureInfo.InvariantCulture))
				records = csv.GetRecords<singleWeapon>().ToList();

			foreach (singleWeapon item in records)
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
			maxTier = Math.Min(maxTier, 12);

			List<int> selection = new List<int>();
			for (int i = minTier - 1; i <= maxTier - 1; i++)
				selection.AddRange(tiers[i]);

			if (selection.Count == 0)
				return -1;

			return selection[r1.Next() % selection.Count];
		}
	}
}
