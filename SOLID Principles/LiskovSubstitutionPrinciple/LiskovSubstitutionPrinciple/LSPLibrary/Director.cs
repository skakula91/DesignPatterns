using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSPLibrary
{
    public class Director : BaseEmployee,IManager
    {
        // Before LSP
        //public override void AssignManager(Employee manager)
        //{
        //    throw new Exception("director doesn't have manager");
        //}

        public override void CalculateHourRate(int rank)
        {
            decimal baseamount = 150M;
            Salary = baseamount + (rank * 2);
        }

        public void GeneratePerfReview()
        {
            Console.WriteLine("Reviewing performance of direct report");
        }
    }
}
