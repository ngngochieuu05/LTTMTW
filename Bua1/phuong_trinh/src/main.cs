using System;

namespace phuong_trinh
{
 class Program
{
        static void Main()
        {
     Console.WriteLine("Phuong trinh bac II:");

    Console.Write("Nhap a = ");
   double a = double.Parse(Console.ReadLine());

        Console.Write("Nhap b = ");
     double b = double.Parse(Console.ReadLine());

       Console.Write("Nhap c = ");
     double c = double.Parse(Console.ReadLine());

  Console.WriteLine();

     PTB2 pt = new PTB2(a, b, c);
     pt.Giai();
 
   Console.WriteLine("\nNhan phim bat ky de thoat...");
         Console.ReadKey();
        }
    }
}