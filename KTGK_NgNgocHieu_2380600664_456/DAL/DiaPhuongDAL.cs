using System;
using System.Collections.Generic;
using System.Linq;
using DAL.Entities;

namespace DAL
{
    /// <summary>
    /// Data Access Layer for DiaPhuong entity
    /// </summary>
    public class DiaPhuongDAL
    {
        private Model1 context;

        public DiaPhuongDAL()
        {
            context = new Model1();
        }

        public List<DiaPhuong> GetAll()
        {
            return context.DiaPhuong.Include("TrangThai").ToList();
        }

        public DiaPhuong GetByMa(string maDP)
        {
            return context.DiaPhuong.Include("TrangThai").FirstOrDefault(dp => dp.MaDP == maDP);
        }

        public bool Insert(DiaPhuong diaPhuong)
        {
            try
            {
                context.DiaPhuong.Add(diaPhuong);
                context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Update(DiaPhuong diaPhuong)
        {
            try
            {
                var existing = context.DiaPhuong.Find(diaPhuong.MaDP);
                if (existing != null)
                {
                    existing.TenDP = diaPhuong.TenDP;
                    existing.SoCaNhiemMoi = diaPhuong.SoCaNhiemMoi;
                    existing.MaTT = diaPhuong.MaTT;
                    context.SaveChanges();
                    return true;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }

        public bool Delete(string maDP)
        {
            try
            {
                var diaPhuong = context.DiaPhuong.Find(maDP);
                if (diaPhuong != null)
                {
                    context.DiaPhuong.Remove(diaPhuong);
                    context.SaveChanges();
                    return true;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }

        public void Dispose()
        {
            context?.Dispose();
        }
    }
}



