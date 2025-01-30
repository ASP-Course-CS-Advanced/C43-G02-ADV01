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

            //Point p01 = new Point(10, 20);
            //Point p02 = new Point(60, 40);
            //Console.WriteLine($"p01 = {p01}");// p01 = (10,20)
            //Console.WriteLine($"p02 = {p02}");// p02 = (60,40)

            //Helper.Swap/*<Point>*/(ref p01, ref p02);
            //Console.WriteLine("==== After Swap === ");

            //Console.WriteLine($"p01 = {p01}");// p01 = (60,40)
            //Console.WriteLine($"p02 = {p02}");// p02 = (10,20)

            #endregion

            #endregion

            #endregion

            #region Part 02 Generics - LinearSearch Exmaple

            #region NonGeneric LinearSearch  -  Helper.LinearSearch(int[] arr, int value)

            //int[] arr = new int[] { 10, 5, 4, 7, 9, 8, 6 };
            //int index = Helper.LinearSearch(arr, 8);

            //Console.WriteLine(index);// 5 

            #endregion

            #region Generic LinearSearch  -  Helper<T>LinearSearch(T[] arr, T value)

            #region Part01 - Solve Proplems.

            #region Add new behavior to (==) operator to let it compare between two objects of struct Employee. 

            //Employee emp01 = new Employee() { Id = 10, Name = new string("Eslam"), Salary = 8000 };
            //Employee emp02 = new Employee() { Id = 10, Name = new string("Eslam"), Salary = 8000 };

            //if (emp01 == emp02)
            //    Console.WriteLine("Equals!");// Equals!
            //else
            //    Console.WriteLine("Not Equals!"); 

            #endregion

            #region Use Equals() method that struct Employee inherit it from ValueType class (ValueType inherit it from object and let it compare states of two objects not addresses) - instead of use == and make overload to it

            //Employee emp01 = new Employee() { Id = 10, Name = new string("Eslam"), Salary = 8000 };
            //Employee emp02 = new Employee() { Id = 10, Name = new string("Eslam"), Salary = 8000 };

            //if (emp01.Equals(emp02))
            //    Console.WriteLine("Equals!");// Equals!
            //else
            //    Console.WriteLine("Not Equals!");

            #endregion

            #region Use Equals() method that class Employee02 inherit it from object class that compare addresses of two objects but i override it inside Employee02 class to make it compare states of two objects.

            //Employee02 emp01 = new Employee02() { Id = 10, Name = new string("Eslam"), Salary = 8000 };
            //Employee02 emp02 = new Employee02() { Id = 10, Name = new string("Eslam"), Salary = 8000 };

            //Console.WriteLine($"{emp01.GetHashCode()}");// 2120548586
            //Console.WriteLine($"{emp02.GetHashCode()}");// 2120548586 

            //// Have The Same HashCode - Because I override the GetHashCode() method inside "Employee02" clas s to make it generate the hashCode based on the state of object not the address
            //// If the two objects has the same state [they will have the same hash code].

            //if (emp01.Equals(emp02))
            //    Console.WriteLine("Equals!");// Equals!
            //else
            //    Console.WriteLine("Not Equals!");

            #endregion

            #region Use == method that class Employee02 default implement it that compare Addresses of two objects.

            //Employee02 emp01 = new Employee02() { Id = 10, Name = new string("Eslam"), Salary = 8000 };
            //Employee02 emp02 = new Employee02() { Id = 10, Name = new string("Eslam"), Salary = 8000 };

            //if (emp01 == emp02)
            //    Console.WriteLine("Equals!");
            //else
            //    Console.WriteLine("Not Equals!");// Not Equals! [emp01 hold address of object and emp02 hold address of different object]

            #endregion

            #endregion

            #region Part02 - Generic LinearSearch  -  Helper<T>LinearSearch(T[] arr, T value)

            #region Example01 - Search Inside Array of Integers - Helper<int>.LinearSearch(arr, 8)

            //int[] arr = new int[] { 10, 5, 4, 7, 9, 8, 6 };
            //int index = Helper<int>.LinearSearch(arr, 8);

            //Console.WriteLine(index);// 5  

            #endregion

            #region Example02 - Search Inside Array of Employee02 - Helper<Employee02>.LinearSearch(employees, new Employee02() { Id = 20, Name = "Ahmed", Salary = 4000 })

            //Employee02[] employees = new Employee02[]
            //  {
            //    new Employee02(){Id = 10,Name = "Eslam",Salary = 8000},
            //    new Employee02(){Id = 20,Name = "Ahmed",Salary = 4000},
            //    new Employee02(){Id = 30,Name = "Omnia",Salary = 6000}
            //  };

            //Employee02 searchEmployee = new Employee02() { Id = 20, Name = "Ahmed", Salary = 4000 };
            //int index = Helper<Employee02>.LinearSearch(employees, searchEmployee);

            //Console.WriteLine(index);// 1

            #endregion

            #endregion


            #endregion

            #endregion

            #region Part 03 Equals() and GetHashCode()

            #region In Case That override Equals() &  not override GetHashCode().

            //Employee02 emp01 = new Employee02() { Id = 10, Name = "Ahmed", Salary = 8000 };
            //Employee02 emp02 = new Employee02() { Id = 10, Name = "Ahmed", Salary = 8000 };

            //Console.WriteLine(emp01.GetHashCode());// 54267293
            //Console.WriteLine(emp02.GetHashCode());// 18643596

            //Console.WriteLine(emp01.Equals(emp02));//true

            //HashSet<Employee02> employeeSet = new HashSet<Employee02>();
            //employeeSet.Add(emp01);
            //employeeSet.Add(emp02);

            //foreach (Employee02 employee in employeeSet)
            //{
            //    Console.WriteLine(employee);// Id: 10, Name: Ahmed, Salary: 8000
            //}                               // Id: 10, Name: Ahmed, Salary: 8000

            #endregion

            #region In Case That override Equals() & override GetHashCode().

            //Employee02 emp01 = new Employee02() { Id = 10, Name = "Ahmed", Salary = 8000 };
            //Employee02 emp02 = new Employee02() { Id = 10, Name = "Ahmed", Salary = 8000 };

            //Console.WriteLine(emp01.GetHashCode());// 384590876
            //Console.WriteLine(emp02.GetHashCode());// 384590876

            //Console.WriteLine(emp01.Equals(emp02));//true

            //HashSet<Employee02> employeeSet = new HashSet<Employee02>();
            //employeeSet.Add(emp01);
            //employeeSet.Add(emp02);

            //foreach (Employee02 employee in employeeSet)
            //{
            //    Console.WriteLine(employee);// Id: 10, Name: Ahmed, Salary: 8000
            //}                               

            #endregion

            #region Override GetHashCode() with implementation (return this.Id.GetHashCode() ^ this.Name?.GetHashCode() ?? default(int) ^ this.Salary.GetHashCode() ) -> Causing Collision

            //Employee02 emp01 = new Employee02() { Id = 10, Name = "Ahmed", Salary = 8000 }; 
            //Employee02 emp02 = new Employee02() { Id = 8000, Name = "Ahmed", Salary = 10 };

            //Console.WriteLine(emp01.Id.GetHashCode());    // 10 
            //Console.WriteLine(emp01.Name.GetHashCode());  // 1751769853 
            //Console.WriteLine(emp01.Salary.GetHashCode());// 8000 

            //Console.WriteLine(emp02.Id.GetHashCode());    // 8000 
            //Console.WriteLine(emp02.Name.GetHashCode());  // 1751769853 
            //Console.WriteLine(emp02.Salary.GetHashCode());// 10 

            //Console.WriteLine(emp01.Id.GetHashCode() + emp01.Name.GetHashCode() + emp01.Salary.GetHashCode());// (10 + 1751769853 + 8000) = 1751777863
            //Console.WriteLine(emp02.Id.GetHashCode() + emp02.Name.GetHashCode() + emp02.Salary.GetHashCode());// (8000 + 1751769853 + 10) = 1751777863

            #endregion

            #region Override GetHashCode() with Prime Number implementation | Not Cause Collision | Best Implementation

            //Employee02 emp01 = new Employee02() { Id = 10, Name = "Ahmed", Salary = 8000 };
            //Employee02 emp02 = new Employee02() { Id = 8000, Name = "Ahmed", Salary = 10 };

            //Console.WriteLine(emp01.GetHashCode());// -669456994
            //Console.WriteLine(emp02.GetHashCode());// -669839710

            #endregion

            #region Override GetHashCode() with HashCode.Combine() method | C#8.0 Feature.

            //Employee02 emp01 = new Employee02() { Id = 10, Name = "Ahmed", Salary = 8000 };
            //Employee02 emp02 = new Employee02() { Id = 8000, Name = "Ahmed", Salary = 10 };

            //Console.WriteLine(emp01.Equals(emp02));// False [Based on State/Data]

            //Console.WriteLine(emp01.GetHashCode());// 1891486132   [Based on State/Data]
            //Console.WriteLine(emp02.GetHashCode());// -1684315059  [Based on State/Data]

            #endregion

            #endregion

        }
    }
}
