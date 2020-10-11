using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SingleResponsibiltyPrinciple
{
    public class StandardMessages
    {
        public static void StartMessage()
        {
            Console.WriteLine("Test Application");
        }

        public static void EndApp()
        {
            Console.WriteLine("Click continue to close");
            Console.ReadLine();
        }
    }
}
