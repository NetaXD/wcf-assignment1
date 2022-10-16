using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_3170_A1_Nate_Mrakava {
    internal class Program {
        static void Main(string[] args) {
            A1Service.ServiceClient srv = new A1Service.ServiceClient();
            Console.WriteLine(srv.GetData(1));
            Console.ReadKey();
        }
    }
}

