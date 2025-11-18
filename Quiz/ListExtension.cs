using System;
using System.Collections.Generic;

namespace Quiz
{
    public static class ListExtension
    {
        public static void Shuffle<T>(this List<T> list, Random rnd = null)
        {
            if (list == null || list.Count == 0)
                return;

            if(rnd == null)
                rnd = new Random();

            for (int i =0; i < list.Count-1; ++i)
            {
                int j = rnd.Next(list.Count);
                ( list[i], list[j]) = (list[j], list[i]);
            }
        }
    }
}
