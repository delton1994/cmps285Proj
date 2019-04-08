using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StarterProject.Api.Data;
using StarterProject.Api.Data.Entites;
using StarterProject.Api.Features.Users;

namespace StarterProject.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserResultsController : ControllerBase
    {
        private readonly IUserRepository _context;

        public UserResultsController(IUserRepository context)
        {
            _context = context;
        }

        [HttpGet("{userId:int}/{languageId:int}")]
        [ProducesResponseType(typeof(UserResultDto), (int) HttpStatusCode.OK)]
        public IActionResult GetResult(int userId,int languageId)
        {
            var userResult = _context.GetResult(userId, languageId);
            return Ok(userResult);
        }

        [HttpGet("GetAll/{userId:int}")]
        [ProducesResponseType(typeof(List<UserResultDto>), (int)HttpStatusCode.OK)]
        public IActionResult GetAllResults(int userId)
        {
            var userResult = _context.GetAllResult(userId);
            return Ok(userResult);
        }

        [HttpPost("{userId:int}")]
        [ProducesResponseType(typeof(UserResultDto), (int) HttpStatusCode.Created)]
        public IActionResult Post([FromBody] UserCreateResultDto userCreateResultDto)
        {
            var result = _context.CreateResult(userCreateResultDto);
            return Ok(result);
        }

        [HttpDelete("{userId:int}")]
        [ProducesResponseType((int) HttpStatusCode.OK)]
        public IActionResult DeleteResult( int userId)
        {
            _context.DeleteResult(userId);
            return Ok();
        }




    }
}
