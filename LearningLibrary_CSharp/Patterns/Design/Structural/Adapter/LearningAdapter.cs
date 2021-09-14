using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LearningCsharpLibrary.Patterns.Design.Structural.Adapter.Storage;

namespace LearningCsharpLibrary.Patterns.Design.Structural.Adapter
{
    public class LearningAdapter : IDemo, IDesignPattern
    {
        public static LevelScale UsageFrequency { get; } = LevelScale.MediumHigh;
        public static LevelScale Hardness { get; } = LevelScale.Unknown;

        public void Demo()
        {
            string[,] employeesArray = new string[5, 4]
            {
                {"101","John","SE","10000"},
                {"102","Smith","SE","20000"},
                {"103","Dev","SSE","30000"},
                {"104","Pam","SE","40000"},
                {"105","Sara","SSE","50000"}
            };

            ITarget targetObjectAdapter = new EmployeeObjectAdapter();
            Console.WriteLine("HR system passes employee string array to Adapter\n");
            targetObjectAdapter.ProcessCompanySalary(employeesArray);

            ITarget targetClassAdapter = new EmployeeClassAdapter();
            Console.WriteLine("HR system passes employee string array to Adapter\n");
            targetObjectAdapter.ProcessCompanySalary(employeesArray);
        }

        public class EmployeeObjectAdapter : ITarget
        {
            private ThirdPartyBillingSystem thirdPartyBillingSystem = new ();

            public void ProcessCompanySalary(string[,] employeesArray)
            {
                string Id = null;
                string Name = null;
                string Designation = null;
                string Salary = null;

                List<Employee> listEmployee = new ();
                for (int i = 0; i < employeesArray.GetLength(0); i++)
                {
                    // Yup. I know that i should use TryParse.
                    int id = Convert.ToInt32(employeesArray[i, 0]);
                    string name = employeesArray[i, 1];
                    string designation = employeesArray[i, 2];
                    decimal salary = Convert.ToDecimal(employeesArray[i, 3]);

                    listEmployee.Add(new Employee(id, name, designation, salary));
                }

                Console.WriteLine("Adapter converted Array of Employee to List of Employee");
                Console.WriteLine("Then delegate to the ThirdPartyBillingSystem for processing the employee salary\n");
                thirdPartyBillingSystem.ProcessSalary(listEmployee);
            }
        }

        public class EmployeeClassAdapter : ThirdPartyBillingSystem, ITarget
        {
            public void ProcessCompanySalary(string[,] employeesArray)
            {
                string Id = null;
                string Name = null;
                string Designation = null;
                string Salary = null;

                List<Employee> listEmployee = new ();
                for (int i = 0; i < employeesArray.GetLength(0); i++)
                {
                    // Yup. I know that i should use TryParse.
                    int id = Convert.ToInt32(employeesArray[i, 0]);
                    string name = employeesArray[i, 1];
                    string designation = employeesArray[i, 2];
                    decimal salary = Convert.ToDecimal(employeesArray[i, 3]);

                    listEmployee.Add(new Employee(id, name, designation, salary));
                }

                Console.WriteLine("Adapter converted Array of Employee to List of Employee");
                Console.WriteLine("Then delegate to the ThirdPartyBillingSystem for processing the employee salary\n");
                ProcessSalary(listEmployee);
            }
        }
    }
}