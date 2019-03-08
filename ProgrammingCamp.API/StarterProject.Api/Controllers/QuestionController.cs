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
        private readonly IQuestionRepository _questionRepository;
        

        public QuestionController(IQuestionRepository questionRepository)
        {
            _questionRepository = questionRepository;
        }

        [HttpGet("[controller]")]
        [ProducesResponseType(typeof(List<QuestionGetDto>), (int) HttpStatusCode.OK)]
        public IActionResult GetAll()
        {
               var quest = _questionRepository.GetAllQuestions();
               return Ok(quest);
        }
    }
}