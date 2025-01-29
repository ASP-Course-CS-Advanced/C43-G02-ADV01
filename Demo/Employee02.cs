using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class Employee02
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public decimal Salary { get; set; }

        public override bool Equals(object? obj)
        {
            Employee02? other = (Employee02?)obj;
            if (other is null)
                return false;// Because (this) object is exist,mean it contain data, so false mean (object contained data != null).

            return (this.Id == other?.Id && this.Name == other.Name && this.Salary == other.Salary);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(this.Id,this.Name,this.Salary);
        }
    }
}
