using BlazorApp.Server.Interfaces;
using BlazorApp.Shared.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlazorApp.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MonHocController : ControllerBase
    {
        private readonly IMonHoc _iMonHoc;
        public MonHocController(IMonHoc monHoc)
        {
            _iMonHoc = monHoc;
        }
        [HttpGet]
        public async Task<List<MonHoc>> Get()
        {
            return await Task.FromResult(_iMonHoc.GetMonHocDetails());
        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            MonHoc monHoc = _iMonHoc.GetMonHocData(id);
            if (monHoc != null)
            {
                return Ok(monHoc);
            }
            return NotFound();
        }
        [HttpPost]
        public void Post(MonHoc monHoc)
        {
            _iMonHoc.AddMonHoc(monHoc);
        }
        [HttpPut]
        public void Put(MonHoc monHoc)
        {
            _iMonHoc.UpdateMonHocDetails(monHoc);
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _iMonHoc.DeleteMonHoc(id);
            return Ok();
        }
    }
}
