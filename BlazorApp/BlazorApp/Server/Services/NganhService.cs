using BlazorApp.Server.Interfaces;
using BlazorApp.Server.Models;
using BlazorApp.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp.Server.Services
{
    public class NganhService : INganh
    {
        public readonly SinhVienContext _context;
        public NganhService(SinhVienContext context)
        {
            _context = context;
        }

        public void AddNganh(Nganh nganh)
        {
            try
            {
                _context.Nganhs.Add(nganh);
                _context.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        public void DeleteNganh(int id)
        {
            try
            {
                Nganh? nganh = _context.Nganhs.Find(id);
                if (nganh != null)
                {
                    _context.Nganhs.Remove(nganh);
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

        public Nganh GetNganhData(int id)
        {
            try
            {
                Nganh? nganh = _context.Nganhs.Find(id);
                if (nganh != null)
                {
                    return nganh;
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

        public List<Nganh> GetNganhDetails()
        {
            try
            {
                return _context.Nganhs.ToList();
            }
            catch
            {
                throw;
            }
        }

        public void UpdateNganhDetails(Nganh nganh)
        {
            try
            {
                _context.Entry(nganh).State = EntityState.Modified;
                _context.SaveChanges();
            }
            catch
            {
                throw;
            }
        }
    }
}
