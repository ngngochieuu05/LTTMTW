using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiHocSinh_BTVN2_NgNgocHieu
{
    public class QuanLiHocSinh
    {
        private List<Student> danhSachSinhVien;

        public QuanLiHocSinh()
        {
            danhSachSinhVien = new List<Student> { };
        }

        public void ThemSinhVien()
        {
            int maSo;
            string ten;
            int tuoi;

            Console.WriteLine("\n--- THEM SINH VIEN MOI ---");

            Console.Write("Nhap Ma So Sinh Vien: ");
            while (!int.TryParse(Console.ReadLine(), out maSo) || danhSachSinhVien.Any(s => s.MaSo == maSo))
            {
                Console.Write("Ma so khong hop le hoac da ton tai. Nhap lai Ma so: ");
            }

            Console.Write("Nhap Ten Sinh Vien: ");
            ten = Console.ReadLine();

            Console.Write("Nhap Tuoi Sinh Vien: ");
            while (!int.TryParse(Console.ReadLine(), out tuoi) || tuoi <= 0)
            {
                Console.Write("Tuoi khong hop le. Nhap lai tuoi: ");
            }

            danhSachSinhVien.Add(new Student { MaSo = maSo, Ten = ten, Tuoi = tuoi });
            Console.WriteLine($"\nDa them sinh vien [{ten}] [Ma so: {maSo}] thanh cong!");
        }

        public void HienThiDanhSach(IEnumerable<Student> sinhViens)
        {
            if (sinhViens == null || !sinhViens.Any())
            {
                Console.WriteLine("Khong tim thay sinh vien nao.");
                return;
            }
            foreach (var s in sinhViens)
            {
                Console.WriteLine(s);
            }
        }

        public void InToanBoDanhSach()
        {
            HienThiDanhSach(danhSachSinhVien);
        }

        public void TimSVTuoi15Den18()
        {
            var ketQua = danhSachSinhVien.Where(s => s.Tuoi >= 15 && s.Tuoi <= 18);
            HienThiDanhSach(ketQua);
        }

        public void TimSVTenBatDauBangA()
        {
            var ketQua = danhSachSinhVien.Where(s => s.Ten.StartsWith("A", StringComparison.OrdinalIgnoreCase));
            HienThiDanhSach(ketQua);
        }

        public void TinhTongTuoi()
        {
            int tongTuoi = danhSachSinhVien.Sum(s => s.Tuoi);
            Console.WriteLine($"\n--- Tong tuoi cua tat ca sinh vien ---");
            Console.WriteLine($"Tong tuoi: {tongTuoi}");
        }

        public void TimSVTuoiLonNhat()
        {
            if (danhSachSinhVien.Any())
            {
                int tuoiLonNhat = danhSachSinhVien.Max(s => s.Tuoi);
                var ketQua = danhSachSinhVien.Where(s => s.Tuoi == tuoiLonNhat);
                HienThiDanhSach(ketQua);
            }
            else
            {
                Console.WriteLine("Danh sach rong.");
            }
        }

        public void SapXepTheoTuoiTangDan()
        {
            var ketQua = danhSachSinhVien.OrderBy(s => s.Tuoi);
            HienThiDanhSach(ketQua);
        }
    }
}
