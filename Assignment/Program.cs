using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Metrics;

namespace Assignment
{
    internal class Program
    {

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

        #region Q06 - Given a string, find the first non-repeated character in it and return its index.If there is no such character, return -1.

        public static int FirstNonRepeatedChar(string str)
        {
            Dictionary<char, int> charCount = new Dictionary<char, int>();

            foreach (char c in str)
            {
                if (charCount.ContainsKey(c))
                    charCount[c]++;
                else
                    charCount[c] = 1;
            }

            for (int i = 0; i < str.Length; i++)
            {
                if (charCount[str[i]] == 1)
                    return i;
            }

            return -1;
        }

        #endregion

        static void Main(string[] args)
        {

            #region Q01 - The Bubble Sort algorithm has a time complexity of O(n^2) in its worst and average cases

            //int[] arr = { 64, 34, 25, 12, 22, 11, 90 };
            //Helper<int>.OptimizedBubbleSort(arr);

            //foreach (int num in arr)
            //{
            //    Console.Write(num+" ");// 11 12 22 25 34 64 90
            //}

            #endregion

            #region Q02 - create a generic Range<T> class that represents a range of values from a minimum value to a maximum value
            
            //Range02<int> range02 = new Range02<int>(10, 20);

            //if (range02.IsInRange(15))
            //    Console.WriteLine($"In Range.");
            //else
            //    Console.WriteLine("Not In Range.");

            //Console.WriteLine(range02.Length());// 10 

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

            #region Q06 - Given a string, find the first non-repeated character in it and return its index.If there is no such character, return -1.

            //string s = "swiss";
            //int index = FirstNonRepeatedChar(s);

            //Console.WriteLine($"first non-repeated character is: ({s[index]}), at index: {index}");

            #endregion


        }
    }
}
