using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal struct Employee
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public decimal Salary { get; set; }

        #region Not need to do this -  because structs inherit Equals() method that do the same thing (Compare states of two objects).

        //public static bool operator ==(Employee emp01, Employee emp02)
        //{
        //    return (emp01.Id == emp02.Id && emp01.Name == emp02.Name && emp01.Salary == emp02.Salary);
        //}

        //public static bool operator !=(Employee emp01, Employee emp02)
        //{
        //    return !(emp01 == emp02);
        //    //return !(emp01.Id == emp02.Id && emp01.Name == emp02.Name && emp01.Salary == emp02.Salary);
        //} 

        #endregion

    }
}
