using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal static class Helper/*<T>*/
    {

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

        public static void Swap<T>(ref T x,ref T y)
        {
            T z = x;
            x = y;
            y = z;
        }

        #endregion

    }
}
