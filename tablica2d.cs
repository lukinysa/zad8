using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] array = new string[5,2]
            {
            {"poniedziałek ", "15stopni"},
            {"wtorek ", "16stopni"},
            {"środa ","10stopni" },
            {"czwartek ", "8stopni" },
            {"piątek ", "7stopni" },
            };
            Console.Write(array[0, 0]);
            Console.WriteLine(array[0, 1]);
            Console.Write(array[1, 0]);
            Console.WriteLine(array[1, 1]);
            Console.Write(array[2, 0]);
            Console.WriteLine(array[2, 1]);
            Console.Write(array[3, 0]);
            Console.WriteLine(array[3, 1]);
            Console.Write(array[4, 0]);
            Console.WriteLine(array[4, 1]);
            Console.ReadKey();
        }
    }
}
