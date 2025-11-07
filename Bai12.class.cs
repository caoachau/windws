using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b12
{
    internal class Class1
    {
        private int sokwh;

        public void nhap()
        {
            do
            {
                Console.Write("Nhap trong luong thu: ");
                sokwh = Int32.Parse(Console.ReadLine());
            } while (sokwh <= 0);

        }
        public void xuLy1()
        {
            const int cp1 = 600;
            const int cp2 = 700;
            const int cp3 = 900;
            const int cp4 = 1100;

            if (sokwh <= 100)
                Console.WriteLine("Thanh tien muc 1: {0} x {1} = {2} (dong)", sokwh, cp1, sokwh * cp1);
            else if (sokwh > 100 && sokwh <= 150)
            
            {
                Console.WriteLine("Trong luong thu vuot dinh muc 2 :");
                Console.WriteLine("{0} - 100 = {1} (gam)", sokwh, sokwh - 100);           
                Console.WriteLine("Thanh tien: {0} x {1} + {2} x {3} = {4} (dong)", 100, cp1, sokwh - 100, cp2, ((100 * cp1) + ((sokwh - 100) * cp2)));
            }

            else if (sokwh >= 151 && sokwh <= 200)
            {
                Console.WriteLine("Trong luong thu vuot dinh muc 3:");
                Console.WriteLine("{0} - 100 = {1} (gam)", sokwh, sokwh - 150);
                Console.WriteLine("Thanh tien: {0} x {1} + {2} x {3} + {4} * {5} = {6} (dong)", 100, cp1, 50, cp2, sokwh - 151, cp3, (100 * cp1 + 30 * cp2 + ((sokwh - 150) * cp3)));
            }

            else if (sokwh >= 201)
            {
                Console.WriteLine("Trong luong thu vuot dinh muc 4:");
                Console.WriteLine("{0} - 100 = {1} (gam)", sokwh, sokwh - 200);
                Console.WriteLine("Thanh tien: {0} x {1} + {2} x {3} + {4} * {5} + {6}*{7} = {8} (dong)", 100, cp1,  50, cp2 ,50, cp3, (sokwh -200), cp4,(100 * cp1 + 50 * cp2 + 50*cp3 + (sokwh-200)*cp4));
            }                                                                                           //0-100     100-150     151-200  >200

        }
    }
}

