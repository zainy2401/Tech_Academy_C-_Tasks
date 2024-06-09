using System;
using System.Collections.Generic;
using System.Linq;

namespace LambdaExpressionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee() { Id = 1, FirstName = "Joe", LastName = "Barry"};
            Employee emp2 = new Employee() { Id = 2, FirstName = "Joe", LastName = "Basil" };
            Employee emp3 = new Employee() { Id = 3, FirstName = "Bill", LastName = "Topper" };
            Employee emp4 = new Employee() { Id = 4, FirstName = "Bob", LastName = "Griffith" };
            Employee emp5 = new Employee() { Id = 5, FirstName = "Barry", LastName = "Sullivan" };
            Employee emp6 = new Employee() { Id = 6, FirstName = "Jane", LastName = "Doe" };
            Employee emp7 = new Employee() { Id = 7, FirstName = "Alice", LastName = "Fresh" };
            Employee emp8 = new Employee() { Id = 8, FirstName = "Kate", LastName = "Moore" };
            Employee emp9 = new Employee() { Id = 9, FirstName = "Kelly", LastName = "Monroe" };
            Employee emp10 = new Employee() { Id = 10, FirstName = "Daniel", LastName = "Hendricks" };
            List<Employee> firstList = new List<Employee>() { emp1, emp2, emp3, emp4, emp5, emp6, emp7, emp8, emp9, emp10};

            List<Employee> joeList = new List<Employee>();
            //foreach(Employee employee in firstList)
            //{
            //    if(employee.FirstName == "Joe")
            //    {
            //        joeList.Add(employee);
            //    }
            //}

            joeList = firstList.Where(x => x.FirstName == "Joe").ToList();

            List<Employee> bigId = new List<Employee>();
            bigId = firstList.Where(x => x.Id > 5).ToList();

            foreach(Employee employee in joeList)
            {
                Console.WriteLine(employee.FirstName);
            }

            foreach (Employee employee in bigId)
            {
                Console.WriteLine(employee.FirstName);
            }
        }
    }
}
