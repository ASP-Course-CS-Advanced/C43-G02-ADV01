using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal static class Helper<T> 
    {

        #region Part 01 Generics - SWAP Example
        
        #region Non Generic Swap() - Abuse The Overload Concept

        //public static void Swap(ref int x, ref int y)
        //{
        //    int z = x;
        //    x = y;
        //    y = z;
        //}

        //public static void Swap(ref double x, ref double y)
        //{
        //    double z = x;
        //    x = y;
        //    y = z;
        //}

        //public static void Swap(ref Point x, ref Point y)
        //{
        //    Point z = x;
        //    x = y;
        //    y = z;
        //} 

        #endregion

        #region object Swap(object x, object y) - Cause Boxing&UnBoxing if the passed parameter is of type valueType.

        //public static void Swap(ref object x,ref object y)
        //{
        //    object z = x;
        //    x = y;
        //    y = z;
        //}

        #endregion

        #region Generic Swap<T>() - Perfect

        public static void Swap<T>(ref T x, ref T y)
        {
            T z = x;
            x = y;
            y = z;
        }

        #endregion

        #endregion

        #region Part 02 Generics - LinearSearch Exmaple

        #region NonGeneric LinearSearch  -  LinearSearch(int[] arr, int value)

        //public static int LinearSearch(int[] arr, int value)
        //{
        //    if (arr?.Length > 0)
        //    {
        //        for (int i = 0; i < arr.Length; i++)
        //        {
        //            if (value == arr[i])
        //                return i;
        //        }
        //    }
        //    return -1;// if arr is null || not found index of the value.
        //} 

        #endregion

        #region Generic LinearSearch  -  LinearSearch(T[] arr, T value)

        public static int LinearSearch(T[] arr, T value)
        {
            if (arr?.Length > 0 && value is not null)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if (value.Equals(arr[i]))
                        return i;
                }
            }
            return -1;
        }

        #endregion


        #endregion

    }
}
