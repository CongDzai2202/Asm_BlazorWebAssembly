using BlazorApp.Server.Interfaces;
using BlazorApp.Server.Models;
using BlazorApp.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp.Server.Services
{
    public class MonHocService : IMonHoc

    {
        public readonly SinhVienContext _context;
        public MonHocService(SinhVienContext context)
        {
            _context = context;
        }

        public List<MonHoc> GetMonHocDetails()
        {
            try
            {
                return _context.MonHocs.ToList();
            }
            catch
            {
                throw;
            }
        }
        public void AddMonHoc(MonHoc monHoc)
        {
            try
            {
                _context.MonHocs.Add(monHoc);
                _context.SaveChanges();
            }
            catch
            {
                throw;
            }
        }
        public void UpdateMonHocDetails(MonHoc monHoc)
        {
            try
            {
                _context.Entry(monHoc).State = EntityState.Modified;
                _context.SaveChanges();
            }
            catch
            {
                throw;
            }
        }
        public void DeleteMonHoc(int maMonHoc)
        {
            try
            {
                MonHoc? monHoc = _context.MonHocs.Find(maMonHoc);
                if (monHoc != null)
                {
                    _context.MonHocs.Remove(monHoc);
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

        public MonHoc GetMonHocData(int maMonHoc)
        {
            try
            {
                MonHoc? monHoc = _context.MonHocs.Find(maMonHoc);
                if (monHoc != null)
                {
                    return monHoc;
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
