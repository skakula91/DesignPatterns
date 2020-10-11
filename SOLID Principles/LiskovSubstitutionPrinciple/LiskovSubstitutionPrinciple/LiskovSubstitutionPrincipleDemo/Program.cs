using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LSPLibrary;

namespace LiskovSubstitutionPrincipleDemo
{
    class Program
    {
        // LSP: if s is a subtype of t then object of t is replaced  by object of s without breaking the program
        static void Main(string[] args)
        {
            IManager acctManager = new Director();
            acctManager.FirstName = "sai";
            acctManager.LastName = "akula";
            acctManager.CalculateHourRate(4);


            // Replacing subtype with object of type the application doesn't break
            //BaseEmployee emp = new Employee();
            //BaseEmployee emp = new Manager();
            BaseEmployee emp = new Director();
            emp.FirstName = "test";
            emp.LastName = "test";
            //emp.AssignManager(acctManager);
            emp.CalculateHourRate(2);

            Console.WriteLine($"{emp.FirstName} salary is :{emp.Salary}/hour");
            Console.ReadLine();
        }
    }
}
