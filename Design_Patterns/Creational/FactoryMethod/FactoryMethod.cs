using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.FactoryMethod
{
    public enum EmployeeType
    {
        Permanent,
        Contract
    }

    public class Employee
    {
        public Employee(int id, string name, EmployeeType type)
        {
            Id = id;
            Name = name;
            Type = type;
        }
        public int Id { get; set; }
        public string Name { get; set; }

        public EmployeeType Type { get; set; }
    }

    public interface IEmployeeService
    {
        decimal getBonus();
    }

    public class PermanentEmployeeService : IEmployeeService
    {
        public decimal getBonus()
        {
            return 20;
        }
    }

    public class ContractEmployeeService : IEmployeeService
    {
        public decimal getBonus()
        {
            return 10;
        }
    }

    public class EmployeeFactory
    {
        public IEmployeeService getEmployeeService(Employee emp)
        {
            if(emp.Type == EmployeeType.Permanent)
            {
                return new PermanentEmployeeService();
            } else
            {
                return new ContractEmployeeService();
            }
        }
    }
}
