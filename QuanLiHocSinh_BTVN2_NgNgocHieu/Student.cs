using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiHocSinh_BTVN2_NgNgocHieu
{
    public class Student
    {
        public int MaSo { get; set; }
        public string Ten { get; set; }
        public int Tuoi { get; set; }

        public override string ToString()
        {
            return $"ID: {MaSo} - Ten: {Ten} - Tuoi: {Tuoi}";
        }
    }
}
