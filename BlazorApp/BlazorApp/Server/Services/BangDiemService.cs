using BlazorApp.Server.Interfaces;
using BlazorApp.Server.Models;
using BlazorApp.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp.Server.Services
{
    public class BangDiemService : IBangDiem
    {
        readonly SinhVienContext _context;
        public BangDiemService(SinhVienContext context)
        {
            _context = context;
        }
        public List<BangDiem> GetBangDiemDetails()
        {
            try
            {
                return _context.BangDiems.ToList();
            }
            catch
            {
                throw;
            }
        }
        public void AddBangDiem(BangDiem bangDiem)
        {

            _context.BangDiems.Add(bangDiem);
            _context.SaveChanges();

        }
        public void UpdateBangDiemDetails(BangDiem bangDiem)
        {
            try
            {
                _context.Entry(bangDiem).State = EntityState.Modified;
                _context.SaveChanges();
            }
            catch
            {
                throw;
            }
        }
        public void DeleteBangDiem(int id)
        {
            try
            {
                BangDiem? bangDiem = _context.BangDiems.Find(id);
                if (bangDiem != null)
                {
                    _context.BangDiems.Remove(bangDiem);
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

        public BangDiem GetBangDiemData(int id)
        {
            try
            {
                BangDiem? bangDiem = _context.BangDiems.Find(id);
                if (bangDiem != null)
                {
                    return bangDiem;
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
