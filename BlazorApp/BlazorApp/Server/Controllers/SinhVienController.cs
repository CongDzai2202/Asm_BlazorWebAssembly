using BlazorApp.Server.Interfaces;
using BlazorApp.Shared.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlazorApp.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SinhVienController : ControllerBase
    {
        private readonly ISinhVien _iSinhVien;
        public SinhVienController(ISinhVien sinhVien)
        {
            _iSinhVien = sinhVien;
        }
        [HttpGet]
        public async Task<List<SinhVien>> Get()
        {
            return await Task.FromResult(_iSinhVien.GetSinhVienDetails());
        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            SinhVien sv = _iSinhVien.GetSinhVienData(id);
            if (sv != null)
            {
                return Ok(sv);
            }
            return NotFound();
        }
        [HttpPost]
        public void Post(SinhVien sv)
        {
            _iSinhVien.AddSinhVien(sv);
        }
        [HttpPut]
        public void Put(SinhVien sv)
        {
            _iSinhVien.UpdateSinhVienDetails(sv);
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _iSinhVien.DeleteSinhVien(id);
            return Ok();
        }
    }
}
