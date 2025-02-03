using System.Runtime.CompilerServices;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Example01 - SWAP()

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

            #endregion

            #region Example02 - LinearSearch()

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

            #region Part 04 is and as Operators

            #region Example01 - Handle Equals() method - prevent thrown exception if casting fail by using "is" operator - if cast fail null returned. 

            //Employee02 employee02 = new Employee02() { Id = 10, Name = "Ahmed", Salary = 8000 };

            //Console.WriteLine(employee02.Equals("Ahmed"));// False [Not throw Exception].  

            #endregion

            #region Example02 - Handle Equals() method - prevent thrown exception if casting fail by using "as" operator - if cast fail null returned. 

            #region The Parameter of "t01.Equals(t02)" is object of type "Test" class that inherit from "Employee02".

            //Test t01 = new Test() { Id = 10, Name = "Eslam", Salary = 8000 };
            //Test t02 = new Test() { Id = 10, Name = "Eslam", Salary = 8000 };

            //Console.WriteLine(t01.Equals(t02));// true 

            #endregion

            #region The Parameter of "emp01.Equals(emp02)" is object of type "Employee02" class.

            //Employee02 emp01= new Test() { Id = 10, Name = "Eslam", Salary = 8000 };
            //Employee02 emp02 = new Test() { Id = 10, Name = "Eslam", Salary = 8000 };

            //Console.WriteLine(emp01.Equals("emp02"));// True 

            #endregion

            #region Not throw Exception if the parameter is not of type "Employee02" or of type class inherit from "Employee02".

            //Employee02 employee = new Employee02() { Id = 10, Name = "Ahmed", Salary = 8000 };
            //int num = 10;

            //Console.WriteLine(employee.Equals(num));// False [Not Thrown Exception].

            #endregion

            #endregion

            #endregion

            #region Part 05 IEqutable

            //Employee02[] employees = new Employee02[]
            //{
            //    new Employee02(){Id = 10, Name = "Ahmed", Salary = 8000},
            //    new Employee02(){Id = 30, Name = "Khalid", Salary = 3500},
            //    new Employee02(){Id = 80, Name = "Sameh", Salary = 10000},
            //    new Employee02(){Id = 90, Name = "Hind", Salary = 5000},
            //};

            //int index = Helper<Employee02>.LinearSearch(employees, new Employee02() { Id = 80, Name = "Sameh", Salary = 10000 });

            //if (index != -1)
            //    Console.WriteLine($"This Employee \"{employees[index].Name}\" => {employees[index]}\nFounded at index {index}");
            //else
            //    Console.WriteLine("NotFound!");

            //// This Employee "Sameh" => Id: 80, Name: Sameh, Salary: 10000
            //// Founded at index 2

            #endregion

            #endregion

            #region Part 06 IEqualityComparer

            #region Example01 - Search based on Name.

            //Employee02[] employees = new Employee02[]
            //{
            //    new Employee02(){Id = 10, Name = "Eslam", Salary = 8000},
            //    new Employee02(){Id = 20, Name = "Khalid", Salary = 4000},
            //    new Employee02(){Id = 30, Name = "Ahmed", Salary = 5000},
            //    new Employee02(){Id = 40, Name = "Omnia", Salary = 9000},
            //};

            //IEqualityComparer<Employee02> equalityComparerName = new EmployeeEqualityComparerName();
            //int index = Helper<Employee02>.LinearSearch(employees, new Employee02() { Name = "Khalid" }, equalityComparerName);

            //if (index != -1)
            //    Console.WriteLine($"Employee {employees[index].Name} => {employees[index]}\nFounded at index {index}");// Employee Khalid => Id: 20, Name: Khalid, Salary: 4000
            //else                                                                                                            // Founded at index 1
            //    Console.WriteLine("Not found!");

            #endregion

            #region Example02 - Search based on Salary.

            //Employee02[] employees = new Employee02[]
            //{
            //    new Employee02(){Id = 10, Name = "Eslam", Salary = 8000},
            //    new Employee02(){Id = 20, Name = "Khalid", Salary = 4000},
            //    new Employee02(){Id = 30, Name = "Ahmed", Salary = 5000},
            //    new Employee02(){Id = 40, Name = "Omnia", Salary = 9000},
            //};

            //IEqualityComparer<Employee02> equalityComparerSalary = new EmployeeEqualityComparerSalary();
            //int index = Helper<Employee02>.LinearSearch(employees, new Employee02() { Salary = 9000 }, equalityComparerSalary);

            //if (index != -1)
            //    Console.WriteLine($"Employee {employees[index].Name} => {employees[index]}\nFounded at index {index}");// Employee Omnia => Id: 40, Name: Omnia, Salary: 9000
            //else                                                                                                              // Founded at index 3
            //    Console.WriteLine("Not found!");

            #endregion

            #region Example03 - Search based on Id.

            //Employee02[] employees = new Employee02[]
            //{
            //    new Employee02(){Id = 10, Name = "Eslam", Salary = 8000},
            //    new Employee02(){Id = 20, Name = "Khalid", Salary = 4000},
            //    new Employee02(){Id = 30, Name = "Ahmed", Salary = 5000},
            //    new Employee02(){Id = 40, Name = "Omnia", Salary = 9000},
            //};

            //IEqualityComparer<Employee02> equalityComparerId = new EmployeeEqualityComparerId();
            //int index = Helper<Employee02>.LinearSearch(employees, new Employee02() { Id = 30 }, equalityComparerId);

            //if (index != -1)
            //    Console.WriteLine($"Employee {employees[index].Name} => {employees[index]}\nFounded at index {index}");// Employee Ahmed => Id: 30, Name: Ahmed, Salary: 5000
            //else                                                                                                          //  Founded at index 2
            //    Console.WriteLine("Not found!");

            #endregion

            #endregion

            #region Part 07 LinearSearch Using Delegate

            #region Example01 - Using Anonymous Method -  Example for compare Name.

            //Employee02[] employees = new Employee02[]
            //{
            //    new Employee02(){Id = 10, Name = "Eslam", Salary = 8000},
            //    new Employee02(){Id = 20, Name = "Khalid", Salary = 4000},
            //    new Employee02(){Id = 30, Name = "Ahmed", Salary = 5000},
            //    new Employee02(){Id = 40, Name = "Omnia", Salary = 9000},
            //};

            //int index = Helper<Employee02>.LinearSearch(employees, new Employee02() { Name = "Ahmed" }, delegate (Employee02 x, Employee02 y) { return x.Name == y.Name; });

            //if (index != -1)
            //    Console.WriteLine($"Employee {employees[index].Name} => {employees[index]}\nFounded at index {index}");// Employee Ahmed => Id: 30, Name: Ahmed, Salary: 5000
            //else                                                                                                             //  Founded at index 2
            //    Console.WriteLine("Not found!");

            #endregion

            #region Example02 - Using Lambda Expression - Example for Compare Id.

            //Employee02[] employees = new Employee02[]
            //{
            //    new Employee02(){Id = 10, Name = "Eslam", Salary = 8000},
            //    new Employee02(){Id = 20, Name = "Khalid", Salary = 4000},
            //    new Employee02(){Id = 30, Name = "Ahmed", Salary = 5000},
            //    new Employee02(){Id = 40, Name = "Omnia", Salary = 9000},
            //};

            //int index = Helper<Employee02>.LinearSearch(employees, new Employee02() { Id = 40 }, (x, y) => x.Id == y.Id);

            //if (index != -1)
            //    Console.WriteLine($"Employee {employees[index].Name} => {employees[index]}\nFounded at index {index}");// Employee Omnia => Id: 40, Name: Omnia, Salary: 9000
            //else                                                                                                             // Founded at index 3
            //    Console.WriteLine("Not found!");

            #endregion

            #endregion

            #endregion

            #region Example03 - BubbleSort()

            #region Part 08 Generics - BubbleSort Exmaple

            #region Example 01 - NonGeneric BubbleSort 

            //int[] nums = new int[] { 9, 4, 5, 6, 7, 2, 3, 1, 8 };
            //Helper<int>.BubbleSort(nums);

            //foreach (int num in nums)
            //{
            //    Console.Write(num + " ");// 1 2 3 4 5 6 7 8 9
            //}

            #endregion

            #region Example 02 - Generic BubbleSort 

            #region Using CompareTo(object? obj) of the NonGeneric interface "IComparable" - Cause Boxing,Unboxing & Casting with structs Types - Cause Casting with Class Types.

            #region 01 - T is [int] struct that implement the "IComparable" interface and provide implementation for "CompareTo(object? obj)"[Boxing & Unboxing - Must Make Cast from object? to int] - So Helper<int> work.

            //int[] nums = new int[] { 9, 4, 5, 6, 7, 2, 3, 1, 8 };
            //Helper<int>.BubbleSort(nums);

            //foreach (int num in nums)
            //{
            //    Console.Write(num + " ");// 1 2 3 4 5 6 7 8 9
            //} 

            #endregion

            #region 02 - T is [Employee02] Class that not-implement the "IComparable" interface and not provide implementation for "CompareTo(object? obj)"[ Must Make Cast from object? to Employee?] - So Helper<Employee02> not work.

            //Employee02[] employees = new Employee02[]
            //{
            //    new Employee02(){Id = 10, Name = "Eslam", Salary = 8000},
            //    new Employee02(){Id = 20, Name = "Khalid", Salary = 4000},
            //    new Employee02(){Id = 30, Name = "Ahmed", Salary = 5000},
            //    new Employee02(){Id = 40, Name = "Omnia", Salary = 9000},
            //};

            //Helper<Employee02>.BubbleSort(employees);// Employee02 doesn't implement the Icomparable interface.

            #endregion

            #region 02 - T is [Employee02] Class that implement the "IComparable" interface and provide implementation for CompareTo(object? obj)[ Must Make Cast from object? to Employee?] - So Helper<Employee02> will work.

            //Employee02[] employees = new Employee02[]
            //{
            //    new Employee02(){Id = 10, Name = "Eslam", Salary = 8000},
            //    new Employee02(){Id = 20, Name = "Khalid", Salary = 4000},
            //    new Employee02(){Id = 30, Name = "Ahmed", Salary = 5000},
            //    new Employee02(){Id = 40, Name = "Omnia", Salary = 9000},
            //};

            //Helper<Employee02>.BubbleSort(employees);

            //foreach (Employee02 employee in employees)
            //{
            //    Console.WriteLine(employee);// Id: 20, Name: Khalid, Salary: 4000
            //}                               // Id: 30, Name: Ahmed, Salary: 5000
            //                                // Id: 10, Name: Eslam, Salary: 8000
            //                                // Id: 40, Name: Omnia, Salary: 9000 

            #endregion

            #endregion

            #region Using CompareTo(T? other) of the Generic interface "IComparable<T>" [not cause anyThing].

            #region 01 - T is [int] struct that implement the "IComparable<T>" "IComparable<int>" interface and provide implementation for "CompareTo(int? other)" - So Helper<int> work.

            //int[] nums = new int[] { 9, 4, 5, 6, 7, 2, 3, 1, 8 };
            //Helper<int>.BubbleSort(nums);

            //foreach (int num in nums)
            //{
            //    Console.Write(num + " ");// 1 2 3 4 5 6 7 8 9
            //}

            #endregion

            #region 02 - T is [Employee02] Class that implement the "IComparable<T>" "IComparable<Employee02>" interface and provide implementation for CompareTo(Employee02? other) - So Helper<Employee02> will work.

            //Employee02[] employees = new Employee02[]
            //{
            //    new Employee02(){Id = 10, Name = "Eslam", Salary = 8000},
            //    new Employee02(){Id = 20, Name = "Khalid", Salary = 4000},
            //    new Employee02(){Id = 30, Name = "Ahmed", Salary = 5000},
            //    new Employee02(){Id = 40, Name = "Omnia", Salary = 9000},
            //};

            //Helper<Employee02>.BubbleSort(employees);

            //foreach (Employee02 employee in employees)
            //{
            //    Console.WriteLine(employee);// Id: 20, Name: Khalid, Salary: 4000
            //}                               // Id: 30, Name: Ahmed, Salary: 5000
            //                                // Id: 10, Name: Eslam, Salary: 8000
            //                                // Id: 40, Name: Omnia, Salary: 9000 

            #endregion

            #endregion

            #endregion


            #endregion

            #region Part 09 BubbleSort Using IComparer

            #region Example01 - Sort Based On Name Asc.

            //Employee02[] employees = new Employee02[]
            //{
            //    new Employee02(){Id = 10, Name = "Eslam", Salary = 8000},
            //    new Employee02(){Id = 20, Name = "Khalid", Salary = 4000},
            //    new Employee02(){Id = 30, Name = "Ahmed", Salary = 5000},
            //    new Employee02(){Id = 40, Name = "Omnia", Salary = 9000},
            //};

            //Helper<Employee02>.BubbleSort(employees, new EmployeeComparerName());

            //foreach (Employee02 emp in employees)
            //{
            //    Console.WriteLine(emp);// Id: 30, Name: Ahmed, Salary: 5000
            //}                          // Id: 10, Name: Eslam, Salary: 8000
            //                           // Id: 20, Name: Khalid, Salary: 4000
            //                           // Id: 40, Name: Omnia, Salary: 9000

            #endregion

            #region Example 02 - Sort Based On Id Asc

            //Employee02[] employees = new Employee02[]
            //{
            //    new Employee02(){Id = 50, Name = "Eslam", Salary = 8000},
            //    new Employee02(){Id = 40, Name = "Khalid", Salary = 4000},
            //    new Employee02(){Id = 100, Name = "Ahmed", Salary = 5000},
            //    new Employee02(){Id = 10, Name = "Omnia", Salary = 9000},
            //};

            //Helper<Employee02>.BubbleSort(employees, new EmployeeComparerId());

            //foreach (Employee02 emp in employees)
            //{
            //    Console.WriteLine(emp);// Id: 10, Name: Omnia, Salary: 9000
            //}                          // Id: 40, Name: Khalid, Salary: 4000
            //                           // Id: 50, Name: Eslam, Salary: 8000
            //                           // Id: 100, Name: Ahmed, Salary: 5000

            #endregion

            #region Example 03 - Sort Based On Salary Asc

            //Employee02[] employees = new Employee02[]
            //{
            //    new Employee02(){Id = 50, Name = "Eslam", Salary = 8000},
            //    new Employee02(){Id = 40, Name = "Khalid", Salary = 4000},
            //    new Employee02(){Id = 100, Name = "Ahmed", Salary = 5000},
            //    new Employee02(){Id = 10, Name = "Omnia", Salary = 9000},
            //};

            //Helper<Employee02>.BubbleSort(employees, new EmployeeComparerSalary());

            //foreach (Employee02 emp in employees)
            //{
            //    Console.WriteLine(emp);// Id: 40, Name: Khalid, Salary: 4000
            //}                          // Id: 100, Name: Ahmed, Salary: 5000
            //                           // Id: 50, Name: Eslam, Salary: 8000
            //                           // Id: 10, Name: Omnia, Salary: 9000

            #endregion

            #endregion

            #region Part 10 BubbleSort Using Delegate

            #region Example01 - Using Anonymous Method - Example for Sort Based on Id Desc.

            //Employee02[] employees = new Employee02[]
            //{
            //    new Employee02(){Id = 50, Name = "Eslam", Salary = 8000},
            //    new Employee02(){Id = 40, Name = "Khalid", Salary = 4000},
            //    new Employee02(){Id = 100, Name = "Ahmed", Salary = 5000},
            //    new Employee02(){Id = 10, Name = "Omnia", Salary = 9000},
            //};

            //Helper<Employee02>.BubbleSort(employees, delegate (Employee02 x, Employee02 y) { return x.Id.CompareTo(y.Id) == -1; });

            //foreach (Employee02 employee in employees)
            //{
            //    Console.WriteLine(employee);// Id: 100, Name: Ahmed, Salary: 5000
            //}                               // Id: 50, Name: Eslam, Salary: 8000
            //                                // Id: 40, Name: Khalid, Salary: 4000
            //                                // Id: 10, Name: Omnia, Salary: 9000 

            #endregion

            #region Example01 - Using Anonymous Method - Example for Sort Based on Name Asc.

            //Employee02[] employees = new Employee02[]
            //{
            //    new Employee02(){Id = 50, Name = "Eslam", Salary = 8000},
            //    new Employee02(){Id = 40, Name = "Khalid", Salary = 4000},
            //    new Employee02(){Id = 100, Name = "Ahmed", Salary = 5000},
            //    new Employee02(){Id = 10, Name = "Omnia", Salary = 9000},
            //};

            //Helper<Employee02>.BubbleSort(employees, (x, y) => x.Name?.CompareTo(y.Name) == 1);

            //foreach (Employee02 employee in employees)
            //{
            //    Console.WriteLine(employee);// Id: 100, Name: Ahmed, Salary: 5000
            //}                               // Id: 50, Name: Eslam, Salary: 8000
            //                                // Id: 40, Name: Khalid, Salary: 4000
            //                                // Id: 10, Name: Omnia, Salary: 9000 

            #endregion

            #endregion

            #endregion

        }
    }
}
