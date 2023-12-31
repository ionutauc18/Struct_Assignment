using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace StructAssignment
{
    // Creating a struct called Number
    public struct Number
    {
        // Creating a property called "Amount" of data type decimal
        public decimal Amount { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Creating an object of data type Number and initializing it
            Number number = new Number();

            // Assigning an amount to the Number object
            number.Amount = 18.05M;

            // Printing the amount to the console
            Console.WriteLine("Amount: " + number.Amount);

            Console.ReadLine();
        }
    }
}
