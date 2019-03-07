using System;
using System.Collections.Generic;
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
        public ActionResult<IEnumerable<Language>> Get()
        {
            try
            {
                return Ok(_languageRepository.GetAllLanguages());
            }
            catch (Exception ex)
            {
                _logger.LogError($"Failed to find Language: {ex}");
                return BadRequest("Failed to get Language. Please try again.");
            }
        }
    }
}