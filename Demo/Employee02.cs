using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class Employee02 : IEquatable<Employee02>/*, IComparable*/, IComparable<Employee02>
    {

        #region properties

        public int Id { get; set; }
        public string? Name { get; set; }
        public decimal Salary { get; set; }

        #endregion

        #region Methods

        #region I don't need This Method - Because "Employee02" Now Implement the Generic "IEquatable<T>" Which has method "Equals(T? other)" that take parameter of type generic, specify the type when implement the Interface.

        //public override bool Equals(object? obj)
        //{

        //    #region Implementation01 - Throw Exception if Casting Fail - Employee02? other = (Employee02?)obj
        //    //Employee02? other = (Employee02?)obj;
        //    //if (other is null)
        //    //    return false;// Because (this) object is exist,mean it contain data, so false mean (object contained data != null).

        //    //return (this.Id == other?.Id && this.Name == other.Name && this.Salary == other.Salary); 
        //    #endregion

        //    #region Implementation02 - Using "is" operator - Not throw Exception if casting fail- if(obj is Employee02 other)

        //    //if(obj is Employee02 other) // "true" if "obj" refer to object of type "Employee02" or object of any type inherit from "Employee02" - And "other" will hold the address of this object                          
        //    //{                           // "false" if "obj" refer to object of another type -  "other" will hold null.
        //    //    return (this.Id == other?.Id && this.Name == other.Name && this.Salary == other.Salary);
        //    //}

        //    //return false;

        //    #endregion

        //    #region Implementation03 - Using "as" operator - Not thrown Exception if casting fail

        //    Employee02? other = obj as Employee02;// if "obj" not refer to object from class "Employee02", other will hold null. 

        //    if (other == null)
        //        return false;

        //    return (this.Id == other?.Id && this.Name == other.Name && this.Salary == other.Salary);

        //    #endregion
        //}

        #endregion

        #region CompareTo of the NonGeneric interface IComparable

        //public int CompareTo(object? obj)// Method of the NonGeneric interface "IComparable".
        //{
        //    Employee02? other = obj as Employee02;// Because we implement the "Icomparable" interface which is the nonGeneric version which depend on the "objec?"
        //                                          //  not implement the "Icomparable<T>" that is Generic version depend on the class Type that implement the interface
        //    if (other is null)
        //        return 1;// mean this > other.

        //    if (this.Salary > other.Salary)
        //        return 1;
        //    else if (this.Salary < other.Salary)
        //        return -1;
        //    else
        //        return 0;
        //} 

        #endregion

        #region CompareTo of the Generic interface IComparable<Employee>.

        public int CompareTo(Employee02? other)
        {
            if (other is null)
                return 1;
            if (this.Salary > other.Salary)
                return 1;
            else if (this.Salary < other.Salary)
                return -1;
            else
                return 0;
        }

        #endregion

        #region object class Methods
        
        public bool Equals(Employee02? other) // Equals() of IEquatable Interface.
        {
            if (other == null)
                return false;
            else
                return (this.Id.Equals(other.Id) && (this.Name?.Equals(other.Name) ?? other.Name == null ? true : false) && this.Salary.Equals(other.Salary));
        }

        public override int GetHashCode()
        {

            #region Implementation 01 - Has Proplem [Collision Between Two objects that has different state like [ new Employee(){Id = 10, Name = "Ahmed", Salary = 1000 - new Employee(){Id = 1000, Name = "Ahmed", Salary = 10} ] - The GetHashCode() of them are same!]

            #region 01.1 - (+) Bad Performance & Collission

            //return this.Id.GetHashCode() + this.Name?.GetHashCode() ?? default(int) + this.Salary.GetHashCode();

            #endregion

            #region 01.2 - (^) Good Performance & Collision

            //return this.Id.GetHashCode() ^ this.Name?.GetHashCode() ?? default(int) ^ this.Salary.GetHashCode();

            #endregion

            #endregion

            #region Implementation 02 - Using Prime Number | not Cause Collision | Best Implementation

            //int hashValue = 11;

            //hashValue = (hashValue * 7) ^ Id.GetHashCode();
            //hashValue = (hashValue * 7) ^ Name?.GetHashCode() ?? default(int);
            //hashValue = (hashValue * 7) ^ Salary.GetHashCode();

            //return hashValue;

            #endregion

            #region Implementation 03 - Using HashCode.Combine() Method  - Built in struct "HashCode" that has class member method "Combine()" that make the implementation - C#8.0.  

            return HashCode.Combine(this.Id, this.Name, this.Salary);

            #endregion

        }

        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, Salary: {Salary}";
        } 

        #endregion

        #endregion

    }
}
