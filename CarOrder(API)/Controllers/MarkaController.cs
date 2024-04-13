using Business.Abstract;
using DTO.EntityDTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarOrder_API_.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MarkaController : ControllerBase
    {
        private readonly IMarka _marka;

        public MarkaController(IMarka marka)
        {
            _marka = marka;
        }
        [HttpGet]
        public IActionResult MarkaGet()
        {
            var values = _marka.GetAll();
            return Ok(values);
        }
        [HttpGet("id")]
        public IActionResult MarkaGetId(int id)
        {
            var values=_marka.GetById(id);
            return Ok(values);
        }
        [HttpPost]
        public IActionResult MarkaInsert(MarkaDTO dto)
        {
            var answer = "Succesfully Added";
            _marka.Insert(dto);
            return Ok(answer);
        }
        [HttpPut]
        public IActionResult MarkaUpdate(MarkaDTO dto)
        {
            var answer = "Succesfully Updated";
            _marka.Update(dto);
            return Ok(answer);
        }
        [HttpDelete]
        public IActionResult MarkaDelete(int id)
        {
            var answer = "Deleted";
            _marka.Delete(id);
            return Ok(answer);
        }
    }
}
