using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] a = new string[5]; //declaring array 

            //storing value in array element
            a[0] = "Steven";
            a[1] = "Clark";
            a[2] = "Mark";
            a[3] = "Thompson";
            a[4] = "John";

            //retrieving value using foreach loop
            foreach (string name in a)
            {
                Console.WriteLine("Hello, Good Morning " + name);
            }
            Console.ReadLine();
        }
    }
}
/*
    Hello, Good Morning Steven
    Hello, Good Morning Clark
    Hello, Good Morning Mark
    Hello, Good Morning Thompson
    Hello, Good Morning John
*/
