using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChecklistItemsController : ControllerBase
    {
        IChecklistItemService _checklistItemService;

        public ChecklistItemsController(IChecklistItemService checklistItemService)
        {
            _checklistItemService = checklistItemService;

        }

        [HttpGet("getall")]
        public IActionResult Get()
        {

            var result = _checklistItemService.GetAll();
            return Ok(result);
        }

        [HttpGet("getbyid")]
        public IActionResult Get(int id)
        {

            var result = _checklistItemService.GetById(id);
            return Ok(result);

        }

        [HttpPost("add")]
        public IActionResult Add(ChecklistItem checklistItem)
        {

            _checklistItemService.Add(checklistItem);
            return Ok();

        }

        [HttpPost("delete")]
        public IActionResult Delete(ChecklistItem checklistItem)
        {
            _checklistItemService.Delete(checklistItem);
            return Ok();
        }

        [HttpPost("update")]
        public IActionResult Update(ChecklistItem checklistItem)
        {

            _checklistItemService.Update(checklistItem);
            return Ok();
        }

    }
}

