using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{

    internal class EmployeeEqualityComparerName : IEqualityComparer<Employee02>
    {
        public bool Equals(Employee02? x, Employee02? y)
        {
            return x.Name?.Equals(y.Name) ?? y.Name == null ? true : false;
        }

        public int GetHashCode([DisallowNull] Employee02 obj)
        {
            return HashCode.Combine(obj.Name);
        }
    }

    internal class EmployeeEqualityComparerId : IEqualityComparer<Employee02>
    {
        public bool Equals(Employee02? x, Employee02? y)
        {
            return x?.Id.Equals(y.Id) ?? y == null ? true : false;
        }

        public int GetHashCode([DisallowNull] Employee02 obj)
        {
            return HashCode.Combine(obj.Id);
        }
    }

    internal class EmployeeEqualityComparerSalary : IEqualityComparer<Employee02>
    {
        public bool Equals(Employee02? x, Employee02? y)
        {
            return x?.Salary.Equals(y.Salary) ?? y == null ? true : false;
        }

        public int GetHashCode([DisallowNull] Employee02 obj)
        {
            return HashCode.Combine(obj.Salary);
        }
    }

}
