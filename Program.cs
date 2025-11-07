using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Class1 c1 = new Class1();
            Console.WriteLine("Cach goi ham tinh trong cung lop: " + c1.xuli2(15));        
            c1.nhap();
            c1.xuli1();
            Console.ReadKey();

        }
    }
}