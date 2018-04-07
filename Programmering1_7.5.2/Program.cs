using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmering1_7._5._2 {
    class Program {
        static void Main(string[] args) {
            Console.Write("Välj ett nummer mellan 1 och 100: ");
            int num = Convert.ToInt32(Console.ReadLine());
            
            if(num>=1 && num<=100) {
                do {
                    Console.Write("{0} ", num++);
                } while(num<=101);
            }
            else {
                return;
            }

            Console.ReadLine();
        }
    }
}
