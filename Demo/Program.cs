namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Part 01 Generics - SWAP Example

            #region 01.1 - Non Generic Swap() - Abuse The Overload Concept

            #region Swap(ref int x, ref int y)

            //int x = 5, y = 10;
            //Console.WriteLine($"x = {x}");// x = 5
            //Console.WriteLine($"y = {y}");// y = 10

            //Helper.Swap(ref x, ref y);
            //Console.WriteLine("==== After Swap === ");

            //Console.WriteLine($"x = {x}");// x = 10
            //Console.WriteLine($"y = {y}");// y = 5

            #endregion

            #region Swap(ref double x, ref double y)

            //double x = 3.4, y = 5.2;
            //Console.WriteLine($"x = {x}");// x = 3.4
            //Console.WriteLine($"y = {y}");// y = 5.2

            //Helper.Swap(ref x, ref y);
            //Console.WriteLine("==== After Swap === ");

            //Console.WriteLine($"x = {x}");// x = 5.2
            //Console.WriteLine($"y = {y}");// y = 3.4

            #endregion

            #region Swap(ref Point x, ref Point y)

            //Point p01 = new Point(5, 4);
            //Point p02 = new Point(3, 2);

            //Console.WriteLine($"p01 = {p01}");// p01 = (5,4)
            //Console.WriteLine($"p02 = {p02}");// p02 = (3,2)

            //Helper.Swap(ref p01, ref p02);
            //Console.WriteLine("==== After Swap === ");

            //Console.WriteLine($"p01 = {p01}");// p01 = (3,2)
            //Console.WriteLine($"p02 = {p02}");// p02 = (5,4)

            #endregion

            #endregion

            #region 01.2 - object  - Cause Boxing&UnBoxing if the passed parameter is of type valueType.

            #region Swap(ref object x, ref object y) - Swap(5,10) - integers

            //object x = 5, y = 10;
            //Console.WriteLine($"x = {x}");// x = 5
            //Console.WriteLine($"y = {y}");// y = 10

            //Helper.Swap(ref x, ref y);
            //Console.WriteLine("==== After Swap === ");

            //Console.WriteLine($"x = {x}");// x = 10
            //Console.WriteLine($"y = {y}");// y = 5 

            #endregion

            #region Swap(ref object x, ref object y) - Swap(3,4,5,2) - doubles

            //object x = 3.4, y = 5.2;
            //Console.WriteLine($"x = {x}");// x = 3.4
            //Console.WriteLine($"y = {y}");// y = 5.2

            //Helper.Swap(ref x, ref y);
            //Console.WriteLine("==== After Swap === ");

            //Console.WriteLine($"x = {x}");// x = 5.2
            //Console.WriteLine($"y = {y}");// y = 3.4

            #endregion

            #region Swap(ref object x, ref object y) - Swap(new Point(10,20), new Point(60,40)) - Points

            //object p01 = new Point(10, 20);
            //object p02 = new Point(60,40);
            //Console.WriteLine($"p01 = {p01}");// p01 = (10,20)
            //Console.WriteLine($"p02 = {p02}");// p02 = (60,40)

            //Helper.Swap(ref p01, ref p02);
            //Console.WriteLine("==== After Swap === ");

            //Console.WriteLine($"p01 = {p01}");// p01 = (60,40)
            //Console.WriteLine($"p02 = {p02}");// p02 = (10,20)

            #endregion

            #endregion

            #region 01.3 - Generic Swap<T>() - Perfect [No any Propblems]

            #region Helper.Swap<int>(ref x, ref y);

            //int x = 5, y = 10;
            //Console.WriteLine($"x = {x}");// x = 5
            //Console.WriteLine($"y = {y}");// y = 10

            //Helper.Swap/*<int>*/(ref x, ref y);
            //Console.WriteLine("==== After Swap === ");

            //Console.WriteLine($"x = {x}");// x = 10
            //Console.WriteLine($"y = {y}");// y = 5 

            #endregion

            #region Helper.Swap<double>(ref x, ref y);

            //double x = 2.3, y = 3.4;
            //Console.WriteLine($"x = {x}");// x = 2.3
            //Console.WriteLine($"y = {y}");// y = 3.4

            //Helper.Swap/*<double>*/(ref x, ref y);
            //Console.WriteLine("==== After Swap === ");

            //Console.WriteLine($"x = {x}");// x = 3.4
            //Console.WriteLine($"y = {y}");// y = 2.3 

            #endregion

            #region Helper.Swap<Point>(ref p01, ref p02);

            Point p01 = new Point(10, 20);
            Point p02 = new Point(60, 40);
            Console.WriteLine($"p01 = {p01}");// p01 = (10,20)
            Console.WriteLine($"p02 = {p02}");// p02 = (60,40)

            Helper.Swap/*<Point>*/(ref p01, ref p02);
            Console.WriteLine("==== After Swap === ");

            Console.WriteLine($"p01 = {p01}");// p01 = (60,40)
            Console.WriteLine($"p02 = {p02}");// p02 = (10,20)

            #endregion

            #endregion

            #endregion

        }
    }
}
