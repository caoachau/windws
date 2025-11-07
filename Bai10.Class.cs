using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai10
{

    internal class Class1
    {
        private int snd;
        public void nhap()
        {
            if (snd < 10 || snd > 99)
            {
                Console.Write("Nhap so nguyen duong co 2 chu so(10-99): ");
                snd = Int32.Parse(Console.ReadLine());
            }
        }
        public void xuli1()
        {
            string[] mang1 = { "mot", "hai", "ba", "bon", "nam", "sau", "bay", "tam", "chin" };

            string[] tengoi1 = { "mười" };
            string[] tengoi2 = { "mươi" };


            int donvi = snd % 10;
            int chuc = snd / 10;

            if (donvi == 0) // so 10 20 30 40 50 60 70 80 90
            {
                Console.WriteLine("{0} {1}", mang1[chuc - 1], tengoi2[0]);

            }
            else // so 11 12 13 14 15 16 17 18 19 
            {
                if (chuc == 1)
                    Console.WriteLine("{0} {1} ", tengoi1[0], mang1[donvi - 1]);
                else
                    Console.WriteLine("{0} {1} {2}", mang1[chuc - 1], tengoi2[0], mang1[donvi - 1]);
            }
        }
        public string xuli2(int snd)
        {
            string[] mang2 = { "một", "hai", "ba", "bốn", "năm", "sáu", "bảy", "tám", "chín" };
            int donvi = snd % 10;
            int chuc = snd / 10;
            {
                string[] chuSo = { "không", "một", "hai", "ba", "bốn", "năm", "sáu", "bảy", "tám", "chín" };

                if (chuc == 1)
                {
                    if (donvi == 0) return "mười";
                    if (donvi == 5) return "mười lăm";
                 
                    return "mười " + chuSo[donvi];
                }

                string docChuc = chuSo[chuc] + " mươi";

                if (donvi == 0) return docChuc;
                if (donvi == 1) return docChuc + " mốt";
                if (donvi == 4) return docChuc + " tư";
                if (donvi == 5) return docChuc + " lăm";

                return docChuc + " " + chuSo[donvi];
            }


        }
    }
}

