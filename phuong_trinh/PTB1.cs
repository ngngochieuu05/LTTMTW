using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                    Console.WriteLine("Phuong trinh vo so nghiem");
                else
                    Console.WriteLine("Phuong trinh vo nghiem");
            }
            else
            {
                double x = -b / a;
                Console.WriteLine("Nghiem x = {0}", x);
            }
        }
    }
}