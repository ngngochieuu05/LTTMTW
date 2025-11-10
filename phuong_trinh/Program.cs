using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace phuong_trinh
{
    class Program
    {
        static void Main()
        {
            try
            {
                Console.WriteLine("Giai phuong trinh bac 2:");

                Console.Write("Nhap a = ");
                double a = double.Parse(Console.ReadLine());

                Console.Write("Nhap b = ");
                double b = double.Parse(Console.ReadLine());

                Console.Write("Nhap c = ");
                double c = double.Parse(Console.ReadLine());

                Console.WriteLine();

                PTB2 pt = new PTB2(a, b, c);
                pt.Giai();
            }
            catch (Exception e)
            {
                Console.WriteLine("Loi: " + e.Message);
            }

            Console.WriteLine("\nNhan phim bat ky de thoat...");
            Console.ReadKey();
        }
    }
}