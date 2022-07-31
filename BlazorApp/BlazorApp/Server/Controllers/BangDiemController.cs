using BlazorApp.Server.Interfaces;
using BlazorApp.Shared.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlazorApp.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BangDiemController : ControllerBase
    {
        private readonly IBangDiem _iBangDiem;
        public BangDiemController(IBangDiem bangDiem)
        {
            _iBangDiem = bangDiem;
        }
        [HttpGet]
        public async Task<List<BangDiem>> Get()
        {
            return await Task.FromResult(_iBangDiem.GetBangDiemDetails());
        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            BangDiem bangDiem = _iBangDiem.GetBangDiemData(id);
            if (bangDiem != null)
            {
                return Ok(bangDiem);
            }
            return NotFound();
        }
        [HttpPost]
        public void Post(BangDiem bangDiem)
        {
            _iBangDiem.AddBangDiem(bangDiem);
        }
        [HttpPut]
        public void Put(BangDiem bangDiem)
        {
            _iBangDiem.UpdateBangDiemDetails(bangDiem);
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _iBangDiem.DeleteBangDiem(id);
            return Ok();
        }
    }
}
