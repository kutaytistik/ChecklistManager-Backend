using Business.Abstract;
using Entiities.Concrete;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TemplatesController : ControllerBase
    {
        ITemplateService _templateService;


        public TemplatesController(ITemplateService templateService)
        {
            _templateService = templateService;

        }

        [HttpGet("getall")]
        public IActionResult Get()
        {

            var result = _templateService.GetAll();
            return Ok(result);
        }

        [HttpGet("getbyid")]
        public IActionResult Get(int id)
        {

            var result = _templateService.GetById(id);
            return Ok(result);

        }

        [HttpPost("add")]
        public IActionResult Add(Template template)
        {
            _templateService.Add(template);
            return Ok();

        }

        [HttpPost("delete")]
        public IActionResult Delete(Template template)
        {
            _templateService.Delete(template);
            return Ok();
        }

        [HttpPost("update")]
        public IActionResult Update(Template template)
        {

            _templateService.Update(template);
            return Ok();
        }

        [HttpPut("updatecheckbox")]
        public IActionResult UpdateCheckbox(ChecklistItem item)
        {
            _templateService.UpdateCheckbox(item);
            return Ok();
        }
    }
}
