using System;
using System.Collections.Generic;
using System.Linq;
using DAL;
using DAL.Entities;

namespace BLL
{
    /// <summary>
    /// Business Logic Layer for TrangThai management
    /// </summary>
    public class TrangThaiBLL
    {
        private TrangThaiDAL trangThaiDAL;

        public TrangThaiBLL()
        {
            trangThaiDAL = new TrangThaiDAL();
        }

        public List<TrangThai> GetAll()
        {
            return trangThaiDAL.GetAll();
        }

        public TrangThai GetByMa(int maTT)
        {
            return trangThaiDAL.GetByMa(maTT);
        }

        public string GetTenTrangThai(int maTT)
        {
            var trangThai = trangThaiDAL.GetByMa(maTT);
            return trangThai?.TenTT ?? "";
        }

        public bool IsTrangThaiExists(int maTT)
        {
            return trangThaiDAL.GetByMa(maTT) != null;
        }

        public void Dispose()
        {
            trangThaiDAL?.Dispose();
        }
    }
}

