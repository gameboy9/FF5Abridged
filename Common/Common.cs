namespace FF5Abridged.Common
{
	static class Common
	{
        public static void Shuffle<T>(this IList<T> list, Random rng)
        {
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }

        public static bool AreAnyDuplicates<T>(this IEnumerable<T> list)
        {
            var hashset = new HashSet<T>();
            return list.Any(e => !hashset.Add(e));
        }

        public static double statAdjust(Random r1, double minimum, double middle, double maximum)
		{
            if (minimum == middle && middle == maximum) return middle;

            int direction = (minimum == middle) ? 1 : (maximum == middle) ? 0 : r1.Next() % 2;

            int numRolls = 2;
            long sumRolls = 0;
            for (int i = 0; i < numRolls; i++)
                sumRolls += r1.Next();
            long avgRolls = sumRolls / numRolls;

            if (direction == 0)
                return middle - ((middle - minimum) * ((double)Math.Abs(avgRolls - (int.MaxValue / 2)) / (int.MaxValue / 2)));
			else
                return middle + ((maximum - middle) * ((double)Math.Abs(avgRolls - (int.MaxValue / 2)) / (int.MaxValue / 2)));
        }
    }
}
