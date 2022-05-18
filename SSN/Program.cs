using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SSN
{
    class Program
    {
        static void Main(string[] args)
        {
            string comparator;

            Console.Write("SSN: ");
            comparator = Console.ReadLine();

            Console.WriteLine(Menu.Show(comparator));

            Console.ReadKey();


        }
    }
}
