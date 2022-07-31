using BlazorApp.Shared.Models;

namespace BlazorApp.Server.Interfaces
{
    public interface ILop
    {
        public List<Lop> GetLopDetails();
        public void AddLop(Lop lop);
        public void UpdateLopDetails(Lop lop);
        public Lop GetLopData(int maLop);
        public void DeleteLop(int maLop);
    }
}
