namespace Assignment
{
    internal class Program
    {

        #region Q01 - The Bubble Sort algorithm has a time complexity of O(n^2) in its worst and average cases

        public static void BubbleSortV02(int[] arr)
        {
            int length = arr.Length;
            bool isSwapped;
            for (int i = 0; i < length - 1; i++)
            {
                isSwapped = false;
                for (int j = 0; j < length - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                        isSwapped = true;
                    }
                }
                // If no elements were swapped, the array is already sorted
                if (!isSwapped)
                    break;
            }
        }

            #endregion

            static void Main(string[] args)
        {

            #region Q01 - The Bubble Sort algorithm has a time complexity of O(n^2) in its worst and average cases

            //int[] arr = { 64, 34, 25, 12, 22, 11, 90 };
            //BubbleSortV02(arr);

            //foreach (int num in arr)
            //{
            //    Console.Write(num+" ");
            //}

            #endregion

        }
    }
}
