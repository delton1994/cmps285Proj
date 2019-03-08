using System;
using System.Collections.Generic;
using System.Net;
using StarterProject.Api.Data.Entites;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using StarterProject.Api.Features.Questions;
using StarterProject.Api.Data;
using System.Linq;

namespace StarterProject.Api.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class QuestionController : ControllerBase
    {
        private readonly DataContext context;
        private readonly IQuestionRepository _questionRepository;
        private readonly ILogger<QuestionController> _logger;

        public QuestionController(IQuestionRepository questionRepository, ILogger<QuestionController> logger, DataContext Context)
        {
            context = Context; 
            _questionRepository = questionRepository;
            _logger = logger;
        }

        [HttpGet("GetAllQuestion/{id}")]
        [ProducesResponseType(typeof(List<LanguageGetDto>), (int) HttpStatusCode.OK)]
        public ActionResult Get(int id)
        {
            var questionsinDb = context.Questions.Where(x => x.LanguageId == id).ToList();
            foreach (var question in questionsinDb)
            {
                var choicesinDb = context.Set<Choice>().Where(x => x.QuestionId == question.Id).ToList();
                question.Choices.AddRange(choicesinDb);
            }
            return Ok(questionsinDb);
            try
            {
                return Ok(_questionRepository.GetAllQuestions());
            }
            catch (Exception ex)
            {
                _logger.LogError($"Failed to find Question: {ex}");
                return BadRequest("Failed to get Question. Please try again.");
            }
        }
    }
}