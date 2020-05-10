using DesignPatterns.AdapterPattern.Adapter;
using DesignPatterns.AdapterPattern.Target;
using DesignPatterns.CompositePattern.Component;
using DesignPatterns.DecoratorPattern.Component;
using DesignPatterns.DecoratorPattern.ConcreteComponent;
using DesignPatterns.DecoratorPattern.ConcreteDecorator;
using System;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Composite Pattern - Hierarchy, folder structures and menu bars
            IDirectReport dr1 = new DirectReport("Report1", "IT");
            IDirectReport dr2 = new DirectReport("Report2", "IT");
            IDirectReport dr3 = new DirectReport("Report3", "IT");
            IDirectReport dr4 = new DirectReport("Report4", "HR");
            IDirectReport dr5 = new DirectReport("Report5", "HR");

            IDirectReport mgr1 = new Manager("ManagerIT", "IT")
            {
                DirectReports = {dr1,dr2,dr3}
            };
            IDirectReport mgr2 = new Manager("ManagerHR", "HR")
            {
                DirectReports = { dr4, dr5 }
            };

            IDirectReport mgrGlobal = new Manager("GlobalManager", "Global")
            {
                DirectReports = { mgr1, mgr2 }
            };

            //mgrGlobal.GetInfo();

            //2. Decorator Pattern - Used when the object needs to be extended without effecting the concrete implementation
            ICar car = new EconomyCar();
            //var cardecorator = new FinalOffer(car);
            //Console.WriteLine($"Make:{cardecorator.Make},OriginalPrice:{cardecorator.Price().ToString()}, " +
            //    $"AfterDiscount:{cardecorator.GetDiscount()}");

            //3. Adapter Pattern - Combine two incompatibe classes and interfaces using adapter pattern
            //Diff b/w decorator and adapter https://stackoverflow.com/questions/17731522/what-are-the-differences-between-the-decorator-and-adapter-patterns/17731655
            IEmployee emp = new EmployeeAdapter();
            var jsonData = emp.GetEmployees();
            Console.WriteLine(jsonData);
            Console.ReadLine();
        }
    }
}
