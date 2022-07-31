using BlazorApp.Shared.Models;

namespace BlazorApp.Server.Interfaces
{
    public interface IBangDiem
    {
        public List<BangDiem> GetBangDiemDetails();
        public void AddBangDiem(BangDiem bangDiem);
        public void UpdateBangDiemDetails(BangDiem bangDiem);
        public BangDiem GetBangDiemData(int id);
        public void DeleteBangDiem(int id);
    }
}
