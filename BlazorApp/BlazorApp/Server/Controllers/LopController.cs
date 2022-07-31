using BlazorApp.Server.Interfaces;
using BlazorApp.Shared.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlazorApp.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LopController : ControllerBase
    {
        private readonly ILop _iLop;
        public LopController(ILop lop)
        {
            _iLop = lop;
        }
        [HttpGet]
        public async Task<List<Lop>> Get()
        {
            return await Task.FromResult(_iLop.GetLopDetails());
        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            Lop lop = _iLop.GetLopData(id);
            if (lop != null)
            {
                return Ok(lop);
            }
            return NotFound();
        }
        [HttpPost]
        public void Post(Lop lop)
        {
            _iLop.AddLop(lop);
        }
        [HttpPut]
        public void Put(Lop lop)
        {
            _iLop.UpdateLopDetails(lop);
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _iLop.DeleteLop(id);
            return Ok();
        }
    }
}
