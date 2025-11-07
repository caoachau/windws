using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Class1 c1 = new Class1();
            c1.nhap();
            c1.xuLy1();
            Console.ReadKey();
        }
    }
}
