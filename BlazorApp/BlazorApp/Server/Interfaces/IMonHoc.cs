using BlazorApp.Shared.Models;

namespace BlazorApp.Server.Interfaces
{
    public interface IMonHoc
    {
        public List<MonHoc> GetMonHocDetails();
        public void AddMonHoc(MonHoc monHoc);
        public void UpdateMonHocDetails(MonHoc monHoc);
        public MonHoc GetMonHocData(int maMonHoc);
        public void DeleteMonHoc(int maMonHoc);
    }
}
