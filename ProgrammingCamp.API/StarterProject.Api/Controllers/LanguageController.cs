using System;
using System.Collections.Generic;
using System.Net;
using StarterProject.Api.Data.Entites;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using StarterProject.Api.Features.Languages;


namespace StarterProject.Api.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class LanguageController : ControllerBase
    {
        private readonly ILanguageRepository _languageRepository;
        private readonly ILogger<LanguageController> _logger;

        public LanguageController(ILanguageRepository languageRepository, ILogger<LanguageController> logger)
        {
            _languageRepository = languageRepository;
            _logger = logger;
        }

        [HttpGet]
        [ProducesResponseType(typeof(List<LanguageGetDto>), (int)HttpStatusCode.OK)]
        public ActionResult Get()
        {
            try
            {
                 var lang =_languageRepository.GetAllLanguages();
                 return Ok(lang);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Failed to find Language: {ex}");
                return BadRequest("Failed to get Language. Please try again.");
            }
        }
    }
}