using System;

namespace EXERCICESLINQ
{
    public static class Extensions
    {
        public static int CompterPair(this int[] data)
        {
            int count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] % 2 == 0)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
