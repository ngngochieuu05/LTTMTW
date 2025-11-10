using System;

namespace phuong_trinh
{
    class PTB1
    {
        protected double a, b;

   public PTB1(double a, double b)
  {
     this.a = a;
        this.b = b;
        }

    public virtual void Giai()
        {
    if (a == 0)
 {
             if (b == 0)
     {
           Console.WriteLine("Phuong trinh vo so nghiem.");
    }
       else
            {
             Console.WriteLine("Phuong trinh vo nghiem.");
        }
          }
else
            {
      double x = -b / a;
            Console.WriteLine(string.Format("Phuong trinh co nghiem x = {0}", x));
     }
    }
    }
}