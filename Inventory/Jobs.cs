namespace FF5Abridged.Inventory
{
	public class Jobs
	{
		Random r1;
		List<int> jobsAcquired;

		public Jobs(Random pRandom)
		{
			r1 = pRandom;
			jobsAcquired = new List<int>();
		}

		public int getJob()
		{
			bool jobDuplicate = true;
			int dupsAllowed = 10;
			int finalJob = -1;
			while (jobDuplicate && dupsAllowed > 0)
			{
				finalJob = (r1.Next() % 21) + 2;
				jobDuplicate = jobsAcquired.Contains(finalJob);
				dupsAllowed--;
			}
			if (!jobDuplicate)
				jobsAcquired.Add(finalJob);
			else
				finalJob = -1;

			return finalJob;
		}

		public string jobToString(int job)
		{
			switch (job)
			{
				case 2: return "ジョブ開放：ナイト"; // Knight
				case 3: return "ジョブ開放：モンク"; // Monk
				case 4: return "ジョブ開放：シーフ"; // Thief
				case 5: return "ジョブ開放：竜騎士"; // Dragoon
				case 6: return "ジョブ開放：忍者"; // Ninja
				case 7: return "ジョブ開放：侍"; // Samurai
				case 8: return "ジョブ開放：バーサーカー"; // Berzerker
				case 9: return "ジョブ開放：狩人"; // Ranger
				case 10: return "ジョブ開放：魔法剣士"; // Mystic Knight
				case 11: return "ジョブ開放：白魔道士"; // White Mage
				case 12: return "ジョブ開放：黒魔道士"; // Black Mage
				case 13: return "ジョブ開放：時魔道士"; // Time Mage
				case 14: return "ジョブ開放：召喚士"; // Summoner
				case 15: return "ジョブ開放：青魔道士"; // Blue Mage
				case 16: return "ジョブ開放：赤魔道士"; // Red Mage
				case 17: return "ジョブ開放：魔獣使い"; // Beastmaster
				case 18: return "ジョブ開放：薬師"; // Chemist
				case 19: return "ジョブ開放：風水師"; // Geomancer
				case 20: return "ジョブ開放：吟遊詩人"; // Bard
				case 21: return "ジョブ開放：踊り子"; // Dancer
				case 22: return "ジョブ開放：ものまね師"; // Mime
				default: return "";
			}
		}
	}
}
