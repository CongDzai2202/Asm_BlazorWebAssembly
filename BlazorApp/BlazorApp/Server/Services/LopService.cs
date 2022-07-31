using BlazorApp.Server.Interfaces;
using BlazorApp.Server.Models;
using BlazorApp.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp.Server.Services
{
    public class LopService : ILop
    {
        public readonly SinhVienContext _context;
        public LopService(SinhVienContext context)
        {
            _context = context;
        }
        public List<Lop> GetLopDetails()
        {
            try
            {
                return _context.Lops.ToList();
            }
            catch
            {
                throw;
            }
        }
        public void AddLop(Lop lop)
        {
            try
            {
                _context.Lops.Add(lop);
                _context.SaveChanges();
            }
            catch
            {
                throw;
            }
        }
        public void UpdateLopDetails(Lop lop)
        {
            try
            {
                _context.Entry(lop).State = EntityState.Modified;
                _context.SaveChanges();
            }
            catch
            {
                throw;
            }
        }
        public void DeleteLop(int maLop)
        {
            try
            {
                Lop? lop = _context.Lops.Find(maLop);
                if (lop != null)
                {
                    _context.Lops.Remove(lop);
                    _context.SaveChanges();
                }
                else
                {
                    throw new ArgumentNullException();
                }
            }
            catch
            {
                throw;
            }
        }

        public Lop GetLopData(int maLop)
        {
            try
            {
                Lop? lop = _context.Lops.Find(maLop);
                if (lop != null)
                {
                    return lop;
                }
                else
                {
                    throw new ArgumentNullException();
                }
            }
            catch
            {
                throw;
            }
        }
    }
}
