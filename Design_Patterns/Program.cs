using System;
using Design_Patterns.Singleton;
using Design_Patterns.FactoryMethod;
using Design_Patterns.Creational.AbstractFactoryMethod;
using Design_Patterns.Prototype;
using Design_Patterns.Builder;
using Design_Patterns.Structural.Adapter;
using Design_Patterns.Structural.Bridge;
using Design_Patterns.Structural.Composite;
using Design_Patterns.Structural.Decorator;

namespace Design_Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            SigletonClass sigletonClass = SigletonClass.getInstance;
            sigletonClass.showMessage("Hello");

            FactoryMethod.Employee perEmp = new FactoryMethod.Employee(1, "John", EmployeeType.Contract);

            EmployeeFactory employeeFactory = new EmployeeFactory();
            IEmployeeService service = employeeFactory.getEmployeeService(perEmp);
            Console.WriteLine(service.getBonus());



            ProfessionalFactory professionalFactory = new ProfessionalFactory();
            IProfessionalfactory factory =  professionalFactory.getProfessionalFactory(true);
            IProfession profession = factory.getSubFactory("Teacher");
            profession.WhoAmI();

            Rectangle rectangle = new Rectangle();
            Console.WriteLine(rectangle.calculateArea());
            Console.WriteLine(rectangle.GetHashCode());
            Rectangle r2 = rectangle.Clone();
            r2.setDimensions(2, 3);
            Console.WriteLine(r2.calculateArea());
            Console.WriteLine(r2.GetHashCode());


            Search searchObj = new Search(1, 10, "test", "asc", "Id");
            SearcrhBuilder searcrhBuilder = new SearcrhBuilder().SetOffset(1).SetPageSize(10).SetSearchString("test").SetSortBy("id").SetSortOrder("inc");
            Search searchObject = searcrhBuilder.GetObject();


            EmployeeManager employeeManager = new EmployeeManager();
            Console.WriteLine(employeeManager.getEmployees());

            Structural.Adapter.IEmployee emp = new EmployeeAdapter();
            Console.WriteLine(emp.getEmployees());


            Payment order = new CardPayment();
            order.paymentSystem = new CitibankPaymentSystem();
            order.MakePayment();

            Structural.Composite.Manager bob = new Manager(1, "bob", 50);
            Structural.Composite.Manager john = new Manager(2, "John", 40);
            Structural.Composite.Manager james = new Manager(3, "James", 40);
            Structural.Composite.Employee alice = new Structural.Composite.Employee(3, "James", 40);
            bob.Subordinates.Add(john);
            john.Subordinates.Add(james);
            john.Subordinates.Add(alice);
            bob.PrintDetails();


            Car car = new Indica();
            CarDecorator carDecorator = new CarDecorator(car);
            Console.WriteLine(carDecorator.getPrice());
            Console.WriteLine(carDecorator.getDiscountedPrice());
        }
    }
}
