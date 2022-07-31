using BlazorApp.Server.Interfaces;
using BlazorApp.Shared.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlazorApp.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NganhController : ControllerBase
    {
        private readonly INganh _iNganh;
        public NganhController(INganh nganh)
        {
            _iNganh = nganh;
        }
        [HttpGet]
        public async Task<List<Nganh>> Get()
        {
            return await Task.FromResult(_iNganh.GetNganhDetails());
        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            Nganh nganh = _iNganh.GetNganhData(id);
            if (nganh != null)
            {
                return Ok(nganh);
            }
            return NotFound();
        }
        [HttpPost]
        public void Post(Nganh nganh)
        {
            _iNganh.AddNganh(nganh);
        }
        [HttpPut]
        public void Put(Nganh nganh)
        {
            _iNganh.UpdateNganhDetails(nganh);
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _iNganh.DeleteNganh(id);
            return Ok();
        }
    }
}
