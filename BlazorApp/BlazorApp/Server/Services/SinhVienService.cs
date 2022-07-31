using BlazorApp.Server.Interfaces;
using BlazorApp.Server.Models;
using BlazorApp.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp.Server.Services
{
    public class SinhVienService : ISinhVien
    {
        public readonly SinhVienContext _context;
        public SinhVienService(SinhVienContext context)
        {
            _context = context;
        }

        public void AddSinhVien(SinhVien sinhVien)
        {
            try
            {
                _context.SinhViens.Add(sinhVien);
                _context.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        public void DeleteSinhVien(int msv)
        {
            try
            {
                SinhVien? sinhVien = _context.SinhViens.Find(msv);
                if (sinhVien != null)
                {
                    _context.SinhViens.Remove(sinhVien);
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

        public SinhVien GetSinhVienData(int msv)
        {
            try
            {
                SinhVien? sinhVien = _context.SinhViens.Find(msv);
                if (sinhVien != null)
                {
                    return sinhVien;
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

        public List<SinhVien> GetSinhVienDetails()
        {
            try
            {
                return _context.SinhViens.ToList();
            }
            catch
            {
                throw;
            }
        }

        public void UpdateSinhVienDetails(SinhVien sinhVien)
        {
            try
            {
                _context.Entry(sinhVien).State = EntityState.Modified;
                _context.SaveChanges();
            }
            catch
            {
                throw;
            }
        }
    }
}
