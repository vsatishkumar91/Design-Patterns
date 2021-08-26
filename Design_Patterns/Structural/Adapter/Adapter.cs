using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using Newtonsoft.Json;

namespace Design_Patterns.Structural.Adapter
{
    public class Employee
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
    }

    public class EmployeeManager
    {
        private List<Employee> employees { get; set; }
        public EmployeeManager()
        {
            this.employees = new List<Employee>()
            {
                new Employee(1, "John", 25000),
                new Employee(2, "James", 15000),
                new Employee(3, "Tony", 35000),
            };
        }
        public virtual string getEmployees()
        {
            XElement xmlElements = new XElement("Employees", employees.Select(i => new XElement("Employee", i)));
            return xmlElements.ToString();
        }
    }

    public interface IEmployee
    {
        string getEmployees();
    }

    public class EmployeeAdapter: EmployeeManager, IEmployee
    {
        public override string getEmployees()
        {
            var items = base.getEmployees();


            XmlDocument document = new XmlDocument();
            document.LoadXml(items);
            return JsonConvert.SerializeObject(document, Newtonsoft.Json.Formatting.Indented);
        }
    }
}
