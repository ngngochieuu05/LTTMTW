using System;

namespace phuong_trinh
{
    class PTB2 : PTB1
    {
        private double c;
        
        public PTB2(double a, double b, double c) : base(a, b)
        {
          this.c = c;
        }

  public override void Giai()
        {
      if (a == 0)
    {
       Console.WriteLine("Phuong trinh bac I: ");
 base.Giai();
          return;
       }

   double delta = b * b - 4 * a * c;
   Console.WriteLine(string.Format("Delta = {0}", delta));

     if (delta < 0)
          {
   Console.WriteLine("Phuong trinh vo nghiem.");
            }
            else if (delta == 0)
          {
  double x = -b / (2 * a);
                Console.WriteLine(string.Format("Phuong trinh co nghiem kep: x1 = x2 = {0}", x));
   }
       else
            {
      double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
  double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
           Console.WriteLine("Phuong trinh co 2 nghiem phan biet:");
  Console.WriteLine(string.Format("x1 = {0}", x1));
 Console.WriteLine(string.Format("x2 = {0}", x2));
            }
  }
    }
}