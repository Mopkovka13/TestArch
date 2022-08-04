using Microsoft.AspNetCore.Mvc;
using TestArchitecture.API.Contracts;
using TestArchitecture.Core.Service;

namespace TestArchitecture.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeworksController : ControllerBase
    {
        private readonly IHomeworksService _homeworksService;
        public HomeworksController(IHomeworksService homeworksService)
        {
            _homeworksService = homeworksService;
        }

        [HttpPost]
        public async Task<ActionResult> Create([FromBody] NewHomework request) //полученный от пользователя
        {
            var homework = new Core.Homework //Нужно смапить для обработки в BL
            {
                Title = request.Title,
                Description = request.Description,
                Link = request.Link
            };

            var result = await _homeworksService.Create(homework); //Вызвать метод из BL

            return Ok(result);
        }
    }
}
