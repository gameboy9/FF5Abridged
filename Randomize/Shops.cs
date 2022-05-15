using FF5Abridged.Inventory;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using static FF5Abridged.Common.Common;

namespace FF5Abridged.Randomize
{
	public class Shops
	{
		List<int> allStores = new List<int>
		{
			1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48
		};
		// Line order:  Weapons, Armor, Items, Magic
		List<int> stdMinTier = new List<int>
		{
			1, 1, 1, 1,
			1, 1, 1, 1,
			2, 2, 1, 3,
			3, 3, 1, 3,
			4, 4, 1, 5,
			5, 5, 1, 5,
			6, 6, 1, 7,
			7, 7, 1, 7,
			8, 8, 1, 9,
			9, 9, 1, 9,
			10, 10, 1, 11,
			10, 10, 1, 11
		};
		List<int> stdMaxTier = new List<int>
		{
			2, 2, 1, 2,
			3, 3, 2, 4,
			4, 4, 3, 6,
			5, 5, 4, 8,
			6, 6, 5, 8,
			7, 7, 6, 8,
			8, 8, 7, 10,
			9, 9, 8, 10,
			10, 10, 9, 10,
			11, 11, 10, 12,
			12, 12, 11, 12,
			12, 12, 11, 12
		};

		List<int> proMinTier = new List<int>
		{
			1, 1, 1, 1,
			1, 1, 1, 1,
			1, 1, 1, 1,
			2, 2, 1, 1,
			3, 3, 1, 3,
			4, 4, 1, 3,
			5, 5, 1, 5,
			6, 6, 1, 5,
			7, 7, 1, 7,
			8, 8, 1, 7,
			8, 8, 1, 7,
			9, 9, 1, 7,
		};
		List<int> proMaxTier = new List<int>
		{
			1, 1, 1, 2,
			2, 2, 1, 2,
			3, 3, 2, 4,
			4, 4, 3, 4,
			5, 5, 4, 6,
			6, 6, 5, 6,
			7, 7, 6, 8,
			8, 8, 7, 8,
			9, 9, 8, 10,
			10, 10, 9, 10,
			11, 11, 10, 12,
			11, 11, 10, 12
		};

		private class shopItem 
		{
			public int id;
			public int content_id; // Item
			public int group_id; // Store #
			public int coefficient = 0; // Inn/House of Healing cost
			public int purchase_limit = 0; // 0 = unlimited
		}

		private List<shopItem> determineItems(List<int> items, List<int> stores, Random r1)
		{
			List<shopItem> shopDB = new List<shopItem>();

			List<int> storeNumItems = new List<int>();
			bool duplicates = true;
			while (duplicates)
			{
				storeNumItems.Clear();
				for (int lnI = 0; lnI < stores.Count - 1; lnI++)
					storeNumItems.Add(r1.Next() % items.Count);
				storeNumItems.Add(items.Count);
				duplicates = storeNumItems.AreAnyDuplicates();
			}
			storeNumItems.Sort();
			for (int lnI = 0; lnI < items.Count; lnI++)
			{
				shopItem newItem = new shopItem();
				newItem.id = 0;
				newItem.group_id = stores[storeNumItems.Select((elem, index) => new { elem, index }).First(p => p.elem > lnI).index];
				newItem.content_id = items[lnI];
				shopDB.Add(newItem);
			}

			return shopDB;
		}

