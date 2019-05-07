using System.Collections.Generic;
using System.Net;
using StarterProject.Api.Data.Entites;
using Microsoft.AspNetCore.Mvc;
using StarterProject.Api.Features.Questions;
using StarterProject.Api.Data;
using System.Linq;

namespace StarterProject.Api.Controllers
{
    [Route("[Controller]")]
    [ApiController]
    public class QuestionController : ControllerBase
    {
        private readonly IQuestionRepository _context;
        
        public QuestionController(IQuestionRepository context)
        {
        _context = context;
        }
        
        [HttpGet("[Controller]")]
        [ProducesResponseType(typeof(List<QuestionGetDto>), (int)HttpStatusCode.OK)]
        public ActionResult Get()
        {
            var quest = _context.GetAllQuestions();
            return Ok(quest);
        }

        [HttpGet()]
        [ProducesResponseType(typeof(List<QuestionGetDto>), (int) HttpStatusCode.OK)]
        public IActionResult GetAll([FromQuery] int languageId)
        {
            var quest = _context.GetAllQuestions(languageId);
            return Ok(quest);
        }

    }


            
}