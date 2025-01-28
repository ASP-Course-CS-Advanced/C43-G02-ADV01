using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class Range<T> where T : IComparable<T>
    {

        #region Properties
        
        public T Min { get; set; }
        public T Max { get; set; }

        #endregion

        #region Constructors
        
        public Range(T min, T max)
        {
            if (min.CompareTo(max) > 0)
                throw new ArgumentException("Min must be less than or equal to Max.");
            Min = min;
            Max = max;
        }

        #endregion

        #region Methods
        
        public bool IsInRange(T value)
        {
            return value.CompareTo(Min) >= 0 && value.CompareTo(Max) <= 0;
        }

        public dynamic Length()
        {
            if (typeof(T) == typeof(int) || typeof(T) == typeof(double) || typeof(T) == typeof(float))
            {
                return (dynamic)Max - (dynamic)Min;
            }
            return $"Can't Apply Operations on this type!" ;
        }

        #endregion

    }
}
