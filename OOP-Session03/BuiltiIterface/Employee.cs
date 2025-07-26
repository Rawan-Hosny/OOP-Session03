using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Session03.BuiltiIterface
{
    internal class Employee : ICloneable, IComparable, IComparer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public double Salary { get; set; }
        //public Employee()
        //{

        //}
        //Copy Constructor:
        //public Employee(Employee employee)
        //{
        //    Id = employee.Id;
        //    Name = employee.Name;
        //    Age = employee.Age;
        //    Salary = employee.Salary;
        //}
        public object Clone()
        {

            // To Catch Caller -> Use this
            //return new Employee(this);
            return new Employee() { Id = this.Id, Name = this.Name, Age = this.Age, Salary = this.Salary };
        }

        public int Compare(object? x, object? y)
        {
            Employee X = (Employee)x;
            Employee Y = (Employee)y;
            if (X.Salary > Y.Salary) return 1;
            else if (X.Salary < Y.Salary) return -1;
            else return 0;
        }

        public int CompareTo(object? obj)
        {

            Employee e = (Employee)obj;
            if (this.Age > e.Age) return 1;
            else if (this.Age < e.Age) return -1;
            else return 0;
        }

        public override string ToString()
        {
            return $"Id: {Id} , Name: {Name} , Age: {Age} , Salary: {Salary}";
        }
    }

}
