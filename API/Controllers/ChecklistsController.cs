
using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChecklistsController : ControllerBase
    {
        IChecklistService _checklistService;


        public ChecklistsController(IChecklistService checklistService)
        {
            _checklistService = checklistService;

        }

        [HttpGet("getall")]
        public IActionResult Get()
        {

            var result = _checklistService.GetAll();
            return Ok(result);
        }

        [HttpGet("getbyid")]
        public IActionResult Get(int id)
        {

            var result = _checklistService.GetById(id);
            return Ok(result);

        }

        [HttpPost("add")]
        public IActionResult Add(Checklist checklist)
        {

            _checklistService.Add(checklist);
            return Ok();

        }

        [HttpPost("delete")]
        public IActionResult Delete(Checklist checklist)
        {
            _checklistService.Delete(checklist);
            return Ok();
        }

        [HttpPost("update")]
        public IActionResult Update(Checklist checklist)
        {

            _checklistService.Update(checklist);
            return Ok();
        }
    }
}