		public Shops(Random r1, int randoLevel, int freqLevel, string fileName)
		{
			List<shopItem> shopDB = new List<shopItem>();
			List<shopItem> shopWorking = new List<shopItem>();
			int id = 1;

			for (int i = 0; i < allStores.Count; i++)
			{
				shopWorking = new List<shopItem>();
				// Alternate between weapons, armor, and item stores, so each place has at least one of each.
				int itemType = allStores[i] % 4;
				int freq = (freqLevel == 0 ? 4 : freqLevel == 1 ? 8 : freqLevel == 2 ? 12 : freqLevel == 3 ? 16 : 20);
				for (int j = 0; j <= freq; j++)
				{
					shopItem newItem = new shopItem();
					newItem.group_id = allStores[i];
					newItem.id = id;
					int minTier = randoLevel <= 1 ? stdMinTier[i] : randoLevel == 2 ? proMinTier[i] : 1;
					int maxTier = randoLevel == 0 ? stdMaxTier[i] + 1 : randoLevel == 1 ? stdMaxTier[i] : randoLevel == 2 ? proMaxTier[i] : 9;

					// Alternate between weapons, armor, and item stores, so each place has at least one of each.
					switch (itemType)
					{
						case 0:
							newItem.content_id = new Inventory.Magic().selectItem(r1, minTier, maxTier);
							break;
						case 1:
							newItem.content_id = new Inventory.Weapons().selectItem(r1, minTier, maxTier);
							break;
						case 2:
							newItem.content_id = new Inventory.Armor().selectItem(r1, minTier, maxTier);
							break;
						case 3:
							newItem.content_id = new Inventory.Items().selectItem(r1, minTier, maxTier);
							break;
					}

					// Do not add if an item couldn't be found or if it's a duplicate.
					if (newItem.content_id != -1 && shopWorking.Where(c => c.content_id == newItem.content_id).Count() == 0)
					{
						shopWorking.Add(newItem);
						id++;
					}
				}

				//// The store after Upper Babil must have a hi-Potion(in case there are no white mages in the party) and a tent(in case you are forced to grind between gauntlets). (damage floors)
				//if (allStores[i] == upperBabil2 && shopWorking.Where(c => c.content_id == Inventory.Items.hiPotion).Count() == 0)
				//	shopWorking.Add(addManualItem(Inventory.Items.hiPotion, allStores[i], ref id));
				//if (allStores[i] == upperBabil2 && shopWorking.Where(c => c.content_id == Inventory.Items.tent).Count() == 0)
				//	shopWorking.Add(addManualItem(Inventory.Items.tent, allStores[i], ref id));
				//// The Crystal Palace must have an X-Potion(in case there are no white mages in the party), a Cottage(in case you are forced to grind between gauntlets) (Zeromus), and a Light Curtain (in case of Meganuke fights). 
				//if (allStores[i] == crystalPalace2 && shopWorking.Where(c => c.content_id == Inventory.Items.xPotion).Count() == 0)
				//	shopWorking.Add(addManualItem(Inventory.Items.xPotion, allStores[i], ref id));
				//if (allStores[i] == crystalPalace2 && shopWorking.Where(c => c.content_id == Inventory.Items.cottage).Count() == 0)
				//	shopWorking.Add(addManualItem(Inventory.Items.cottage, allStores[i], ref id));
				//if (allStores[i] == crystalPalace2 && shopWorking.Where(c => c.content_id == Inventory.Items.lightCurtain).Count() == 0)
				//	shopWorking.Add(addManualItem(Inventory.Items.lightCurtain, allStores[i], ref id));
				//if (allStores[i] == crystalPalace2 && shopWorking.Where(c => c.content_id == Inventory.Items.phoenixDown).Count() == 0)
				//	shopWorking.Add(addManualItem(Inventory.Items.phoenixDown, allStores[i], ref id));
				//if (mandatorySirens && itemType == 2 && shopWorking.Where(c => c.content_id == Inventory.Items.siren).Count() == 0)
				//	shopWorking.Add(addManualItem(Inventory.Items.siren, allStores[i], ref id));

				shopDB.AddRange(shopWorking.OrderBy(c => c.content_id));
			}

			using (StreamWriter sw = new StreamWriter(fileName))
			{
				sw.WriteLine("id,content_id,group_id,coefficient,purchase_limit");
				int finalID = 0;
				foreach (shopItem si in shopDB)
				{
					finalID++;
					sw.WriteLine(finalID + "," + si.content_id + "," + si.group_id + "," + si.coefficient + "," + si.purchase_limit);
				}
				finalID++;
				// Inn prices
				sw.WriteLine(finalID + ",0,101,10,0");  finalID++;
				sw.WriteLine(finalID + ",0,102,10,0");  finalID++;
				sw.WriteLine(finalID + ",0,103,10,0");  finalID++;
				sw.WriteLine(finalID + ",0,104,20,0");  finalID++;
				sw.WriteLine(finalID + ",0,105,40,0");  finalID++;
				sw.WriteLine(finalID + ",0,106,10,0");  finalID++;
				sw.WriteLine(finalID + ",0,107,100,0"); finalID++;
				sw.WriteLine(finalID + ",0,108,80,0");  finalID++;
				sw.WriteLine(finalID + ",0,109,100,0"); finalID++;
				sw.WriteLine(finalID + ",0,110,100,0"); finalID++;
				sw.WriteLine(finalID + ",0,111,60,0");  finalID++;
				sw.WriteLine(finalID + ",0,112,200,0"); finalID++;
			}
		}

		private shopItem addManualItem(int item, int group_id, ref int id)
        {
			shopItem newItem = new shopItem();
			newItem.group_id = group_id;
			newItem.id = id;
			newItem.content_id = item;
			id++;

			return newItem;
		}
	}
}
