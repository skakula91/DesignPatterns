using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSPLibrary
{
    public class Manager : Employee, IManager
    {
        public override void CalculateHourRate(int rank)
        {
            decimal baseamount = 16.50M;
            Salary = baseamount + (rank * 2);
        }

        public void GeneratePerfReview()
        {
            Console.WriteLine("Reviewing performance of direct report");
        }
    }
}
