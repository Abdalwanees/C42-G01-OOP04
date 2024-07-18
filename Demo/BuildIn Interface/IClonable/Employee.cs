using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.BuildIn_Interface.IClonable
{
    internal class Employee : ICloneable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public Department? Department { get; set; }

        public Employee()
        {

        }

        // copy constructor
        public Employee(Employee employeeCopy)
        {
            Id = employeeCopy.Id;
            Name = employeeCopy.Name;
            Salary = employeeCopy.Salary;
            Department = (Department?)this?.Department?.Clone();

        }


        public object Clone()
        {
            return new Employee(this);
            //return new Employee()
            //{
            //    Id = this.Id,
            //    Name = this.Name,
            //    Salary = this.Salary,
            //    Department = (Department?)this?.Department?.Clone()
            //}; 
        }

        public override string ToString()
        {
            return $"Id : {Id}\nName : {Name}\nSalary : {Salary}";
        }
    }
}
