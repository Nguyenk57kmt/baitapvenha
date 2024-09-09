using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mylibrary;

namespace bài_tập
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap so thu nhat:");
            int x = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Nhap so thu hai:");
            int y = Convert.ToInt32(Console.ReadLine());


            Calculator calculator = new Calculator();
            int sigle  = calculator.Add(x, y);


            Console.WriteLine("hieu cua hai so la: " + sigle);


            Console.ReadKey();
        }
    }
}
