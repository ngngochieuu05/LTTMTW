using System;
using System.Collections.Generic;
using System.Linq;
using DAL.Entities;

namespace DAL
{
    /// <summary>
    /// Data Access Layer for TrangThai entity
    /// </summary>
    public class TrangThaiDAL
    {
        private Model1 context;

        public TrangThaiDAL()
        {
            context = new Model1();
        }

        public List<TrangThai> GetAll()
        {
            return context.TrangThai.ToList();
        }

        public TrangThai GetByMa(int maTT)
        {
            return context.TrangThai.Find(maTT);
        }

        public void Dispose()
        {
            context?.Dispose();
        }
    }
}

