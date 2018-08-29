using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO

namespace TADateTimeDrill
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now);
            Console.WriteLine("Give me a number.");
            string num = Console.ReadLine();

            File.WriteAllText(@"C:\Users\Keenan\Desktop\IOtest.txt", num);
            string userInput = File.ReadAllText(@"C:\Users\Keenan\Desktop\IOtest.txt");
            Console.WriteLine(userInput);

            Console.ReadLine();
        }
    }
}
