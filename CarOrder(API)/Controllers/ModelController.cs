using Business.Abstract;
using DTO.EntityDTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarOrder_API_.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ModelController : ControllerBase
    {
        private readonly IModel _model;

        public ModelController(IModel model)
        {
            _model = model;
        }
        [HttpGet]
        public IActionResult ModelGet()
        {
            var values = _model.GetAll();
            return Ok(values);
        }
        [HttpGet("id")]
        public IActionResult ModelGetId(int id)
        {
            var values = _model.GetById(id);
            return Ok(values);
        }
        [HttpPost]
        public IActionResult ModelInsert(ModelDTO dto)
        {
            var answer = "Succesfully Added";
            _model.Insert(dto);
            return Ok(answer);
        }
        [HttpPut]
        public IActionResult ModelUpdate(ModelDTO dto)
        {
            var answer = "Succesfully updated";
            _model.Update(dto);
            return Ok(answer);
        }
        [HttpDelete]
        public IActionResult ModelDelete(int id)
        {
            var answer = "Deleted";
            _model.Delete(id);
            return Ok(answer);
        }
    }
}
