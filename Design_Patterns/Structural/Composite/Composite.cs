using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Structural.Composite
{
    public interface IEmployee
    {
        void PrintDetails();
    }

    public class Employee: IEmployee
    {
        public Employee(int id, string name, decimal salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Salary { get; set; }

        public void PrintDetails()
        {
            Console.WriteLine($"---- Id: {Id} Name: {Name} Salary: {Salary}");
        }
    }

    public class Manager:Employee
    {
        public List<IEmployee> Subordinates { get; set; }
        public Manager(int id, string name, decimal salary): base(id,name,salary)
        {
            Subordinates = new List<IEmployee>();
        }

        public new void PrintDetails()
        {
            Console.WriteLine($"--+ Id: {Id} Name: {Name} Salary: {Salary}");
            foreach(var emp in Subordinates)
            {
                emp.PrintDetails();
            }

        }

    }

}
