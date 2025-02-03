using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{

    internal class EmployeeComparerName : IComparer<Employee02>
    {
        public int Compare(Employee02? x, Employee02? y)
        {
            return x?.Name?.CompareTo(y?.Name) ?? (y == null ? 0 : -1);
        }
    }

    internal class EmployeeComparerId : IComparer<Employee02>
    {
        public int Compare(Employee02? x, Employee02? y)
        {
            return x?.Id.CompareTo(y?.Id ?? 0) ?? (y == null ? 0 : -1);
        }
    }

    internal class EmployeeComparerSalary : IComparer<Employee02>
    {
        public int Compare(Employee02? x, Employee02? y)
        {
            return x?.Salary.CompareTo(y?.Salary ?? 0) ?? (y == null ? 0 : -1);
        }
    }

}
