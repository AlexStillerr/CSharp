

public static class ListExtensions
{
	private static Random random = new Random();

	public static void Shuffle<T>(this List<T> list)
	{
		Random rnd = new Random();
		int listIndex = list.Count;

		while (listIndex > 0)
		{
			listIndex--;
			int swap = rnd.Next(listIndex +1);
			(list[listIndex], list[swap]) = (list[swap], list[listIndex]);
		}
	}
}