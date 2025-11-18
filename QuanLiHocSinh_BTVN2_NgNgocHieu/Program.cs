using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiHocSinh_BTVN2_NgNgocHieu
{

    public class Program
    {
        public static void Main(string[] args)
        {
            QuanLiHocSinh quanLy = new QuanLiHocSinh();
            bool dangChay = true;

            while (dangChay)
            {
                Console.WriteLine("\n==================================================");
                Console.WriteLine("|           MENU QUAN LY HOC SINH                |");
                Console.WriteLine("==================================================");
                Console.WriteLine("|1. Them sinh vien.                              |");
                Console.WriteLine("|2. In toan bo danh sach.                        |");
                Console.WriteLine("|3. Tim HS co tuoi tu 15 den 18.                 |");
                Console.WriteLine("|4. Tim HS co ten bat dau bang 'A'.              |");
                Console.WriteLine("|5. Tinh tong tuoi.                              |");
                Console.WriteLine("|6. Tim HS co tuoi lon nhat.                     |");
                Console.WriteLine("|7. Sap xep danh sach theo tuoi tang dan.        |");
                Console.WriteLine("|0. Thoat chuong trinh.                          |");
                Console.WriteLine("==================================================");
                Console.Write("Vui long nhap lua chon: ");

                string luaChon = Console.ReadLine();

                switch (luaChon)
                {
                    case "1":
                        quanLy.ThemSinhVien();
                        break;
                    case "2":
                        quanLy.InToanBoDanhSach();
                        break;
                    case "3":
                        quanLy.TimSVTuoi15Den18();
                        break;
                    case "4":
                        quanLy.TimSVTenBatDauBangA();
                        break;
                    case "5":
                        quanLy.TinhTongTuoi();
                        break;
                    case "6":
                        quanLy.TimSVTuoiLonNhat();
                        break;
                    case "7":
                        quanLy.SapXepTheoTuoiTangDan();
                        break;
                    case "0":
                        dangChay = false;
                        Console.WriteLine("\nCam on da su dung chuong trinh. Tam biet!");
                        break;
                    default:
                        Console.WriteLine("\nLua chon khong hop le. Vui long nhap so tu 0 den 7.");
                        break;
                }
            }
        }
    }
}
