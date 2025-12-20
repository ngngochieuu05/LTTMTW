using System;
using System.Collections.Generic;
using System.Linq;
using DAL;
using DAL.Entities;

namespace BLL
{
    /// <summary>
    /// Business Logic Layer for DiaPhuong management
    /// </summary>
    public class DiaPhuongBLL
    {
        private DiaPhuongDAL diaPhuongDAL;
        private TrangThaiBLL trangThaiBLL;

        public DiaPhuongBLL()
        {
            diaPhuongDAL = new DiaPhuongDAL();
            trangThaiBLL = new TrangThaiBLL();
        }

        public List<DiaPhuong> GetAll()
        {
            return diaPhuongDAL.GetAll();
        }

        public DiaPhuong GetByMa(string maDP)
        {
            return diaPhuongDAL.GetByMa(maDP);
        }

        public List<TrangThai> GetAllTrangThai()
        {
            return trangThaiBLL.GetAll();
        }

        public string ValidateDiaPhuong(string maDP, string tenDP, string soCaNhiem, bool isUpdate = false)
        {
            if (string.IsNullOrWhiteSpace(maDP) || string.IsNullOrWhiteSpace(tenDP) || string.IsNullOrWhiteSpace(soCaNhiem))
            {
                return "Vui l?ng nh?p ð?y ð? thông tin!";
            }

            if (maDP.Length != 3)
            {
                return "M? ð?a phýõng ph?i là 3 k? t?!";
            }

            int soCa;
            if (!int.TryParse(soCaNhiem, out soCa) || soCa < 0)
            {
                return "S? ca nhi?m ph?i là s? nguyên l?n hõn ho?c b?ng 0!";
            }

            if (!isUpdate)
            {
                var existing = diaPhuongDAL.GetByMa(maDP);
                if (existing != null)
                {
                    return "M? ð?a phýõng ð? t?n t?i!";
                }
            }

            return null;
        }

        public bool ThemDiaPhuong(string maDP, string tenDP, int soCaNhiem, int maTT)
        {
            var errorMsg = ValidateDiaPhuong(maDP, tenDP, soCaNhiem.ToString(), false);
            if (!string.IsNullOrEmpty(errorMsg))
            {
                return false;
            }

            var diaPhuong = new DiaPhuong
            {
                MaDP = maDP,
                TenDP = tenDP,
                SoCaNhiemMoi = soCaNhiem,
                MaTT = maTT
            };

            return diaPhuongDAL.Insert(diaPhuong);
        }

        public bool CapNhatDiaPhuong(string maDP, string tenDP, int soCaNhiem, int maTT)
        {
            var diaPhuong = new DiaPhuong
            {
                MaDP = maDP,
                TenDP = tenDP,
                SoCaNhiemMoi = soCaNhiem,
                MaTT = maTT
            };

            return diaPhuongDAL.Update(diaPhuong);
        }

        public bool XoaDiaPhuong(string maDP)
        {
            return diaPhuongDAL.Delete(maDP);
        }

        public List<DiaPhuong> SapXepTheoSoCaNhiem(bool tangDan)
        {
            var danhSach = diaPhuongDAL.GetAll();
            
            if (tangDan)
                return danhSach.OrderBy(dp => dp.SoCaNhiemMoi).ToList();
            else
                return danhSach.OrderByDescending(dp => dp.SoCaNhiemMoi).ToList();
        }

        public List<DiaPhuong> GetDiaPhuongNguyCo()
        {
            var danhSach = diaPhuongDAL.GetAll();
            return danhSach.Where(dp => dp.TrangThai != null && 
                                       dp.TrangThai.TenTT != "B?nh thý?ng")
                          .ToList();
        }

        public string GetTenTrangThai(int maTT)
        {
            return trangThaiBLL.GetTenTrangThai(maTT);
        }

        public int GetTongSoCaNhiem()
        {
            var danhSach = diaPhuongDAL.GetAll();
            return danhSach.Sum(dp => dp.SoCaNhiemMoi);
        }

        public Dictionary<string, int> ThongKeSoDiaPhuongTheoTrangThai()
        {
            var danhSach = diaPhuongDAL.GetAll();
            return danhSach.GroupBy(dp => dp.TrangThai?.TenTT ?? "Không xác ð?nh")
                          .ToDictionary(g => g.Key, g => g.Count());
        }

        public void Dispose()
        {
            diaPhuongDAL?.Dispose();
            trangThaiBLL?.Dispose();
        }
    }
}


