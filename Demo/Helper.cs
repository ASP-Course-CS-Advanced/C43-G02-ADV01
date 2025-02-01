using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal static class Helper<T> where T : IEquatable<T>
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

        #region 1st overload LinearSearch(T[] arr, T value) - use Equals() that defines inside the type T [Which compare equaliity basd on one full state].

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

        #region 2nd overload LinearSearch(T[] arr, T value, IEqualityComparer<T> equalityComparer) - use Equals() that defines inside the type that the reference from Interface IEquallityComparer<T> refer to [Which compare equaliity basd on one factor not full state]. 

        public static int LinearSearch(T[] arr, T value, IEqualityComparer<T> equalityComparer)
        {
            if (arr?.Length > 0 && value is not null)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if (equalityComparer.Equals(value,arr[i]))
                        return i;
                }
            }
            return -1;
        }

        #endregion

        #region 3rd overload LinearSearch(T[] arr, T value, func<T,T,bool> equals) - use delegate to compare based on specific value only not full state.

        public static int LinearSearch(T[] arr, T value, Func<T,T,bool> equals)
        {
            if (arr?.Length > 0 && value is not null)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if (equals(value, arr[i]))
                        return i;
                }
            }
            return -1;
        }

        #endregion

        #endregion


        #endregion

    }
}
