using System.Collections.Generic;
using System.Net;
using StarterProject.Api.Data.Entites;
using Microsoft.AspNetCore.Mvc;
using StarterProject.Api.Features.Choices;



namespace StarterProject.Api.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class ChoiceController : ControllerBase
    {
        private readonly IChoiceRepository _choiceRepository;


        public ChoiceController(IChoiceRepository choiceRepository)
        {
            _choiceRepository = choiceRepository;
        }

        [HttpGet("[controller]")]
        [ProducesResponseType(typeof(List<ChoiceGetDto>), (int)HttpStatusCode.OK)]
        public IActionResult GetAll()
        {
            var choice = _choiceRepository.GetAllChoices();
            return Ok(choice);
        }
    }
}