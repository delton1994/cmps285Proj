using System.Collections.Generic;
using System.Net;
using StarterProject.Api.Data.Entites;
using Microsoft.AspNetCore.Mvc;
using StarterProject.Api.Features.Questions;


namespace StarterProject.Api.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class QuestionController : ControllerBase
    {
        private readonly IQuestionRepository _context;
        

        public QuestionController(IQuestionRepository context)
        {
            _context = context;
        }

        [HttpGet("[controller]")]
        [ProducesResponseType(typeof(List<QuestionGetDto>), (int) HttpStatusCode.OK)]
        public IActionResult GetAll()
        {
               var quest = _context.GetAllQuestions();
               return Ok(quest);
        }
    }
}