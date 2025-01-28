using System.Collections;
using System.Collections.Generic;

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

        #region Q03 - You are given an ArrayList containing a sequence of elements.

        public static void ReverseArrayList(ArrayList list)
        {
            int left = 0;
            int right = list.Count - 1;
            while (left < right)
            {
                // Swap elements
                object temp = list[left];
                list[left] = list[right];
                list[right] = temp;
                left++;
                right--;
            }
        }

        #endregion

        #region Q04 - You are given a list of integers. Your task is to find and return a new list containing only the even numbers from the given list.


        public static List<int> EvenNumbersInList(List<int> numbers)
        {
            List<int> evenNumbers = new List<int>();

            foreach (int num in numbers)
            {
                if (num % 2 == 0)
                {
                    evenNumbers.Add(num);
                }
            }

            return evenNumbers;
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

            #region Q02 - create a generic Range<T> class that represents a range of values from a minimum value to a maximum value.

            //Range<int> intRange = new Range<int>(5, 10);

            //Console.WriteLine(intRange.IsInRange(15));
            //Console.WriteLine(intRange.Length());

            #endregion

            #region Q03 - You are given an ArrayList containing a sequence of elements.

            //ArrayList arr = new ArrayList { 1, 2, 3, 4, 5 };
            //ReverseArrayList(arr);

            //foreach (int num in arr)
            //{
            //    Console.Write(num+" ");
            //}

            #endregion

            #region Q04 - You are given a list of integers. Your task is to find and return a new list containing only the even numbers from the given list.

            //List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //List<int> evenNumbers = EvenNumbersInList(numbers);

            //foreach (int num in evenNumbers)
            //{
            //    Console.Write(num + " ");
            //}

            #endregion

            #region Q05 - implement a custom list called FixedSizeList<T> with a predetermined capacity.

            //FixedList<int> fixedList = new FixedList<int>(3);

            //fixedList.Add(10);
            //fixedList.Add(20);
            //fixedList.Add(30);

            //Console.WriteLine(fixedList.Get(1));

            #endregion

        }
    }
}
