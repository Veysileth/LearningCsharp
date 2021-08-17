using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCsharpLibrary.Patterns.Design.Creational.FluentInterface
{
    public class LearningFluentInterface : IDemo
    {
        public void Demo()
        {
            Employee employee = new();
            employee.FullName = "Name Surname";
            employee.DateOfBirth = Convert.ToDateTime("10/10/1992");
            employee.Department = "Dept";
            employee.Address = "Address";

            FluentEmployee fluentEmployee = new();
            fluentEmployee.NameOfTheEmployee("Name")
                .Born("10/10/1990")
                .WorkingOn("Dept")
                .StaysAt("Place");
        }

        private class Employee
        {
            public string FullName { get; set; }
            public DateTime DateOfBirth { get; set; }
            public string Department { get; set; }
            public string Address { get; set; }
        }

        private class FluentEmployee
        {
            private Employee _Employee = new();

            public FluentEmployee NameOfTheEmployee(string fullName)
            {
                _Employee.FullName = fullName;
                return this;
            }

            public FluentEmployee Born(string dateOfBirth)
            {
                _Employee.DateOfBirth = Convert.ToDateTime(dateOfBirth);
                return this;
            }

            public FluentEmployee WorkingOn(string departnent)
            {
                _Employee.Department = departnent;
                return this;
            }

            public FluentEmployee StaysAt(string address)
            {
                _Employee.Address = address;
                return this;
            }
        }
    }
}