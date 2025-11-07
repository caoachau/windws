using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Class1
    {
        private int trongluong;
        private const int cp1 = 300 ;
        private const int cp2 = 200 ;
        private const int cp3 = 120;
        public void nhap()
        {
            do
            {
                Console.Write("Nhap trong luong thu: ");
                trongluong = Int32.Parse(Console.ReadLine());
            } while (trongluong <= 0);

        }
        public void xuLy()
        {
            if (trongluong <= 100)
                Console.WriteLine("Thanh tien: {0} x {1} = {2} (dong)", trongluong, cp1, trongluong * cp1);
            else if (trongluong > 100 && trongluong <= 130)
            {
                Console.WriteLine("Trong luong thu vuot dinh muc:");
                Console.WriteLine("{0} - 100 = {1} (gam)", trongluong, trongluong - 100);
                Console.WriteLine("Thanh tien: {0} x {1} + {2} x {3} = {4} (dong)", 100, cp1, trongluong - 100, cp2, ((100 * cp1) + ((trongluong - 100) * cp2)));
            }
            else if (trongluong > 130)
            {
                Console.WriteLine("Trong luong thu vuot dinh muc:");
                Console.WriteLine("{0} - 100 = {1} (gam)", trongluong, trongluong - 130);
                Console.WriteLine("Thanh tien: {0} x {1} + {2} x {3} + {4} * {5} = {6} (dong)", 100, cp1, 30, cp2, trongluong - 130, cp3, (100 * cp1 + 30 * cp2 + ((trongluong - 130) * cp3)));
            }
        }
    }
}
