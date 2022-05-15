using CsvHelper;
using FF5Abridged.Inventory;
using Newtonsoft.Json;
using FF5Abridged.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FF5Abridged.Randomize
{
	public class Monster
	{
		private class singleMonster
		{
			public int id { get; set; }
			public string mes_id_name { get; set; }
			public int cursor_x_position { get; set; }
			public int cursor_y_position { get; set; }
			public int in_type_id { get; set; }
			public int disappear_type_id { get; set; }
			public int species { get; set; }
			public int resistance_attribute { get; set; }
			public int resistance_condition { get; set; }
			public int initial_condition { get; set; }
			public int lv { get; set; }
			public int hp { get; set; }
			public int mp { get; set; }
			public int exp { get; set; }
			public int gill { get; set; }
			public int attack_count { get; set; }
			public int attack_plus { get; set; }
			public int attack_plus_grop { get; set; }
			public int attack_attribute { get; set; }
			public int strength { get; set; }
			public int vitality { get; set; }
			public int agility { get; set; }
			public int intelligence { get; set; }
			public int spirit { get; set; }
			public int magic { get; set; }
			public int attack { get; set; }
			public int ability_attack { get; set; }
			public int defense { get; set; }
			public int ability_defense { get; set; }
			public int ability_defense_rate { get; set; }
			public int accuracy_rate { get; set; }
			public int dodge_times { get; set; }
			public int evasion_rate { get; set; }
			public int magic_evasion_rate { get; set; }
			public int ability_disturbed_rate { get; set; }
			public int critical_rate { get; set; }
			public int luck { get; set; }
			public int weight { get; set; }
			public int boss { get; set; }
			public int monster_flag_group_id { get; set; }
			public int drop_rate { get; set; }
			public int drop_content_id1 { get; set; }
			public int drop_content_id1_value { get; set; }
			public int drop_content_id2 { get; set; }
			public int drop_content_id2_value { get; set; }
			public int drop_content_id3 { get; set; }
			public int drop_content_id3_value { get; set; }
			public int drop_content_id4 { get; set; }
			public int drop_content_id4_value { get; set; }
			public int drop_content_id5 { get; set; }
			public int drop_content_id5_value { get; set; }
			public int drop_content_id6 { get; set; }
			public int drop_content_id6_value { get; set; }
			public int drop_content_id7 { get; set; }
			public int drop_content_id7_value { get; set; }
			public int drop_content_id8 { get; set; }
			public int drop_content_id8_value { get; set; }
			public int steal_content_id1 { get; set; }
			public int steal_content_id2 { get; set; }
			public int steal_content_id3 { get; set; }
			public int steal_content_id4 { get; set; }
			public int script_id { get; set; }
			public int monster_asset_id { get; set; }
			public int battle_effect_asset_id { get; set; }
			public int p_use_ability_random_group_id { get; set; }
			public int command_group_type { get; set; }
			public int release_ability_random_group_id { get; set; }
			public int rage_ability_random_group_id { get; set; }
		}

		private class singleGroup
		{
			public int id { get; set; }
			public int battle_background_asset_id { get; set; }
			public int battle_bgm_asset_id { get; set; }
			public int appearance_production { get; set; }
			public int script_name { get; set; }
			public int battle_pattern1 { get; set; }
			public int battle_pattern2 { get; set; }
			public int battle_pattern3 { get; set; }
			public int battle_pattern4 { get; set; }
			public int battle_pattern5 { get; set; }
			public int battle_pattern6 { get; set; }
			public int not_escape { get; set; }
			public int battle_flag_group_id { get; set; }
			public int get_value { get; set; }
			public int get_ap { get; set; }
			public int monster1 { get; set; }
			public int monster1_x_position { get; set; }
			public int monster1_y_position { get; set; }
			public int monster1_group { get; set; }
			public int monster2 { get; set; }
			public int monster2_x_position { get; set; }
			public int monster2_y_position { get; set; }
			public int monster2_group { get; set; }
			public int monster3 { get; set; }
			public int monster3_x_position { get; set; }
			public int monster3_y_position { get; set; }
			public int monster3_group { get; set; }
			public int monster4 { get; set; }
			public int monster4_x_position { get; set; }
			public int monster4_y_position { get; set; }
			public int monster4_group { get; set; }
			public int monster5 { get; set; }
			public int monster5_x_position { get; set; }
			public int monster5_y_position { get; set; }
			public int monster5_group { get; set; }
			public int monster6 { get; set; }
			public int monster6_x_position { get; set; }
			public int monster6_y_position { get; set; }
			public int monster6_group { get; set; }
			public int monster7 { get; set; }
			public int monster7_x_position { get; set; }
			public int monster7_y_position { get; set; }
			public int monster7_group { get; set; }
			public int monster8 { get; set; }
			public int monster8_x_position { get; set; }
			public int monster8_y_position { get; set; }
			public int monster8_group { get; set; }
			public int monster9 { get; set; }
			public int monster9_x_position { get; set; }
			public int monster9_y_position { get; set; }
			public int monster9_group { get; set; }
		}

		private class singleSet
		{
			public int id { get; set; }
			public int monster_set1 { get; set; }
			public int monster_set1_rate { get; set; }
			public int monster_set2 { get; set; }
			public int monster_set2_rate { get; set; }
			public int monster_set3 { get; set; }
			public int monster_set3_rate { get; set; }
			public int monster_set4 { get; set; }
			public int monster_set4_rate { get; set; }
			public int monster_set5 { get; set; }
			public int monster_set5_rate { get; set; }
			public int monster_set6 { get; set; }
			public int monster_set6_rate { get; set; }
			public int monster_set7 { get; set; }
			public int monster_set7_rate { get; set; }
			public int monster_set8 { get; set; }
			public int monster_set8_rate { get; set; }
			public int monster_set9 { get; set; }
			public int monster_set9_rate { get; set; }
			public int monster_set10 { get; set; }
			public int monster_set10_rate { get; set; }
			public int monster_set11 { get; set; }
			public int monster_set11_rate { get; set; }
			public int monster_set12 { get; set; }
			public int monster_set12_rate { get; set; }
			public int monster_set13 { get; set; }
			public int monster_set13_rate { get; set; }
			public int monster_set14 { get; set; }
			public int monster_set14_rate { get; set; }
			public int monster_set15 { get; set; }
			public int monster_set15_rate { get; set; }
			public int monster_set16 { get; set; }
			public int monster_set16_rate { get; set; }
		}

		private class singleMap
		{
			public int id { get; set; }
			public string map_name { get; set; }
			public string asset_name { get; set; }
			public string map_title { get; set; }
			public int script_id { get; set; }
			public int bgm_id { get; set; }
			public int reverb_flag { get; set; }
			public int environmental_se_id { get; set; }
			public int required_steps_min { get; set; }
			public int required_steps_max { get; set; }
			public int subtract_steps { get; set; }
			public int monster_set_id { get; set; }
			public int encount_area_grid_id { get; set; }
			public int encount_effect_id { get; set; }
			public int area_id { get; set; }
			public int loop_type { get; set; }
			public int moving_availability { get; set; }
			public int sleeping_availability { get; set; }
			public int save_availability { get; set; }
			public int floor { get; set; }
		}

		public Monster(Random r1, int monsterRandoLevel, string csvDirectory, string mapDirectory, decimal xpBoost, decimal gpBoost, decimal apBoost, bool bossXP)
		{
			List<List<int>> randomMonsterSetTiers = new List<List<int>>
			{
				new List<int> { 2, 5, 9, 91, 92, 90, 93, 94, 95, 96, 97, 98, 99, 100, 101 }, // W1-Super Early
				new List<int> { 6, 7, 10, 12, 102, 103, 104, 105, 106, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117 }, // 11 skipped.  That's random encounter Garula.
				new List<int> { 3, 4, 8, 21, 22, 119, 120, 121, 122, 123, 124 },
				new List<int> { 13, 14, 15, 17, 18, 24, 25, 26, 27 },
				new List<int> { 1, 16, 23, 36, 50, 51, 52, 53, 127, 128, 129, 130, 131, 132 },
				new List<int> { 29, 30, 37, 38, 41, 43, 46, 47, 48, 49, 133, 134 }, // W2-Early
				new List<int> { 31, 33, 34, 35, 42, 144, 145, 146, 147, 148, 149, 150, 151, 152, 161, 162, 163, 164, 165, 166, 167, 168, 169, 170 },
				new List<int> { 28, 32, 39, 44, 59, 60, 65, 66, 75, 135, 136, 137, 138, 139, 140, 141, 142, 143, 171, 172, 173, 174, 175, 176, 177, 178, 179 },
				new List<int> { 61, 67, 68, 69, 70, 72, 73, 74, 81, 82, 180, 181, 182, 183, 184, 185, 186, 187, 188, 189, 190, 191, 192, 193 }, // W3-Early
				new List<int> { 54, 55, 56, 57, 58, 62, 63, 64, 194, 195, 196, 197, 198, 199, 200, 201, 202, 203, 204, 205, 206, 207, 208, 209, 210, 211, 212, 213 },
				new List<int> { 76, 77, 78, 79, 80, 83, 84, 85, 86, 87, 88, 89, 214, 215, 216, 217, 218, 219, 220, 221, 222, 223, 224 },
				new List<int> { 225, 226, 227, 228, 229, 230, 231, 232, 233, 234, 235, 236, 237, 238, 239, 240, 241, 242, 243, 244, 245 }
			};

			// 440 = Wing Raptor (W1-Super Early) - 200 XP / 300 GP
			// 441 = Karlabos (W1-Super Early) - 300 XP / 500 GP
			// 442 = Siren (W1-Super Early) - 500 XP / 600 GP
			// 443 = Magissa (W1-Early) - 600 XP / 750 GP
			// 444 = Garula (W1-Early) - 1600 XP / 900 GP
			// 445 = Liquid Flame (W1-Mid) - 1600 XP / 1300 GP
			// 446 = Sergeant/Cur Nakk -> Iron Claw (W1-Mid)
			// 495 = Ifrit (W1-Mid) - 1800 XP / 1400 GP
			// 447 = Byblos (W1-Mid) - 2100 XP / 1500 GP
			// 448 = Sandworm (W1-Mid) - 3500 XP / 1900 GP
			// 498 = Shiva/Ice Commander (W1-Mid) - 700 XP + 100 XP / 800 GP + 100 GP
			// 507 = Cray Claw (W1-Mid-Late) - 2000 XP / 1000 GP
			// 449 = Adamantoise (W1-Mid-late) - 3000 XP / 2000 GP
			// 452 = Soul Cannon (W1-Mid-late) - 2000 XP / 1000 GP
			// 453 = Archeoaevis (W1-Mid-late) - 5000 XP / 2000 GP
			// 77 = Ramuh (W1-Late) - 5500 XP / 1800 GP
			// 454 = Chimera Brain (W1-Late) - 10000 XP / 2000 GP
			// 455 = Titan (W1-Late) - 6000 XP / 1000 GP
			// 456 = Purobolos x 6 (W1-Late) - 1000 XP / 200 GP each
			// 457 = Abductor (W2-Early) - 2000 XP / 500 GP
			// 458 = Gilgamesh 1 (W2-Early) - 1000 XP / 2500 GP
			// 465 = Gilgamesh 2 (W2-Early) - 3000 XP / 2000 GP
			// 466 = Tyrannosaur (W2-Early) - 6000 XP / 2700 GP
			// 467 = Abductor (W2-Early) - 3000 XP / 1000 GP
			// 468 = Dragon Pod (W2-Mid) - 12000 XP / 3600 GP
			// 469 = Gilgamesh 3 (W2-Mid) - 5000 XP / 1500 GP
			// 470 = Atomos (W2-Mid) - 8000 XP / 3200 GP
			// 166 = Shoat/Catoblepas (W2-Late) - 6000 XP / 3000 GP
			// 471 = ??? (Thing/Crystals) (W2-Late) - 2500 XP / 1400 GP each
			// 472 = Carbuncle (W2-Late) - 10000 XP / 3000 GP
			// 473 = Gilgamesh 4 (W2-Late) - 10000 XP / 3000 GP
			// 496 = Exdeath 1 (W2-Late) - 20000 XP / 5000 GP
			// 145 = Sekhmet (W3-Early) - 4000 XP / 2000 GP
			// 151 = Exdeath's Soul (W3-Early) - 10000 XP / 5000 GP
			// 475 = Antlion (W3-Early) - 10000 XP / 5000 GP
			// 483 = Gargoyle (W3-Early) - 6000 XP / 3000 GP each
			// 481 = Melusine (W3-Early) - 12000 XP / 4700 GP
			// 589 = Pantera (W3-Early) - 16000 XP / 5100 GP
			// 590 = Covert (W3-Early) - 16000 XP / 5100 GP
			// 406 = Gilgamesh 5? - 5000 XP / 2500 GP
			// 489 = Gogo (W3-Mid) - 8000 XP / 4000 GP
			// 482 = Odin (W3-Mid) - 5000 XP / 2000 GP
			// 484 = Triton/Nereid/Phobos (W3-Mid) - 5000 XP / 1750 GP each
			// 485 = Omniscient (W3-Mid) - 9000 XP / 4800 GP
			// 486 = Minotaur (W3-Mid) - 11000 XP / 5000 GP
			// 488 = Wendigo (W3-Mid) - 4000 XP / 1000 GP each
			// 487 = Leviathan (W3-Late) - 13000 XP / 5400 GP
			// 490 = Bahamut (W3-Late) - 15000 XP / 6000 GP
			// 479 = Halicarnassus (W3-Rift) - 12000 XP / 5700 GP
			// 499 = Calofisteri (W3-Rift) - 15000 XP / 5900 GP
			// 500 = Azulmagia (W3-Rift) - 18000 XP / 6100 GP
			// 501 = Catastrophe (W3-Rift) - 20000 XP / 6300 GP
			// 502 = Necrophobe / 4x Barrier (W3-Rift) - 25000 XP / 7000 GP
			// 503 = Twintania (W3-Rift) - 22000 XP / 6500 GP
			// 505 = Apanda (W3-Rift) - 16000 XP / 6000 GP
			// 508 = Alte Roite (W3-Rift) - 18000 XP / 6100 GP
			// 519 = Jura Aevis (W3-Rift) - 18000 XP / 6100 GP
			// 504 = Exdeath 2 (W3-Rift) - 0 XP / 0 GP
			List<List<int>> BossTiers = new List<List<int>>
			{
				new List<int> { 440, 441, 442 }, // W1-Super Early
				new List<int> { 443, 444 },
				new List<int> { 445, 446, 495, 447, 448, 498 },
				new List<int> { 507, 449, 452, 453, 77 },
				new List<int> { 454, 455, 456, 457, 458 },
				new List<int> { 465, 466, 467 }, // W2-Early
				new List<int> { 468, 469, 470 },
				new List<int> { 166, 471, 472, 473, 496 },
				new List<int> { 145, 151, 475, 483, 481, 589, 590, 406 }, // W3-Early
				new List<int> { 489, 482, 484, 485, 486, 488 },
				new List<int> { 487, 490, 479, 499, 500, 501, 502, 503, 505, 508, 519 },
				new List<int> { 504 }
			};

			List<int> townBGMs = new List<int> { 1, 4, 9, 10, 14, 15, 19, 20, 24, 25, 27, 28, 29, 30, 31, 35, 38, 39, 40, 42, 43, 45 };
			List<int> battleBGMs = new List<int> { 2, 3, 5, 6, 12, 13, 16, 17, 18, 21, 22, 26, 29, 33, 34, 35, 36, 37, 40, 41, 44, 45, 46, 47, 48, 49 };

			List<int> selector = new List<int>();
			selector.Add(0); // Always include the opening music in the opening area.
			List<int> townBGMSelector = new List<int>();

			while (selector.Count < 12)
			{
				int bgm = r1.Next() % townBGMs.Count;
				if (!selector.Contains(bgm)) // Do not duplicate music
					selector.Add(bgm);
			}				
			selector.Sort();
			foreach (int i in selector)
				townBGMSelector.Add(townBGMs[i]);

			selector = new List<int>();
			selector.Add(16); // The Big Bridge music has to exist in at least 1 area.

			List<int> battleBGMSelector = new List<int>();

			while (selector.Count < 12)
			{
				int bgm = r1.Next() % battleBGMs.Count;
				if (!selector.Contains(bgm)) // Do not duplicate music
					selector.Add(bgm);
			}
			selector.Sort();

			bool gilgamesh = false;
			foreach (int i in selector)
			{
				if (!gilgamesh && battleBGMs[i] >= 36)
				{
					gilgamesh = true;
					battleBGMSelector.Add(36);
				} else
				{
					battleBGMSelector.Add(battleBGMs[i]);
				}
			}

			List<singleMonster> monsters = new List<singleMonster>();

			using (StreamReader reader = new StreamReader(Path.Combine(csvDirectory, "monster.csv")))
			using (CsvReader csv = new CsvReader(reader, System.Globalization.CultureInfo.InvariantCulture))
				monsters = csv.GetRecords<singleMonster>().ToList();

			foreach(singleMonster monster in monsters)
			{
				switch (monster.id)
				{
					case 19: monster.exp = 1600; monster.gill = 900; break; // Garula (random)
					case 33: monster.exp = 2100; monster.gill = 1500; break; // Byblos
					case 40: monster.exp = 5500; monster.gill = 1800; break; // Ramuh
					case 54: monster.exp = 1800; monster.gill = 1400; break; // Ifrit
					case 115: monster.exp = 6000; monster.gill = 3000; break; // Catoblepas
					case 139: monster.exp = 300; monster.gill = 414; break; // Pao
					case 145: monster.exp = 4000; monster.gill = 2000; break; // Sekhmet
					case 151: monster.exp = 10000; monster.gill = 5000; break; // Exdeath's Soul
					case 202: monster.exp = 5000; monster.gill = 1000; break; // King Behemoth
					case 204: monster.exp = 2000; monster.gill = 1000; break; // Necromancer
					case 208: monster.exp = 3000; monster.gill = 900; break; // Gorgimera
					case 210: monster.exp = 2400; monster.gill = 800; break; // Mindflayer
					case 212: monster.exp = 1000; monster.gill = 2000; break; // Crystelle
					case 213: monster.exp = 1000; monster.gill = 50000; break; // Mover
					case 214: monster.exp = 5500; monster.gill = 10000; break; // Crystal Dragon
					case 217: monster.exp = 2000; monster.gill = 1000; break; // Gilgamesh
					case 221: monster.exp = 1000; monster.gill = 1000; break; // Corbett
					case 222: monster.exp = 600; monster.gill = 740; break; // Nix
					case 223: monster.exp = 290; monster.gill = 680; break; // Water Scorpion
					case 224: monster.exp = 3000; monster.gill = 10000; break; // Vilia
					case 225: monster.exp = 450; monster.gill = 540; break; // Gel Fish
					case 226: monster.exp = 1500; monster.gill = 5000; break; // Rukh
					case 227: monster.exp = 1100; monster.gill = 3000; break; // Sea Devil
					case 228: monster.exp = 8000; monster.gill = 0; break; // Stingray
					case 280: monster.exp = 1600; monster.gill = 600; break; // Mecha Head
					case 281: monster.exp = 200; monster.gill = 300; break; // Wing Raptor
					case 282: monster.exp = 200; monster.gill = 300; break; // Wing Raptor
					case 283: monster.exp = 300; monster.gill = 500; break; // Karlabos
					case 284: monster.exp = 22000; monster.gill = 6500; break; // Twintania
					case 285: monster.exp = 500; monster.gill = 600; break; // Siren
					case 286: monster.exp = 500; monster.gill = 600; break; // Siren
					case 287: monster.exp = 300; monster.gill = 375; break; // Forza
					case 288: monster.exp = 300; monster.gill = 375; break; // Magissa
					case 289: monster.exp = 1600; monster.gill = 900; break; // Garula (boss)
					case 290: monster.exp = 1600; monster.gill = 1300; break; // Liquid Flame
					case 291: monster.exp = 1600; monster.gill = 1300; break; // Liquid Flame
					case 292: monster.exp = 1600; monster.gill = 1300; break; // Liquid Flame
					case 293: monster.exp = 100; monster.gill = 100; break; // Ice Commander
					case 294: monster.exp = 3500; monster.gill = 1900; break; // Sandworm
					case 296: monster.exp = 3000; monster.gill = 2000; break; // Adamantoise
					case 297: monster.exp = 300; monster.gill = 300; break; // Flame Thrower
					case 298: monster.exp = 310; monster.gill = 310; break; // Rocket Launcher
					case 300: monster.exp = 2000; monster.gill = 1000; break; // Soul Cannon
					case 301: monster.exp = 1000; monster.gill = 400; break; // Archeoaevis
					case 302: monster.exp = 1000; monster.gill = 400; break; // Archeoaevis
					case 303: monster.exp = 1000; monster.gill = 400; break; // Archeoaevis
					case 304: monster.exp = 1000; monster.gill = 400; break; // Archeoaevis
					case 305: monster.exp = 1000; monster.gill = 400; break; // Archeoaevis
					case 306: monster.exp = 6000; monster.gill = 1000; break; // Chimera Brain
					case 307: monster.exp = 6000; monster.gill = 1000; break; // Titan
					case 308: monster.exp = 1000; monster.gill = 200; break; // Purobolos
					case 309: monster.exp = 2000; monster.gill = 500; break; // Abductor 1
					case 310: monster.exp = 1000; monster.gill = 2500; break; // Gilgamesh 1
					case 315: monster.exp = 3000; monster.gill = 2000; break; // Gilgamesh 2
					case 316: monster.exp = 6000; monster.gill = 2700; break; // Tyrannosaur
					case 317: monster.exp = 700; monster.gill = 800; break; // Shiva
					case 318: monster.exp = 3000; monster.gill = 1000; break; // Abductor
					case 319: monster.exp = 12000; monster.gill = 3600; break; // Dragon Pod
					case 325: monster.exp = 3333; monster.gill = 533; break; // Gilgamesh 3
					case 326: monster.exp = 1667; monster.gill = 167; break; // Enkidu
					case 327: monster.exp = 8000; monster.gill = 3200; break; // Atomos
					case 328: monster.exp = 2500; monster.gill = 1400; break; // Tree Crystal
					case 329: monster.exp = 2500; monster.gill = 1400; break; // Tree Crystal
					case 330: monster.exp = 2500; monster.gill = 1400; break; // Tree Crystal
					case 331: monster.exp = 2500; monster.gill = 1400; break; // Tree Crystal
					case 332: monster.exp = 10000; monster.gill = 3000; break; // Carbuncle
					case 334: monster.exp = 8888; monster.gill = 888; break; // Gilgamesh 4
					case 335: monster.exp = 20000; monster.gill = 5000; break; // Exdeath 1
					case 336: monster.exp = 6000; monster.gill = 3000; break; // Antlion
					case 337: monster.exp = 800; monster.gill = 500; break; // Mummy
					case 339: monster.exp = 2250; monster.gill = 700; break; // Mecha Head
					case 340: monster.exp = 12000; monster.gill = 4700; break; // Melusine
					case 341: monster.exp = 12000; monster.gill = 4700; break; // Melusine
					case 342: monster.exp = 12000; monster.gill = 4700; break; // Melusine
					case 343: monster.exp = 12000; monster.gill = 4700; break; // Melusine
					case 344: monster.exp = 5000; monster.gill = 2000; break; // Odin
					case 345: monster.exp = 4000; monster.gill = 1700; break; // Gargoyle
					case 346: monster.exp = 5000; monster.gill = 1750; break; // Triton
					case 347: monster.exp = 5000; monster.gill = 1750; break; // Nereid
					case 348: monster.exp = 5000; monster.gill = 1750; break; // Phobos
					case 349: monster.exp = 9000; monster.gill = 4800; break; // Omniscient
					case 350: monster.exp = 11000; monster.gill = 5000; break; // Minotaur
					case 351: monster.exp = 13000; monster.gill = 5400; break; // Leviathan
					case 352: monster.exp = 4000; monster.gill = 1000; break; // Wendigo
					case 353: monster.exp = 8000; monster.gill = 4000; break; // Gogo
					case 354: monster.exp = 15000; monster.gill = 6000; break; // Bahamut
					case 355: monster.exp = 18000; monster.gill = 6100; break; // Jura Aevis
					case 356: monster.exp = 12000; monster.gill = 5700; break; // Halicarnassus
					case 364: monster.exp = 2000; monster.gill = 1000; break; // Cray Claw
					case 366: monster.exp = 15000; monster.gill = 5900; break; // Calofisteri
					case 367: monster.exp = 18000; monster.gill = 6100; break; // Azulmagia
					case 368: monster.exp = 20000; monster.gill = 6300; break; // Catastrophe
					case 369: monster.exp = 25000; monster.gill = 7000; break; // Necrophobe
					case 370: monster.exp = 22000; monster.gill = 6500; break; // Twintania
					case 375: monster.exp = 5000; monster.gill = 2000; break; // Grand Mummy
					case 376: monster.exp = 16000; monster.gill = 6000; break; // Apanda
					case 377: monster.exp = 18000; monster.gill = 6100; break; // Alte Roite
				}

				monster.exp = (int)(monster.exp * xpBoost * (decimal)Common.Common.statAdjust(r1, 0.5, 1.0, 2.0));
				monster.gill = (int)(monster.gill * xpBoost * (decimal)Common.Common.statAdjust(r1, 0.5, 1.0, 2.0));
			}

			List<singleGroup> monsterGroups = new List<singleGroup>();
			using (StreamReader reader = new StreamReader(Path.Combine(csvDirectory, "monster_party.csv")))
			using (CsvReader csv = new CsvReader(reader, System.Globalization.CultureInfo.InvariantCulture))
				monsterGroups = csv.GetRecords<singleGroup>().ToList();

			foreach (singleGroup group in monsterGroups)
			{
				group.get_ap = (int)(group.get_ap * apBoost * (decimal)Common.Common.statAdjust(r1, 0.5, 1.0, 2.0));
				group.battle_bgm_asset_id = (group.id == 458 || group.id == 465 || group.id == 469 || group.id == 473 || group.id == 406) ? 37 :
					(group.id == 496 || group.id == 504) ? 50 : 0; // 37 for Gilgamesh, 50 for ExDeath.  Otherwise, maintain currently playing music
				group.battle_flag_group_id = (group.id == 496 || group.id == 504) ? group.battle_flag_group_id : 3; // Continue the music on victory except ExDeath.
			}

			if (monsterRandoLevel == 0)
			{
				selector = new List<int>();
				for (int i = 0; i < 12; i++)
					selector.Add(randomMonsterSetTiers[i][r1.Next() % randomMonsterSetTiers[i].Count()]);

				List<singleMap> maps;

				using (StreamReader reader = new StreamReader(Path.Combine(csvDirectory, "map.csv")))
				using (CsvReader csv = new CsvReader(reader, System.Globalization.CultureInfo.InvariantCulture))
					maps = csv.GetRecords<singleMap>().ToList();

				int[] mapIDs = new int[] { 320, 30, 40, 48, 54, 70, 95, 118, 123, 129, 130, 136 };

				for (int i = 0; i < 12; i++)
				{
					singleMap sMap = maps.Where(c => c.id == mapIDs[i]).Single();
					sMap.required_steps_min = 75;
					sMap.required_steps_max = 75;
					sMap.subtract_steps = 5;
					sMap.monster_set_id = selector[i];
					sMap.bgm_id = battleBGMSelector[i];
				}

				mapIDs = new int[] { 321, 38, 31, 32, 33, 34, 35, 36, 37, 39, 41, 42 };
				for (int i = 0; i < 12; i++)
				{
					singleMap sMap = maps.Where(c => c.id == mapIDs[i]).Single();
					sMap.bgm_id = townBGMSelector[i];
				}

				using (StreamWriter writer = new StreamWriter(Path.Combine(csvDirectory, "map.csv")))
				using (CsvWriter csv = new CsvWriter(writer, System.Globalization.CultureInfo.InvariantCulture))
				{
					csv.WriteRecords(maps);
				}

				selector = new List<int>();
				for (int i = 0; i < 12; i++)
					selector.Add(BossTiers[i][r1.Next() % BossTiers[i].Count()]);

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
					"Map_20120\\Map_20120\\sc_e_0057.json",
					"Map_20130\\Map_20130\\sc_e_0094.json"};


				int k = 0;
				foreach (string script in scripts)
				{
					List<int> rewards = new List<int>();
					string json = File.ReadAllText(Path.Combine(mapDirectory, script));
					EventJSON jEvents = JsonConvert.DeserializeObject<EventJSON>(json);
					foreach (var singleScript in jEvents.Mnemonics)
					{
						if (singleScript.mnemonic == "EncountBoss")
							singleScript.operands.iValues[0] = selector[k];
					}

					JsonSerializer serializer = new JsonSerializer();

					using (StreamWriter sw = new StreamWriter(Path.Combine(mapDirectory, script)))
					using (JsonWriter writer = new JsonTextWriter(sw))
					{
						serializer.Serialize(writer, jEvents);
					}

					k++;
				}
			}

			using (StreamWriter writer = new StreamWriter(Path.Combine(csvDirectory, "monster.csv")))
			using (CsvWriter csv = new CsvWriter(writer, System.Globalization.CultureInfo.InvariantCulture))
			{
				csv.WriteRecords(monsters);
			}

			using (StreamWriter writer = new StreamWriter(Path.Combine(csvDirectory, "monster_party.csv")))
			using (CsvWriter csv = new CsvWriter(writer, System.Globalization.CultureInfo.InvariantCulture))
			{
				csv.WriteRecords(monsterGroups);
			}

		}
	}
}
