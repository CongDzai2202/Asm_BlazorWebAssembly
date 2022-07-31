using BlazorApp.Shared.Models;

namespace BlazorApp.Server.Interfaces
{
    public interface INganh
    {
        public List<Nganh> GetNganhDetails();
        public void AddNganh(Nganh nganh);
        public void UpdateNganhDetails(Nganh nganh);
        public Nganh GetNganhData(int id);
        public void DeleteNganh(int id);
    }
}
