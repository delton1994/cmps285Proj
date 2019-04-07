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
        
        private readonly IQuestionRepository _questionRepository;
        private readonly ILogger<QuestionController> _logger;

        public QuestionController(IQuestionRepository questionRepository, ILogger<QuestionController> logger)
        {

            _questionRepository = questionRepository;
            _logger = logger;
        }

        [HttpGet]
        [ProducesResponseType(typeof(List<QuestionGetDto>), (int)HttpStatusCode.OK)]
        public ActionResult Get()
        {

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