using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class Employee02
    {

        #region properties
        
        public int Id { get; set; }
        public string? Name { get; set; }
        public decimal Salary { get; set; }

        #endregion

        #region Methods
        
        public override bool Equals(object? obj)
        {

            #region Implementation01 - Throw Exception if Casting Fail - Employee02? other = (Employee02?)obj
            //Employee02? other = (Employee02?)obj;
            //if (other is null)
            //    return false;// Because (this) object is exist,mean it contain data, so false mean (object contained data != null).

            //return (this.Id == other?.Id && this.Name == other.Name && this.Salary == other.Salary); 
            #endregion

            #region Implementation02 - Using "is" operator - Not throw Exception if casting fail- if(obj is Employee02 other)

            //if(obj is Employee02 other) // "true" if "obj" refer to object of type "Employee02" or object of any type inherit from "Employee02" - And "other" will hold the address of this object                          
            //{                           // "false" if "obj" refer to object of another type -  "other" will hold null.
            //    return (this.Id == other?.Id && this.Name == other.Name && this.Salary == other.Salary);
            //}

            //return false;

            #endregion

            #region Implementation03 - Using "as" operator - Not thrown Exception if casting fail

            Employee02? other = obj as Employee02;// if "obj" not refer to object from class "Employee02", other will hold null. 

            if(other == null)
                return false;

            return (this.Id == other?.Id && this.Name == other.Name && this.Salary == other.Salary);

            #endregion
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

    }
}
