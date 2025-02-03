using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class Range02<T> where T : IComparable<T>
    {

        #region Q02 - create a generic Range<T> class that represents a range of values from a minimum value to a maximum value

        #region Properties

        public T Minimum { get; set; }
        public T Maximum { get; set; }

        #endregion

        #region Constructors

        public Range02(T min, T max)
        {
            this.Minimum = min;
            this.Maximum = max;
        }

        #endregion

        #region Methods

        public bool IsInRange(T value)
        {
            return value.CompareTo(this.Minimum) >= 0 && value.CompareTo(this.Maximum) <= 0;
        }

        public dynamic Length()
        {
            if (typeof(T) == typeof(int) || typeof(T) == typeof(double) || typeof(T) == typeof(float))
            {
                return (dynamic)Maximum - (dynamic)Minimum;
            }
            return $"Can't Apply Operations on this type!";
        }

        #endregion 

        #endregion

    }
}
