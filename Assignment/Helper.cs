using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal static class Helper<T> where T : IComparable<T>
    {

        #region Q01 - The Bubble Sort algorithm has a time complexity of O(n^2) in its worst and average cases

        public static void SWAP(ref T x, ref T y)
        {
            T z = x;
            x = y;
            y = z;
        }

        public static void OptimizedBubbleSort(T[] arr)
        {
            if (arr is null || arr.Length <= 0)
                return;
            for (int i = 0; i < arr.Length; i++)
            {
                bool Swapped = false;
                for (int j = 0; j < arr.Length - 1 - i; j++)
                {
                    if (arr[j].CompareTo(arr[j + 1]) == 1)
                        SWAP(ref arr[j], ref arr[j + 1]);
                    Swapped = true;
                }
                if (!Swapped)
                    break;
            }
        }

        #endregion

    }
}
