using BlazorApp.Shared.Models;

namespace BlazorApp.Server.Interfaces
{
    public interface ISinhVien
    {
        public List<SinhVien> GetSinhVienDetails();
        public void AddSinhVien(SinhVien sinhVien);
        public void UpdateSinhVienDetails(SinhVien sinhVien);
        public SinhVien GetSinhVienData(int msv);
        public void DeleteSinhVien(int msv);
    }
}
